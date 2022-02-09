namespace YugiohPriceMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.TabControlMain = new System.Windows.Forms.TabPage();
            this.LoadingLbl = new System.Windows.Forms.Label();
            this.ErrorLabelCreateCollection = new System.Windows.Forms.Label();
            this.ErrorLabelAddCard = new System.Windows.Forms.Label();
            this.EditionBox = new System.Windows.Forms.ComboBox();
            this.ConditionBox = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.RemoveButtonNew = new System.Windows.Forms.Button();
            this.CardListLabelNew = new System.Windows.Forms.Label();
            this.CardListBoxNew = new System.Windows.Forms.ListBox();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.SearchResultsLabel = new System.Windows.Forms.Label();
            this.SearchResultBox = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CardSearchLabel = new System.Windows.Forms.Label();
            this.CollectionNameTextbox = new System.Windows.Forms.TextBox();
            this.CollectionNameLabel = new System.Windows.Forms.Label();
            this.TcgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditCollectionTab = new System.Windows.Forms.TabPage();
            this.EditNullCollectionError = new System.Windows.Forms.Label();
            this.EditSearchError = new System.Windows.Forms.Label();
            this.EditEditionError = new System.Windows.Forms.Label();
            this.EditConditionError = new System.Windows.Forms.Label();
            this.EditCardSearchLbl = new System.Windows.Forms.Label();
            this.EditSearchBtn = new System.Windows.Forms.Button();
            this.EditAdd = new System.Windows.Forms.Button();
            this.EditRemoveButton = new System.Windows.Forms.Button();
            this.EditEditionBox = new System.Windows.Forms.ComboBox();
            this.EditConditionBox = new System.Windows.Forms.ComboBox();
            this.EditResultsBox = new System.Windows.Forms.ListBox();
            this.EditSearchText = new System.Windows.Forms.TextBox();
            this.EditCardImage = new System.Windows.Forms.PictureBox();
            this.EditViewCollectionBtn = new System.Windows.Forms.Button();
            this.EditCardLbl = new System.Windows.Forms.Label();
            this.EditCollectionsLbl = new System.Windows.Forms.Label();
            this.EditCardsListBox = new System.Windows.Forms.ListBox();
            this.EditCollectionsListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditCollectionLbl = new System.Windows.Forms.Label();
            this.ViewCollectionTab = new System.Windows.Forms.TabPage();
            this.ListingsLink = new System.Windows.Forms.LinkLabel();
            this.CardLowestLblValue = new System.Windows.Forms.Label();
            this.CardMarketLblValue = new System.Windows.Forms.Label();
            this.CardLowestLbl = new System.Windows.Forms.Label();
            this.CardMarketLbl = new System.Windows.Forms.Label();
            this.CollectionLowestLblValue = new System.Windows.Forms.Label();
            this.CollectionMarketLblValue = new System.Windows.Forms.Label();
            this.SelectedCardView = new System.Windows.Forms.PictureBox();
            this.CollectionLowLbl = new System.Windows.Forms.Label();
            this.CollectionMarketLbl = new System.Windows.Forms.Label();
            this.CollectionsLblView = new System.Windows.Forms.Label();
            this.CardsLblView = new System.Windows.Forms.Label();
            this.CardListView = new System.Windows.Forms.ListBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.CollectionsListView = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TCGNotice = new System.Windows.Forms.Label();
            this.RemoveCollectionBtn = new System.Windows.Forms.Button();
            this.NewCollectionNoResultsLbl = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.TabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcgLogo)).BeginInit();
            this.EditCollectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditCardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ViewCollectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCardView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.TabControlMain);
            this.MainTab.Controls.Add(this.EditCollectionTab);
            this.MainTab.Controls.Add(this.ViewCollectionTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(870, 545);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.NewCollectionNoResultsLbl);
            this.TabControlMain.Controls.Add(this.LoadingLbl);
            this.TabControlMain.Controls.Add(this.ErrorLabelCreateCollection);
            this.TabControlMain.Controls.Add(this.ErrorLabelAddCard);
            this.TabControlMain.Controls.Add(this.EditionBox);
            this.TabControlMain.Controls.Add(this.ConditionBox);
            this.TabControlMain.Controls.Add(this.CreateButton);
            this.TabControlMain.Controls.Add(this.RemoveButtonNew);
            this.TabControlMain.Controls.Add(this.CardListLabelNew);
            this.TabControlMain.Controls.Add(this.CardListBoxNew);
            this.TabControlMain.Controls.Add(this.AddCardButton);
            this.TabControlMain.Controls.Add(this.CardImage);
            this.TabControlMain.Controls.Add(this.SearchResultsLabel);
            this.TabControlMain.Controls.Add(this.SearchResultBox);
            this.TabControlMain.Controls.Add(this.SearchButton);
            this.TabControlMain.Controls.Add(this.SearchTextBox);
            this.TabControlMain.Controls.Add(this.CardSearchLabel);
            this.TabControlMain.Controls.Add(this.CollectionNameTextbox);
            this.TabControlMain.Controls.Add(this.CollectionNameLabel);
            this.TabControlMain.Controls.Add(this.TcgLogo);
            this.TabControlMain.Controls.Add(this.label1);
            this.TabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.Location = new System.Drawing.Point(4, 25);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabControlMain.Size = new System.Drawing.Size(862, 516);
            this.TabControlMain.TabIndex = 0;
            this.TabControlMain.Text = "New Collection";
            this.TabControlMain.UseVisualStyleBackColor = true;
            // 
            // LoadingLbl
            // 
            this.LoadingLbl.AutoSize = true;
            this.LoadingLbl.Location = new System.Drawing.Point(307, 88);
            this.LoadingLbl.Name = "LoadingLbl";
            this.LoadingLbl.Size = new System.Drawing.Size(0, 20);
            this.LoadingLbl.TabIndex = 26;
            // 
            // ErrorLabelCreateCollection
            // 
            this.ErrorLabelCreateCollection.AutoSize = true;
            this.ErrorLabelCreateCollection.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelCreateCollection.Location = new System.Drawing.Point(307, 87);
            this.ErrorLabelCreateCollection.Name = "ErrorLabelCreateCollection";
            this.ErrorLabelCreateCollection.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabelCreateCollection.TabIndex = 25;
            // 
            // ErrorLabelAddCard
            // 
            this.ErrorLabelAddCard.AutoSize = true;
            this.ErrorLabelAddCard.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabelAddCard.Location = new System.Drawing.Point(409, 477);
            this.ErrorLabelAddCard.Name = "ErrorLabelAddCard";
            this.ErrorLabelAddCard.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabelAddCard.TabIndex = 24;
            // 
            // EditionBox
            // 
            this.EditionBox.FormattingEnabled = true;
            this.EditionBox.Items.AddRange(new object[] {
            "1st Edition",
            "Unlimited",
            "Limited"});
            this.EditionBox.Location = new System.Drawing.Point(226, 474);
            this.EditionBox.Name = "EditionBox";
            this.EditionBox.Size = new System.Drawing.Size(177, 28);
            this.EditionBox.TabIndex = 23;
            this.EditionBox.Text = "Edition";
            // 
            // ConditionBox
            // 
            this.ConditionBox.FormattingEnabled = true;
            this.ConditionBox.Items.AddRange(new object[] {
            "Near Mint",
            "Lightly Played",
            "Moderately Played",
            "Heavily Played",
            "Damaged"});
            this.ConditionBox.Location = new System.Drawing.Point(24, 474);
            this.ConditionBox.Name = "ConditionBox";
            this.ConditionBox.Size = new System.Drawing.Size(177, 28);
            this.ConditionBox.TabIndex = 22;
            this.ConditionBox.Text = "Conditon";
            this.ConditionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.CreateButton.Location = new System.Drawing.Point(226, 85);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 26);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RemoveButtonNew
            // 
            this.RemoveButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RemoveButtonNew.Location = new System.Drawing.Point(770, 206);
            this.RemoveButtonNew.Name = "RemoveButtonNew";
            this.RemoveButtonNew.Size = new System.Drawing.Size(75, 24);
            this.RemoveButtonNew.TabIndex = 15;
            this.RemoveButtonNew.Text = "Remove";
            this.RemoveButtonNew.UseVisualStyleBackColor = true;
            this.RemoveButtonNew.Click += new System.EventHandler(this.RemoveButtonNew_Click);
            // 
            // CardListLabelNew
            // 
            this.CardListLabelNew.AutoSize = true;
            this.CardListLabelNew.Location = new System.Drawing.Point(510, 183);
            this.CardListLabelNew.Name = "CardListLabelNew";
            this.CardListLabelNew.Size = new System.Drawing.Size(78, 20);
            this.CardListLabelNew.TabIndex = 14;
            this.CardListLabelNew.Text = "Card List";
            // 
            // CardListBoxNew
            // 
            this.CardListBoxNew.DisplayMember = "NameAndSet";
            this.CardListBoxNew.FormattingEnabled = true;
            this.CardListBoxNew.HorizontalScrollbar = true;
            this.CardListBoxNew.ItemHeight = 20;
            this.CardListBoxNew.Location = new System.Drawing.Point(514, 206);
            this.CardListBoxNew.Name = "CardListBoxNew";
            this.CardListBoxNew.ScrollAlwaysVisible = true;
            this.CardListBoxNew.Size = new System.Drawing.Size(239, 244);
            this.CardListBoxNew.TabIndex = 13;
            this.CardListBoxNew.SelectedIndexChanged += new System.EventHandler(this.CardListBoxNew_SelectedIndexChanged);
            // 
            // AddCardButton
            // 
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.AddCardButton.Location = new System.Drawing.Point(345, 206);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(75, 24);
            this.AddCardButton.TabIndex = 12;
            this.AddCardButton.Text = "Add";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // CardImage
            // 
            this.CardImage.Image = global::YugiohPriceMonitoring.Properties.Resources.yugiback;
            this.CardImage.Location = new System.Drawing.Point(345, 245);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(144, 205);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardImage.TabIndex = 11;
            this.CardImage.TabStop = false;
            // 
            // SearchResultsLabel
            // 
            this.SearchResultsLabel.AutoSize = true;
            this.SearchResultsLabel.Location = new System.Drawing.Point(20, 183);
            this.SearchResultsLabel.Name = "SearchResultsLabel";
            this.SearchResultsLabel.Size = new System.Drawing.Size(124, 20);
            this.SearchResultsLabel.TabIndex = 10;
            this.SearchResultsLabel.Text = "Search Results";
            // 
            // SearchResultBox
            // 
            this.SearchResultBox.DisplayMember = "NameAndSet";
            this.SearchResultBox.FormattingEnabled = true;
            this.SearchResultBox.HorizontalScrollbar = true;
            this.SearchResultBox.ItemHeight = 20;
            this.SearchResultBox.Location = new System.Drawing.Point(24, 206);
            this.SearchResultBox.Name = "SearchResultBox";
            this.SearchResultBox.ScrollAlwaysVisible = true;
            this.SearchResultBox.Size = new System.Drawing.Size(299, 244);
            this.SearchResultBox.TabIndex = 9;
            this.SearchResultBox.SelectedIndexChanged += new System.EventHandler(this.SearchResultBoxSelected);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(226, 147);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 26);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(24, 147);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(195, 26);
            this.SearchTextBox.TabIndex = 7;
            // 
            // CardSearchLabel
            // 
            this.CardSearchLabel.AutoSize = true;
            this.CardSearchLabel.Location = new System.Drawing.Point(20, 124);
            this.CardSearchLabel.Name = "CardSearchLabel";
            this.CardSearchLabel.Size = new System.Drawing.Size(103, 20);
            this.CardSearchLabel.TabIndex = 6;
            this.CardSearchLabel.Text = "Card Search";
            // 
            // CollectionNameTextbox
            // 
            this.CollectionNameTextbox.Location = new System.Drawing.Point(24, 85);
            this.CollectionNameTextbox.Name = "CollectionNameTextbox";
            this.CollectionNameTextbox.Size = new System.Drawing.Size(195, 26);
            this.CollectionNameTextbox.TabIndex = 5;
            // 
            // CollectionNameLabel
            // 
            this.CollectionNameLabel.AutoSize = true;
            this.CollectionNameLabel.Location = new System.Drawing.Point(20, 62);
            this.CollectionNameLabel.Name = "CollectionNameLabel";
            this.CollectionNameLabel.Size = new System.Drawing.Size(132, 20);
            this.CollectionNameLabel.TabIndex = 4;
            this.CollectionNameLabel.Text = "Collection Name";
            // 
            // TcgLogo
            // 
            this.TcgLogo.Image = ((System.Drawing.Image)(resources.GetObject("TcgLogo.Image")));
            this.TcgLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("TcgLogo.InitialImage")));
            this.TcgLogo.Location = new System.Drawing.Point(589, 6);
            this.TcgLogo.Name = "TcgLogo";
            this.TcgLogo.Size = new System.Drawing.Size(267, 103);
            this.TcgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TcgLogo.TabIndex = 2;
            this.TcgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Collection";
            // 
            // EditCollectionTab
            // 
            this.EditCollectionTab.Controls.Add(this.RemoveCollectionBtn);
            this.EditCollectionTab.Controls.Add(this.EditNullCollectionError);
            this.EditCollectionTab.Controls.Add(this.EditSearchError);
            this.EditCollectionTab.Controls.Add(this.EditEditionError);
            this.EditCollectionTab.Controls.Add(this.EditConditionError);
            this.EditCollectionTab.Controls.Add(this.EditCardSearchLbl);
            this.EditCollectionTab.Controls.Add(this.EditSearchBtn);
            this.EditCollectionTab.Controls.Add(this.EditAdd);
            this.EditCollectionTab.Controls.Add(this.EditRemoveButton);
            this.EditCollectionTab.Controls.Add(this.EditEditionBox);
            this.EditCollectionTab.Controls.Add(this.EditConditionBox);
            this.EditCollectionTab.Controls.Add(this.EditResultsBox);
            this.EditCollectionTab.Controls.Add(this.EditSearchText);
            this.EditCollectionTab.Controls.Add(this.EditCardImage);
            this.EditCollectionTab.Controls.Add(this.EditViewCollectionBtn);
            this.EditCollectionTab.Controls.Add(this.EditCardLbl);
            this.EditCollectionTab.Controls.Add(this.EditCollectionsLbl);
            this.EditCollectionTab.Controls.Add(this.EditCardsListBox);
            this.EditCollectionTab.Controls.Add(this.EditCollectionsListBox);
            this.EditCollectionTab.Controls.Add(this.pictureBox1);
            this.EditCollectionTab.Controls.Add(this.EditCollectionLbl);
            this.EditCollectionTab.Location = new System.Drawing.Point(4, 25);
            this.EditCollectionTab.Name = "EditCollectionTab";
            this.EditCollectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditCollectionTab.Size = new System.Drawing.Size(862, 516);
            this.EditCollectionTab.TabIndex = 1;
            this.EditCollectionTab.Text = "Edit Collection";
            this.EditCollectionTab.UseVisualStyleBackColor = true;
            // 
            // EditNullCollectionError
            // 
            this.EditNullCollectionError.AutoSize = true;
            this.EditNullCollectionError.ForeColor = System.Drawing.Color.Red;
            this.EditNullCollectionError.Location = new System.Drawing.Point(267, 154);
            this.EditNullCollectionError.Name = "EditNullCollectionError";
            this.EditNullCollectionError.Size = new System.Drawing.Size(152, 17);
            this.EditNullCollectionError.TabIndex = 32;
            this.EditNullCollectionError.Text = "No collection to add to!";
            this.EditNullCollectionError.Visible = false;
            // 
            // EditSearchError
            // 
            this.EditSearchError.AutoSize = true;
            this.EditSearchError.ForeColor = System.Drawing.Color.Red;
            this.EditSearchError.Location = new System.Drawing.Point(509, 164);
            this.EditSearchError.Name = "EditSearchError";
            this.EditSearchError.Size = new System.Drawing.Size(74, 17);
            this.EditSearchError.TabIndex = 31;
            this.EditSearchError.Text = "Not Found";
            this.EditSearchError.Visible = false;
            // 
            // EditEditionError
            // 
            this.EditEditionError.AutoSize = true;
            this.EditEditionError.ForeColor = System.Drawing.Color.Red;
            this.EditEditionError.Location = new System.Drawing.Point(517, 237);
            this.EditEditionError.Name = "EditEditionError";
            this.EditEditionError.Size = new System.Drawing.Size(66, 17);
            this.EditEditionError.TabIndex = 30;
            this.EditEditionError.Text = "Required";
            this.EditEditionError.Visible = false;
            // 
            // EditConditionError
            // 
            this.EditConditionError.AutoSize = true;
            this.EditConditionError.ForeColor = System.Drawing.Color.Red;
            this.EditConditionError.Location = new System.Drawing.Point(517, 201);
            this.EditConditionError.Name = "EditConditionError";
            this.EditConditionError.Size = new System.Drawing.Size(66, 17);
            this.EditConditionError.TabIndex = 29;
            this.EditConditionError.Text = "Required";
            this.EditConditionError.Visible = false;
            // 
            // EditCardSearchLbl
            // 
            this.EditCardSearchLbl.AutoSize = true;
            this.EditCardSearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditCardSearchLbl.Location = new System.Drawing.Point(584, 133);
            this.EditCardSearchLbl.Name = "EditCardSearchLbl";
            this.EditCardSearchLbl.Size = new System.Drawing.Size(123, 25);
            this.EditCardSearchLbl.TabIndex = 28;
            this.EditCardSearchLbl.Text = "Card Search";
            this.EditCardSearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditSearchBtn
            // 
            this.EditSearchBtn.Location = new System.Drawing.Point(759, 154);
            this.EditSearchBtn.Name = "EditSearchBtn";
            this.EditSearchBtn.Size = new System.Drawing.Size(75, 36);
            this.EditSearchBtn.TabIndex = 27;
            this.EditSearchBtn.Text = "Search";
            this.EditSearchBtn.UseVisualStyleBackColor = true;
            this.EditSearchBtn.Click += new System.EventHandler(this.EditSearchBtn_Click);
            // 
            // EditAdd
            // 
            this.EditAdd.Location = new System.Drawing.Point(759, 227);
            this.EditAdd.Name = "EditAdd";
            this.EditAdd.Size = new System.Drawing.Size(75, 36);
            this.EditAdd.TabIndex = 26;
            this.EditAdd.Text = "Add";
            this.EditAdd.UseVisualStyleBackColor = true;
            this.EditAdd.Click += new System.EventHandler(this.EditAdd_Click);
            // 
            // EditRemoveButton
            // 
            this.EditRemoveButton.Location = new System.Drawing.Point(382, 227);
            this.EditRemoveButton.Name = "EditRemoveButton";
            this.EditRemoveButton.Size = new System.Drawing.Size(75, 36);
            this.EditRemoveButton.TabIndex = 25;
            this.EditRemoveButton.Text = "Remove";
            this.EditRemoveButton.UseVisualStyleBackColor = true;
            this.EditRemoveButton.Click += new System.EventHandler(this.EditRemoveButton_Click);
            // 
            // EditEditionBox
            // 
            this.EditEditionBox.FormattingEnabled = true;
            this.EditEditionBox.Items.AddRange(new object[] {
            "1st Edition",
            "Unlimited",
            "Limited"});
            this.EditEditionBox.Location = new System.Drawing.Point(589, 234);
            this.EditEditionBox.Name = "EditEditionBox";
            this.EditEditionBox.Size = new System.Drawing.Size(157, 24);
            this.EditEditionBox.TabIndex = 24;
            this.EditEditionBox.Text = "Edition";
            // 
            // EditConditionBox
            // 
            this.EditConditionBox.FormattingEnabled = true;
            this.EditConditionBox.Items.AddRange(new object[] {
            "Near Mint",
            "Lightly Played",
            "Moderately Played",
            "Heavily Played",
            "Damaged"});
            this.EditConditionBox.Location = new System.Drawing.Point(589, 197);
            this.EditConditionBox.Name = "EditConditionBox";
            this.EditConditionBox.Size = new System.Drawing.Size(157, 24);
            this.EditConditionBox.TabIndex = 23;
            this.EditConditionBox.Text = "Conditon";
            // 
            // EditResultsBox
            // 
            this.EditResultsBox.DisplayMember = "NameAndSet";
            this.EditResultsBox.FormattingEnabled = true;
            this.EditResultsBox.HorizontalScrollbar = true;
            this.EditResultsBox.ItemHeight = 16;
            this.EditResultsBox.Location = new System.Drawing.Point(589, 275);
            this.EditResultsBox.Name = "EditResultsBox";
            this.EditResultsBox.ScrollAlwaysVisible = true;
            this.EditResultsBox.Size = new System.Drawing.Size(245, 212);
            this.EditResultsBox.TabIndex = 18;
            this.EditResultsBox.SelectedIndexChanged += new System.EventHandler(this.EditResultsBox_SelectedIndexChanged);
            // 
            // EditSearchText
            // 
            this.EditSearchText.Location = new System.Drawing.Point(589, 161);
            this.EditSearchText.Name = "EditSearchText";
            this.EditSearchText.Size = new System.Drawing.Size(157, 22);
            this.EditSearchText.TabIndex = 17;
            // 
            // EditCardImage
            // 
            this.EditCardImage.Image = global::YugiohPriceMonitoring.Properties.Resources.yugiback;
            this.EditCardImage.Location = new System.Drawing.Point(409, 282);
            this.EditCardImage.Name = "EditCardImage";
            this.EditCardImage.Size = new System.Drawing.Size(144, 205);
            this.EditCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditCardImage.TabIndex = 16;
            this.EditCardImage.TabStop = false;
            // 
            // EditViewCollectionBtn
            // 
            this.EditViewCollectionBtn.Location = new System.Drawing.Point(270, 73);
            this.EditViewCollectionBtn.Name = "EditViewCollectionBtn";
            this.EditViewCollectionBtn.Size = new System.Drawing.Size(75, 36);
            this.EditViewCollectionBtn.TabIndex = 15;
            this.EditViewCollectionBtn.Text = "View";
            this.EditViewCollectionBtn.UseVisualStyleBackColor = true;
            this.EditViewCollectionBtn.Click += new System.EventHandler(this.EditViewCollectionBtn_Click);
            // 
            // EditCardLbl
            // 
            this.EditCardLbl.AutoSize = true;
            this.EditCardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditCardLbl.Location = new System.Drawing.Point(20, 193);
            this.EditCardLbl.Name = "EditCardLbl";
            this.EditCardLbl.Size = new System.Drawing.Size(65, 25);
            this.EditCardLbl.TabIndex = 14;
            this.EditCardLbl.Text = "Cards";
            this.EditCardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCollectionsLbl
            // 
            this.EditCollectionsLbl.AutoSize = true;
            this.EditCollectionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditCollectionsLbl.Location = new System.Drawing.Point(20, 45);
            this.EditCollectionsLbl.Name = "EditCollectionsLbl";
            this.EditCollectionsLbl.Size = new System.Drawing.Size(108, 25);
            this.EditCollectionsLbl.TabIndex = 13;
            this.EditCollectionsLbl.Text = "Collections";
            this.EditCollectionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCardsListBox
            // 
            this.EditCardsListBox.DisplayMember = "MainFields";
            this.EditCardsListBox.FormattingEnabled = true;
            this.EditCardsListBox.HorizontalScrollbar = true;
            this.EditCardsListBox.ItemHeight = 16;
            this.EditCardsListBox.Location = new System.Drawing.Point(25, 227);
            this.EditCardsListBox.Name = "EditCardsListBox";
            this.EditCardsListBox.ScrollAlwaysVisible = true;
            this.EditCardsListBox.Size = new System.Drawing.Size(351, 260);
            this.EditCardsListBox.TabIndex = 8;
            this.EditCardsListBox.SelectedIndexChanged += new System.EventHandler(this.EditCardsListBox_SelectedIndexChanged);
            // 
            // EditCollectionsListBox
            // 
            this.EditCollectionsListBox.FormattingEnabled = true;
            this.EditCollectionsListBox.HorizontalScrollbar = true;
            this.EditCollectionsListBox.ItemHeight = 16;
            this.EditCollectionsListBox.Location = new System.Drawing.Point(25, 73);
            this.EditCollectionsListBox.Name = "EditCollectionsListBox";
            this.EditCollectionsListBox.ScrollAlwaysVisible = true;
            this.EditCollectionsListBox.Size = new System.Drawing.Size(239, 100);
            this.EditCollectionsListBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EditCollectionLbl
            // 
            this.EditCollectionLbl.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCollectionLbl.Location = new System.Drawing.Point(3, 3);
            this.EditCollectionLbl.Name = "EditCollectionLbl";
            this.EditCollectionLbl.Size = new System.Drawing.Size(320, 44);
            this.EditCollectionLbl.TabIndex = 2;
            this.EditCollectionLbl.Text = "Edit Collection";
            // 
            // ViewCollectionTab
            // 
            this.ViewCollectionTab.Controls.Add(this.ListingsLink);
            this.ViewCollectionTab.Controls.Add(this.CardLowestLblValue);
            this.ViewCollectionTab.Controls.Add(this.CardMarketLblValue);
            this.ViewCollectionTab.Controls.Add(this.CardLowestLbl);
            this.ViewCollectionTab.Controls.Add(this.CardMarketLbl);
            this.ViewCollectionTab.Controls.Add(this.CollectionLowestLblValue);
            this.ViewCollectionTab.Controls.Add(this.CollectionMarketLblValue);
            this.ViewCollectionTab.Controls.Add(this.SelectedCardView);
            this.ViewCollectionTab.Controls.Add(this.CollectionLowLbl);
            this.ViewCollectionTab.Controls.Add(this.CollectionMarketLbl);
            this.ViewCollectionTab.Controls.Add(this.CollectionsLblView);
            this.ViewCollectionTab.Controls.Add(this.CardsLblView);
            this.ViewCollectionTab.Controls.Add(this.CardListView);
            this.ViewCollectionTab.Controls.Add(this.ViewBtn);
            this.ViewCollectionTab.Controls.Add(this.CollectionsListView);
            this.ViewCollectionTab.Controls.Add(this.label3);
            this.ViewCollectionTab.Controls.Add(this.pictureBox2);
            this.ViewCollectionTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ViewCollectionTab.Location = new System.Drawing.Point(4, 25);
            this.ViewCollectionTab.Name = "ViewCollectionTab";
            this.ViewCollectionTab.Size = new System.Drawing.Size(862, 516);
            this.ViewCollectionTab.TabIndex = 2;
            this.ViewCollectionTab.Text = "View Collection";
            this.ViewCollectionTab.UseVisualStyleBackColor = true;
            // 
            // ListingsLink
            // 
            this.ListingsLink.AutoSize = true;
            this.ListingsLink.Location = new System.Drawing.Point(333, 459);
            this.ListingsLink.Name = "ListingsLink";
            this.ListingsLink.Size = new System.Drawing.Size(178, 18);
            this.ListingsLink.TabIndex = 21;
            this.ListingsLink.TabStop = true;
            this.ListingsLink.Text = "Link to TCGPlayer listings";
            this.ListingsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ListingsLink_LinkClicked);
            // 
            // CardLowestLblValue
            // 
            this.CardLowestLblValue.AutoSize = true;
            this.CardLowestLblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CardLowestLblValue.Location = new System.Drawing.Point(335, 367);
            this.CardLowestLblValue.Name = "CardLowestLblValue";
            this.CardLowestLblValue.Size = new System.Drawing.Size(44, 18);
            this.CardLowestLblValue.TabIndex = 20;
            this.CardLowestLblValue.Text = "$0.00";
            // 
            // CardMarketLblValue
            // 
            this.CardMarketLblValue.AutoSize = true;
            this.CardMarketLblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CardMarketLblValue.Location = new System.Drawing.Point(335, 306);
            this.CardMarketLblValue.Name = "CardMarketLblValue";
            this.CardMarketLblValue.Size = new System.Drawing.Size(44, 18);
            this.CardMarketLblValue.TabIndex = 19;
            this.CardMarketLblValue.Text = "$0.00";
            // 
            // CardLowestLbl
            // 
            this.CardLowestLbl.AutoSize = true;
            this.CardLowestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CardLowestLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CardLowestLbl.Location = new System.Drawing.Point(333, 342);
            this.CardLowestLbl.Name = "CardLowestLbl";
            this.CardLowestLbl.Size = new System.Drawing.Size(192, 25);
            this.CardLowestLbl.TabIndex = 18;
            this.CardLowestLbl.Text = "Card Value (Lowest)";
            // 
            // CardMarketLbl
            // 
            this.CardMarketLbl.AutoSize = true;
            this.CardMarketLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CardMarketLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CardMarketLbl.Location = new System.Drawing.Point(333, 281);
            this.CardMarketLbl.Name = "CardMarketLbl";
            this.CardMarketLbl.Size = new System.Drawing.Size(190, 25);
            this.CardMarketLbl.TabIndex = 17;
            this.CardMarketLbl.Text = "Card Value (Market)";
            // 
            // CollectionLowestLblValue
            // 
            this.CollectionLowestLblValue.AutoSize = true;
            this.CollectionLowestLblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CollectionLowestLblValue.Location = new System.Drawing.Point(333, 155);
            this.CollectionLowestLblValue.Name = "CollectionLowestLblValue";
            this.CollectionLowestLblValue.Size = new System.Drawing.Size(44, 18);
            this.CollectionLowestLblValue.TabIndex = 16;
            this.CollectionLowestLblValue.Text = "$0.00";
            // 
            // CollectionMarketLblValue
            // 
            this.CollectionMarketLblValue.AutoSize = true;
            this.CollectionMarketLblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CollectionMarketLblValue.Location = new System.Drawing.Point(333, 98);
            this.CollectionMarketLblValue.Name = "CollectionMarketLblValue";
            this.CollectionMarketLblValue.Size = new System.Drawing.Size(44, 18);
            this.CollectionMarketLblValue.TabIndex = 15;
            this.CollectionMarketLblValue.Text = "$0.00";
            // 
            // SelectedCardView
            // 
            this.SelectedCardView.Image = global::YugiohPriceMonitoring.Properties.Resources.yugiback;
            this.SelectedCardView.Location = new System.Drawing.Point(622, 200);
            this.SelectedCardView.Name = "SelectedCardView";
            this.SelectedCardView.Size = new System.Drawing.Size(213, 309);
            this.SelectedCardView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedCardView.TabIndex = 14;
            this.SelectedCardView.TabStop = false;
            // 
            // CollectionLowLbl
            // 
            this.CollectionLowLbl.AutoSize = true;
            this.CollectionLowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionLowLbl.Location = new System.Drawing.Point(331, 130);
            this.CollectionLowLbl.Name = "CollectionLowLbl";
            this.CollectionLowLbl.Size = new System.Drawing.Size(235, 25);
            this.CollectionLowLbl.TabIndex = 13;
            this.CollectionLowLbl.Text = "Collection Value (Lowest)";
            // 
            // CollectionMarketLbl
            // 
            this.CollectionMarketLbl.AutoSize = true;
            this.CollectionMarketLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CollectionMarketLbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CollectionMarketLbl.Location = new System.Drawing.Point(331, 73);
            this.CollectionMarketLbl.Name = "CollectionMarketLbl";
            this.CollectionMarketLbl.Size = new System.Drawing.Size(233, 25);
            this.CollectionMarketLbl.TabIndex = 1;
            this.CollectionMarketLbl.Text = "Collection Value (Market)";
            // 
            // CollectionsLblView
            // 
            this.CollectionsLblView.AutoSize = true;
            this.CollectionsLblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CollectionsLblView.Location = new System.Drawing.Point(20, 45);
            this.CollectionsLblView.Name = "CollectionsLblView";
            this.CollectionsLblView.Size = new System.Drawing.Size(108, 25);
            this.CollectionsLblView.TabIndex = 12;
            this.CollectionsLblView.Text = "Collections";
            this.CollectionsLblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardsLblView
            // 
            this.CardsLblView.AutoSize = true;
            this.CardsLblView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CardsLblView.Location = new System.Drawing.Point(20, 253);
            this.CardsLblView.Name = "CardsLblView";
            this.CardsLblView.Size = new System.Drawing.Size(65, 25);
            this.CardsLblView.TabIndex = 11;
            this.CardsLblView.Text = "Cards";
            this.CardsLblView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardListView
            // 
            this.CardListView.DisplayMember = "MainFields";
            this.CardListView.FormattingEnabled = true;
            this.CardListView.HorizontalScrollbar = true;
            this.CardListView.ItemHeight = 18;
            this.CardListView.Location = new System.Drawing.Point(25, 281);
            this.CardListView.Name = "CardListView";
            this.CardListView.ScrollAlwaysVisible = true;
            this.CardListView.Size = new System.Drawing.Size(298, 220);
            this.CardListView.TabIndex = 7;
            this.CardListView.SelectedIndexChanged += new System.EventHandler(this.CardListView_SelectedIndexChanged);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(233, 73);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(75, 36);
            this.ViewBtn.TabIndex = 6;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // CollectionsListView
            // 
            this.CollectionsListView.FormattingEnabled = true;
            this.CollectionsListView.HorizontalScrollbar = true;
            this.CollectionsListView.ItemHeight = 18;
            this.CollectionsListView.Location = new System.Drawing.Point(25, 73);
            this.CollectionsListView.Name = "CollectionsListView";
            this.CollectionsListView.ScrollAlwaysVisible = true;
            this.CollectionsListView.Size = new System.Drawing.Size(202, 148);
            this.CollectionsListView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Collection";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(589, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // TCGNotice
            // 
            this.TCGNotice.AutoSize = true;
            this.TCGNotice.Location = new System.Drawing.Point(13, 560);
            this.TCGNotice.Name = "TCGNotice";
            this.TCGNotice.Size = new System.Drawing.Size(531, 17);
            this.TCGNotice.TabIndex = 1;
            this.TCGNotice.Text = " (This product uses TCGplayer data but is not endorsed or certified by TCGplayer." +
    ")";
            // 
            // RemoveCollectionBtn
            // 
            this.RemoveCollectionBtn.Location = new System.Drawing.Point(270, 115);
            this.RemoveCollectionBtn.Name = "RemoveCollectionBtn";
            this.RemoveCollectionBtn.Size = new System.Drawing.Size(75, 36);
            this.RemoveCollectionBtn.TabIndex = 33;
            this.RemoveCollectionBtn.Text = "Delete";
            this.RemoveCollectionBtn.UseVisualStyleBackColor = true;
            this.RemoveCollectionBtn.Click += new System.EventHandler(this.RemoveCollectionBtn_Click);
            // 
            // NewCollectionNoResultsLbl
            // 
            this.NewCollectionNoResultsLbl.AutoSize = true;
            this.NewCollectionNoResultsLbl.ForeColor = System.Drawing.Color.Red;
            this.NewCollectionNoResultsLbl.Location = new System.Drawing.Point(307, 150);
            this.NewCollectionNoResultsLbl.Name = "NewCollectionNoResultsLbl";
            this.NewCollectionNoResultsLbl.Size = new System.Drawing.Size(132, 20);
            this.NewCollectionNoResultsLbl.TabIndex = 33;
            this.NewCollectionNoResultsLbl.Text = "No results found";
            this.NewCollectionNoResultsLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 581);
            this.Controls.Add(this.TCGNotice);
            this.Controls.Add(this.MainTab);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Yugioh Price Monitoring";
            this.MainTab.ResumeLayout(false);
            this.TabControlMain.ResumeLayout(false);
            this.TabControlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcgLogo)).EndInit();
            this.EditCollectionTab.ResumeLayout(false);
            this.EditCollectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditCardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ViewCollectionTab.ResumeLayout(false);
            this.ViewCollectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCardView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage TabControlMain;
        private System.Windows.Forms.TabPage EditCollectionTab;
        private System.Windows.Forms.PictureBox TcgLogo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label EditCollectionLbl;
        private System.Windows.Forms.TabPage ViewCollectionTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox CollectionNameTextbox;
        private System.Windows.Forms.Label CollectionNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label CardSearchLabel;
        private System.Windows.Forms.Label SearchResultsLabel;
        private System.Windows.Forms.ListBox SearchResultBox;
        private System.Windows.Forms.PictureBox CardImage;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.Label CardListLabelNew;
        private System.Windows.Forms.ListBox CardListBoxNew;
        private System.Windows.Forms.Button RemoveButtonNew;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox ConditionBox;
        private System.Windows.Forms.Label ErrorLabelAddCard;
        private System.Windows.Forms.ComboBox EditionBox;
        private System.Windows.Forms.Label ErrorLabelCreateCollection;
        private System.Windows.Forms.ListBox CollectionsListView;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label CollectionsLblView;
        private System.Windows.Forms.Label CardsLblView;
        private System.Windows.Forms.ListBox CardListView;
        private System.Windows.Forms.Label CollectionLowestLblValue;
        private System.Windows.Forms.Label CollectionMarketLblValue;
        private System.Windows.Forms.PictureBox SelectedCardView;
        private System.Windows.Forms.Label CollectionLowLbl;
        private System.Windows.Forms.Label CollectionMarketLbl;
        private System.Windows.Forms.Label LoadingLbl;
        private System.Windows.Forms.Label CardLowestLblValue;
        private System.Windows.Forms.Label CardMarketLblValue;
        private System.Windows.Forms.Label CardLowestLbl;
        private System.Windows.Forms.Label CardMarketLbl;
        private System.Windows.Forms.Label TCGNotice;
        private System.Windows.Forms.LinkLabel ListingsLink;
        private System.Windows.Forms.Button EditViewCollectionBtn;
        private System.Windows.Forms.Label EditCardLbl;
        private System.Windows.Forms.Label EditCollectionsLbl;
        private System.Windows.Forms.ListBox EditCardsListBox;
        private System.Windows.Forms.ListBox EditCollectionsListBox;
        private System.Windows.Forms.Label EditCardSearchLbl;
        private System.Windows.Forms.Button EditSearchBtn;
        private System.Windows.Forms.Button EditAdd;
        private System.Windows.Forms.Button EditRemoveButton;
        private System.Windows.Forms.ComboBox EditEditionBox;
        private System.Windows.Forms.ComboBox EditConditionBox;
        private System.Windows.Forms.ListBox EditResultsBox;
        private System.Windows.Forms.TextBox EditSearchText;
        private System.Windows.Forms.PictureBox EditCardImage;
        private System.Windows.Forms.Label EditEditionError;
        private System.Windows.Forms.Label EditConditionError;
        private System.Windows.Forms.Label EditSearchError;
        private System.Windows.Forms.Label EditNullCollectionError;
        private System.Windows.Forms.Button RemoveCollectionBtn;
        private System.Windows.Forms.Label NewCollectionNoResultsLbl;
    }
}

