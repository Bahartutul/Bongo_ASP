using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        public static void print_Json(JObject j1, int count)
        {

            foreach (var pair in j1)
            {
                if (!pair.Value.HasValues)
                {
                    Console.WriteLine("{0} {1}", pair.Key, count);
                }
                else
                {
                    Console.WriteLine("{0} {1}", pair.Key, count);
                    JObject j2 = JObject.Parse(pair.Value.ToString());
                    print_Json(j2, count + 1);
                }
                //Console.WriteLine("{0}", item);
            }

        }
        static void Main(string[] args)
        {
            try
            {
                int count = 1;
                JObject j1 = JObject.Parse(File.ReadAllText("../../value.json"));
                if (j1 != null)
                {
                    print_Json(j1, count);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
