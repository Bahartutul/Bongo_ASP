using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problem2
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
                person person_a = new person("User", "1", "none");
                person person_b = new person("User", "2", person_a);
                //keyValue k5 = new keyValue("key5", 4, person_b);
                //keyValue k4 = new keyValue("key4",k5);
                //keyValue k3 = new keyValue("key3", 1, k4);
                //keyValue k2 = new keyValue("key2", k3);
                //keyValue k1 = new keyValue("key1",1,k2);
                //JObject j1 = JObject.Parse(JsonConvert.SerializeObject(k1));
                //Console.WriteLine(json);
               
               
                int count = 1;
                JObject j1 = JObject.Parse(File.ReadAllText("../../value.json"));

                JObject json =JObject.Parse( JsonConvert.SerializeObject(person_b));




                if (j1 != null)
                {
                    print_Json(j1, count);
                }
                if (json != null)
                {
                    print_Json(json, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
       public class person
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public object father { get; set; }
            public person(string first_name,string last_name,object father)
            {
                this.first_name = first_name;
                this.last_name = last_name;
                this.father = father;
            }
        }
       //public class keyValue
       //{
       //    public string key { get; set; }
       //    public int value { get; set; }
       //    public object user { get; set; }
       //    public keyValue(string key, int value, object user)
       //    {
       //        this.key = key;
       //        this.value = value;
       //        this.user = user;

       //    }
       //    public keyValue(string key, object user)
       //    {
       //        this.key = key;
               
       //        this.user = user;
       //    }

       //}
    }
}


/*I am trying a lot ,but i can't add two jsonObject like question */