using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample.Controller
{
    public class Response : IController.IResponse
    {
        private string apiURL { get; set; }

        public Response(string value)
        {
            this.apiURL = value;
        }

        public List<T> ParseJSON<T>()
        {
            var myObj = typeof(T);
            var result = new List<T>();
            using (var client = new WebClient())
            {
                var data = client.DownloadString(this.apiURL);
                IList<PropertyInfo> properties = new List<PropertyInfo>(myObj.GetProperties());
                JArray jArray = JArray.Parse(data);
                foreach (var j in jArray)
                {
                    dynamic x = JObject.Parse(j.ToString());
                    var y = (T)Activator.CreateInstance(typeof(T));
                    foreach (PropertyInfo item in properties)
                    {
                        item.SetValue(y, x[item.Name], null);
                    }
                    result.Add(y);
                }

            }
            return result;
        }

        public async Task<List<T>> ParseJSONAsync<T>()
        {
            var myObj = typeof(T);
            var result = new List<T>();
            using (var client = new WebClient())
            {
                var data =await client.DownloadStringTaskAsync(this.apiURL);
                IList<PropertyInfo> properties = new List<PropertyInfo>(myObj.GetProperties());
                JArray jArray = JArray.Parse(data);
                foreach (var j in jArray)
                {
                    dynamic x = JObject.Parse(j.ToString());
                    var y = (T)Activator.CreateInstance(typeof(T));
                    foreach (PropertyInfo item in properties)
                    {
                        item.SetValue(y, x[item.Name], null);
                    }
                    result.Add(y);
                }

            }
            return result;
        }
    }
}
