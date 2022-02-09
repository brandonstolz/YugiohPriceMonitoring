using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace YugiohPriceMonitoring.Classes
{
    class APICalls
    {
        //Below constants are used to construct API calls for retrieving product info
        private const string SORT = "{\n\t\"sort\": \"MinPrice DESC\",\n\t";
        private const string LIMIT = "\"limit\": 500,\n\t";
        private const string OFFSET = "\"offset\": 0,\n\t";
        private const string FILTERSB = "\"filters\": [\n\t\t{\n\t\t\t\"name\": \"ProductName\",\n\t\t\t\"values\": [\"";
        private const string FILTERSE = "\"]\n\t\t}\n\t]\n}";
        private const string BASEURI = "https://api.tcgplayer.com/v1.37.0/";
        public static string token = null;
        
        /// <summary>
        /// Provides an HttpClient to be used to make an Http request
        /// Token must be updated every so often
        /// </summary>
        /// <returns></returns>
        private static HttpClient getProductQueryClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "YuGiOh Price Monitoring");
            httpClient.DefaultRequestHeaders.Add("Authorization", token);

            return httpClient;
        }

        /// <summary>
        /// Queries the API making a POST request.
        /// Then returns a list of the retrieved ids.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async static Task<List<string>> queryProductIds(string productId)
        {
            List<string> productIds = new List<string>();

            //Building the payload for the POST request
            StringBuilder payload = new StringBuilder();
            payload.Append(SORT + LIMIT + OFFSET
                + FILTERSB + productId + FILTERSE);

            //Creates the client and makes the POST request
            var httpClient = getProductQueryClient();
            var responseContent = await httpClient.PostAsync("https://api.tcgplayer.com/v1.37.0/catalog/categories/2/search", new StringContent(payload.ToString(), Encoding.UTF8, "application/json"));

            //Grabs the response content
            var stringResponse = await responseContent.Content.ReadAsStringAsync();
            JObject jsonResponse = JObject.Parse(stringResponse);

            //Creates the tokens out of the results
            List<JToken> jsonProductIds = jsonResponse["results"].ToList();

            // Iterates through each token grabbing the product id
            foreach (JToken token in jsonProductIds)
            {
                productIds.Add(token.ToString());
            }

            return productIds;
        }

        /// <summary>
        /// Takes a list of product ids and then returns a list of CardObjects based on retrieved info
        /// </summary>
        /// <param name="productIds"></param>
        /// <returns></returns>
        public async static Task<List<Card>> queryByProductId(List<string> productIds)
        {
            //Creating client and building request
            HttpClient httpClient = getProductQueryClient();
            StringBuilder requestURI = new StringBuilder("https://api.tcgplayer.com/v1.37.0/catalog/products/");

            foreach (string productId in productIds)
            {
                requestURI.Append(productId + ",");
            }

            //Gets rid of trailing comma
            requestURI.Remove(requestURI.Length - 1, 1);
            requestURI.Append("?getExtendedFields=true");

            //Request response
            var response = httpClient.GetAsync(requestURI.ToString());
            string result = await response.Result.Content.ReadAsStringAsync();

            //Creates list of cards that come from returned JSON result
            List<Card> list = Card.parseCards(result);
            return list;
        }

        /// <summary>
        /// Queries for SKU based on productId, condition, and edition
        /// </summary>
        /// <param name="productId"> The product Id </param>
        /// <param name="condition">The condition id</param>
        /// <param name="printing"> The edition id </param>
        /// <returns></returns>
        public async static Task<string> queryProductSku(string productId, string condition, string printing)
        {
            string conditionId = "";
            string printingId = "";
            string productSku = "NOSKU";

            //Setting the conditonId and the printingId
            switch (condition)
            {
                case "Near Mint":
                    conditionId = "1";
                    break;
                case "Lightly Played":
                    conditionId = "2";
                    break;
                case "Moderately Played":
                    conditionId = "3";
                    break;
                case "Heavily Played":
                    conditionId = "4";
                    break;
                case "Damaged":
                    conditionId = "5";
                    break;
            }

            switch (printing)
            {
                case "1st Edition":
                    printingId = "8";
                    break;
                case "Unlimited":
                    printingId = "7";
                    break;
                case "Limited":
                    printingId = "23";
                    break;
            }

            //Building the request
            HttpClient httpClient = getProductQueryClient();
            StringBuilder requestURI = new StringBuilder(BASEURI + "catalog/products/" + productId + "/skus");

            //Request response
            var response = httpClient.GetAsync(requestURI.ToString());
            string stringResponse = await response.Result.Content.ReadAsStringAsync();

            // Parsing response and creating JTokens
            JObject jsonResponse = JObject.Parse(stringResponse);
            List<JToken> tokens = jsonResponse["results"].ToList();

            foreach (JToken token in tokens)
            {
                if (token["printingId"].ToString() == printingId && token["conditionId"].ToString() == conditionId)
                {
                    productSku = token["skuId"].ToString();
                    Console.WriteLine("Product SKU: " + productSku);
                    break;
                }
            }

            return productSku;
        }

        public static async void queryPrices(List<Card> collection)
        {
            HttpClient httpClient = getProductQueryClient();
            StringBuilder requestURI = new StringBuilder(BASEURI + "pricing/sku/");

            foreach (Card card in collection)
            {
                requestURI.Append(card.getProductSku() + ",");
            }

            //Gets rid of trailing comma
            requestURI.Remove(requestURI.Length - 1, 1);

            //Request response
            var response = httpClient.GetAsync(requestURI.ToString());
            string result = await response.Result.Content.ReadAsStringAsync();

            JObject jsonResponse = JObject.Parse(result);
            List<JToken> priceResults = jsonResponse["results"].ToList();

            int i = 0;
            foreach (JToken token in priceResults)
            {
                collection[i].setMarketPrice(token["marketPrice"].ToString());
                collection[i].setLowPrice(token["lowPrice"].ToString());
                i++;
            }
        }

        public async static void generateToken()
        {
            try
            {
                HttpClient client = new HttpClient();
                
                client.DefaultRequestHeaders.Add("User-Agent", "YuGiOh Price Monitoring");
                var httpRequest = await client.PostAsync("https://api.tcgplayer.com/token", new StringContent("grant_type=client_credentials&client_id=da4bb2f0-2bc1-453c-8e3d-36998d5f92e7&client_secret=7357460b-4760-4b5b-870b-305731516953", Encoding.UTF8, "text/plain"));

                var tokenResponse = httpRequest.Content.ReadAsStringAsync();
                
                Regex regex = new Regex("\",\"token_type\"");
                int endIndex = tokenResponse.Result.IndexOf("\",\"token_type\"");
                int tokenLength = endIndex - 17; 

                token = "bearer " + tokenResponse.Result.Substring(17,tokenLength);
            }
            catch (Exception e)
            {
                string message = e.Message;
            }
        }
    }
}
