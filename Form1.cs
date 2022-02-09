using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using YugiohPriceMonitoring.Classes;

namespace YugiohPriceMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when search button is clicked. Calls APICalls querying methods for ProductIds
        /// Asynchronous due to http requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (!SearchTextBox.Text.Equals(string.Empty))
            {
                try
                {
                    //First grabs the product ids, then grabs the associated info of them
                    List<string> testList = await APICalls.queryProductIds(SearchTextBox.Text);
                    
                    // Checks for valid results
                    if (testList.Count == 0)
                    {
                        // Sets list to empty list and displays error.
                        SearchResultBox.DataSource = new List<Card>();
                        NewCollectionNoResultsLbl.Visible = true;
                    }
                    else
                    {
                        NewCollectionNoResultsLbl.Visible = false;
                        List<Card> cardList = await APICalls.queryByProductId(testList);

                        //Sets the datasource to the newly retrieved list to populate results
                        SearchResultBox.DataSource = cardList;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        /// <summary>
        /// Used for image displaying
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchResultBoxSelected(object sender, EventArgs e)
        {

            Card card = (Card)SearchResultBox.SelectedItem;

            CardImage.ImageLocation = card.ImagePath;
        }

        /// <summary>
        /// Adds a card from search results to the list in progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AddCardButton_Click(object sender, EventArgs e)
        {
            if (SearchResultBox.SelectedItem != null)
            {
                //Checks if required fields are set
                if (ConditionBox.SelectedItem == null)
                {
                    ErrorLabelAddCard.Text = "Please select condition of the card.";
                }
                else if (EditionBox.SelectedItem == null)
                {
                    ErrorLabelAddCard.Text = "Please select the edition of the card.";
                }
                else
                {
                    //Sets error label to empty and then queries SKU based on user input
                    ErrorLabelAddCard.Text = "";
                    Card card = (Card)SearchResultBox.SelectedItem;
                    string productId = card.getProductId();

                    string productSku = await APICalls.queryProductSku(productId,
                        ConditionBox.SelectedItem.ToString(),
                        EditionBox.SelectedItem.ToString());

                    if (productSku.Equals("NOSKU"))
                    {
                        ErrorLabelAddCard.Text = "No card with specified fields was found.";
                    }
                    else
                    {

                        card.setProductSku(productSku);
                        card.setCondition(ConditionBox.SelectedItem.ToString());
                        card.setEdition(EditionBox.SelectedItem.ToString());
                        CardListBoxNew.Items.Add(card);
                    }
                }
            }
        }

        /// <summary>
        /// Removes a card from the list in progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButtonNew_Click(object sender, EventArgs e)
        {
            if (CardListBoxNew.SelectedItem != null)
            {
                CardListBoxNew.Items.Remove(CardListBoxNew.SelectedItem);
            }
        }

        /// <summary>
        /// Used to show card image of card selected in list in progress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardListBoxNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            Card card = (Card)CardListBoxNew.SelectedItem;

            //Important for after a card is removed from the list
            if (CardListBoxNew.SelectedItem == null)
            {
                CardImage.Image = Properties.Resources.yugiback;
            }
            else
            {
                CardImage.ImageLocation = card.ImagePath;
            }
        }

        /// <summary>
        /// Adds in the list into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            LoadingLbl.Text = "Loading...";

            if (!CollectionNameTextbox.Text.Equals(string.Empty)
                && CardListBoxNew.Items.Count != 0)
            {
                //Below logic required since Items list won't convert to List<Card>
                List<Card> cardList = new List<Card>();

                foreach (Card card in CardListBoxNew.Items)
                {
                    card.setCollection(CollectionNameTextbox.Text);
                    cardList.Add(card);
                }

                try
                {
                    SqlOps.addCardCollection(CollectionNameTextbox.Text, cardList);
                    ErrorLabelCreateCollection.Text = "";
                }
                catch (System.Data.SQLite.SQLiteException exception)
                {
                    ErrorLabelCreateCollection.Text = "Collection name already exists.";
                }
            }

            LoadingLbl.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Used to populate collections list from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MainTab.SelectedTab.Text == "View Collection")
                {
                    CollectionsListView.DataSource = SqlOps.getCollections();
                }
                else if (MainTab.SelectedTab.Text == "Edit Collection")
                {
                    EditCollectionsListBox.DataSource = SqlOps.getCollections();
                }
            }
            catch
            {
                //Can be caused by having no database or no collections
            }
        }

        /// <summary>
        /// Selects a collection and retrieves cards and info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (CollectionsListView.SelectedItem != null)
            {
                List<Card> collection = SqlOps.viewCollection(CollectionsListView.SelectedItem.ToString());

                CardListView.DataSource = collection;
                APICalls.queryPrices(collection);

                // Displays totals
                CollectionMarketLblValue.Text = "$" + Misc.getTotalPriceMarket(collection);
                CollectionLowestLblValue.Text = "$" + Misc.getTotalPriceLowest(collection);

                // Displays price of first card
                if (CardListView.SelectedItem != null)
                {
                    Card card = (Card)CardListView.SelectedItem;
                    CardMarketLblValue.Text = (card.getMarketPrice().Equals(string.Empty) ? "N/A" : "$" + card.getMarketPrice());
                    CardLowestLblValue.Text = (card.getLowestPrice().Equals(string.Empty) ? "N/A" : "$" + card.getLowestPrice());
                }
            }
        }

        /// <summary>
        /// Run when Index is changed in card collection in View collection section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardListView.Items.Count == 0)
            {
                SelectedCardView.Image = Properties.Resources.yugiback;
            }

            Card card = (Card)CardListView.SelectedItem;
            SelectedCardView.ImageLocation = card.getImagePath();

            CardMarketLblValue.Text = "$" + card.getMarketPrice();
            CardLowestLblValue.Text = "$" + card.getLowestPrice();
        }

        /// <summary>
        /// Run when tcgplayer listings link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListingsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CardListView.SelectedItem != null)
            {
                Card card = (Card)CardListView.SelectedItem;
                ListingsLink.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.tcgplayer.com/product/" + card.getProductId() + "?Language=English");
            }
        }

        /// <summary>
        /// Used for when view collection button is clicked. 
        /// Could eventually do away with view button and simply run this when index changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditViewCollectionBtn_Click(object sender, EventArgs e)
        {
            if (EditCollectionsListBox.SelectedItem != null)
            {
                List<Card> list = SqlOps.viewCollection(EditCollectionsListBox.SelectedItem.ToString());

                foreach (Card card in list)
                {
                    Console.WriteLine(card.getName());
                }
                EditCardsListBox.DataSource = list;
            }
        }

        /// <summary>
        /// Updates image for when card selected in card collection in Edit section is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditCardsListBox.SelectedItem != null)
            {
                Card card = (Card)EditCardsListBox.SelectedItem;

                EditCardImage.ImageLocation = card.ImagePath;
            }
            else
            {
                EditCardImage.Image = Properties.Resources.yugiback;
            }
        }

        /// <summary>
        /// Used for when collection is removed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditRemoveButton_Click(object sender, EventArgs e)
        {
            if (EditCardsListBox.SelectedItem != null)
            {
                Card card = (Card)EditCardsListBox.SelectedItem;

                SqlOps.removeCardFromCollection(card.getCardId());
                // Sets datasource to empty list. Null causes a bug where it no longer uses the name field as what gets displayed.
                EditCardsListBox.DataSource = SqlOps.viewCollection(EditCollectionsListBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Used when the search button in the Edit section is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EditSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EditSearchText.Text.Equals(string.Empty))
                {
                    //First grabs the product ids, then grabs the associated info of them
                    List<string> productIdList = await APICalls.queryProductIds(EditSearchText.Text);

                    // Checks for valid results
                    if (productIdList.Count == 0)
                    {
                        EditSearchError.Visible = true;
                        EditResultsBox.DataSource = new List<Card>();
                    }
                    else
                    {
                        EditSearchError.Visible = false;
                        List<Card> cardList = await APICalls.queryByProductId(productIdList);

                        //Sets the datasource to the newly retrieved list to populate results
                        EditResultsBox.DataSource = cardList;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Used for when the search results in the edit section has a new card selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditResultsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditResultsBox.SelectedItem != null)
            {
                Card card = (Card)EditResultsBox.SelectedItem;
                EditCardImage.ImageLocation = card.getImagePath();
            }
            else
            {
                EditCardImage.Image = Properties.Resources.yugiback;
            }
        }

        /// <summary>
        /// Run when a user adds a card to a collection in the edit section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EditAdd_Click(object sender, EventArgs e)
        {
            // Checking that there is a valid card to add.
            if (EditResultsBox.SelectedItem != null)
            {
                if (EditConditionBox.SelectedItem == null)
                {
                    EditConditionError.Visible = true;
                }

                // Following if blocks check that edition and condition are both set
                if (EditEditionBox.SelectedItem == null)
                {
                    if (EditConditionBox.SelectedItem != null)
                    {
                        EditConditionError.Visible = false;
                    }

                    EditEditionError.Visible = true;
                }
                else
                {
                    EditConditionError.Visible = false;
                    EditEditionError.Visible = false;

                    // Checking that a valid collection is present to add a card to. 
                    // Moved here so that API call isn't made when no collection is present.
                    if (EditCollectionsListBox.SelectedItem == null)
                    {
                        EditNullCollectionError.Visible = true;
                    }
                    else
                    {
                        EditNullCollectionError.Visible = false;

                        Card card = (Card)EditResultsBox.SelectedItem;
                        string productId = card.getProductId();

                        string productSku = await APICalls.queryProductSku(productId,
                            EditConditionBox.SelectedItem.ToString(),
                            EditEditionBox.SelectedItem.ToString());

                        if (productSku.Equals("NOSKU"))
                        {
                            EditSearchError.Visible = true;
                        }
                        else
                        {

                            EditSearchError.Visible = false;

                            card.setProductSku(productSku);
                            card.setCondition(EditConditionBox.SelectedItem.ToString());
                            card.setEdition(EditEditionBox.SelectedItem.ToString());

                            SqlOps.addCardToCardTable(EditCollectionsListBox.SelectedItem.ToString(), card);
                            EditCardsListBox.DataSource = SqlOps.viewCollection(EditCollectionsListBox.SelectedItem.ToString());

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Button used to close a connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCollectionBtn_Click(object sender, EventArgs e)
        {
            if (EditCollectionsListBox.SelectedItem != null)
            {
                SqlOps.removeCollection(EditCollectionsListBox.SelectedItem.ToString());

                EditCollectionsListBox.DataSource = SqlOps.getCollections();
                EditCardsListBox.DataSource = new List<Card>();
            }
        }
    }
}
