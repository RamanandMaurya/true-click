using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using webcode.Models;

namespace webcode.Repository
{
    public class ApiUtility
    {

        public ApiUtility()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        string BaseApiUrl = ConfigurationManager.AppSetting["ApiUrl"].ToString();
        #region all pubic method
        public HttpResponseMessage PostApi(string Url, string JsonInput)
        {
            string token = string.Empty;
            

            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
                HttpContent inputContent = new StringContent(JsonInput, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(BaseApiUrl + Url, inputContent).Result;
                ResponseModel oResponseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content.ReadAsStringAsync().Result);
                return response;
            }
        }

        

        public async Task<HttpResponseMessage> PostApiAsync(string Url, string JsonInput)
        {
            string token = string.Empty;


            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpContent inputContent = new StringContent(JsonInput, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await Task.Run(() => client.PostAsync(Url, inputContent).Result);
                ResponseModel oResponseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content.ReadAsStringAsync().Result);
                return response;
            }
        }


        public HttpResponseMessage GetApi(string Url)
        {
            string token = string.Empty;
            
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                HttpResponseMessage response = client.GetAsync(BaseApiUrl + Url).Result;
                return response;
            }
        }

        public ResponseModel httpResponseToModel(HttpResponseMessage response)
        {
            ResponseModel oResponseModel = JsonConvert.DeserializeObject<ResponseModel>(response.Content.ReadAsStringAsync().Result);
            return oResponseModel;
        }

        public string badRequestError(HttpResponseMessage response)
        {
            StringBuilder sb = new StringBuilder();
            Root oRoot = JsonConvert.DeserializeObject<Root>(response.Content.ReadAsStringAsync().Result);
            Data oData = oRoot.data;
            foreach (var error in oData.errors)
            {
                sb.Append("*" + error + "<br />");
            }
            return sb.ToString();
        }

        public double DhanWalletBallance()
        {
            string url = "Ballance/DhanuWalletBallance";
            HttpResponseMessage httpresponse = GetApi(url);
            ResponseModel response = httpResponseToModel(httpresponse);
            if (httpresponse.StatusCode.ToString().ToLower() == "ok")
            {
                string json = JsonConvert.SerializeObject(response.Data);
                JObject obj = JsonConvert.DeserializeObject<JObject>(json);
                return Convert.ToDouble(obj["ballance"]);
            }
            else
            {
                return 0;
            }
        }

        public double CryptoWalletBallance()
        {
            string url = "Ballance/CryptoWalletBallance";
            HttpResponseMessage httpresponse = GetApi(url);
            ResponseModel response = httpResponseToModel(httpresponse);
            if (httpresponse.StatusCode.ToString().ToLower() == "ok")
            {
                string json = JsonConvert.SerializeObject(response.Data);
                JObject obj = JsonConvert.DeserializeObject<JObject>(json);
                return Convert.ToDouble(obj["ballance"]);
            }
            else
            {
                return 0;
            }
        }
        #endregion

        public class Data
        {
            public List<string> errors { get; set; }
        }
        public class Root
        {
            public string statusCode { get; set; }
            public string message { get; set; }
            public Data data { get; set; }
        }
    }
}
