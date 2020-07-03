using CaroOverview.Model;
using Nancy.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaroOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi my Nigger");

            try
            {
                // code
                JsonLoad datFromFile = new JsonLoad();
                string jsonDataInMemory = datFromFile.GetJsonData();
                JavaScriptSerializer ser = new JavaScriptSerializer();

                var JsonLoadList = ser.Deserialize<List<JsonData>>(jsonDataInMemory);
                Console.WriteLine($"General groups of data: {JsonLoadList.Count}");

                foreach (var item in JsonLoadList)
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine($"Internal Count is: {item.Count}");

                    Console.WriteLine($"Record number: {item.Records.Count}");

                    foreach (var rmledgObject in item.Records)
                    {
                        if (string.IsNullOrEmpty(rmledgObject.TRANAMT) && string.IsNullOrWhiteSpace(rmledgObject.TRANAMT))
                        {
                            Console.WriteLine($"TRANAMT will be saved as null");
                        }
                        else
                        {
                            Console.WriteLine($"TRANAMT column value: {rmledgObject.TRANAMT}");
                        }
                        
                    }

                    Console.WriteLine("--------------------------------------------");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
