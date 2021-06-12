using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OW.IntelliVending.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace OW.IntelliVending.DataReader
{
    public class JsonRepository : IGenericRepository<VTransaction>
    {
        public IEnumerable<VTransaction> GetAll()
        {
            string jsonFile;
            using (var reader = new StreamReader(@"C:\Training\Builxact\megacorp.json"))
            {
                jsonFile = reader.ReadToEnd();
            }

            JObject obj = JObject.Parse(jsonFile);

            var jsonArray = JArray.Parse(obj["partners"].ToString());
            List<VTransaction> items = new List<VTransaction>();

            foreach (var jToken in jsonArray)
            {
                var partner = JsonConvert.DeserializeObject<Partner>(jToken.ToString());
                items.AddRange(partner.supplies);
            }

            return items;
        }
    }

   
}
