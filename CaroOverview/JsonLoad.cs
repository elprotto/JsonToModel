using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroOverview
{
    public class JsonLoad
    {
        private string _jsonData;
        public JsonLoad()
        {
            using (StreamReader r = new StreamReader("D:\\ASB\\Data2.json"))
            {
                string json = r.ReadToEnd();
                _jsonData = json;
            }

        }

        public string GetJsonData()
        { 
            return _jsonData;
        }
    }
}
