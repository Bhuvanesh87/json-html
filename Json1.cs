using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Json
{
    class Person
    {
        public  int age { set; get; }
        public  string name { set; get; }
        public override string ToString()
        {
            return string.Format("Name is {0}  \nAge :{1}" , name ,age);
        }
    }
    class Json1
    {
        static void Main(string[] args)
        {
            string JSONstring = File.ReadAllText(@"F:\\Bizruntime\\prac\\week3\\json\\Json\\JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);


            Person p2 = new Person() { name = "Ankur", age = 28 };
            string outJSON = ser.Serialize(p2);
            File.WriteAllText("output.json", outJSON);

            Console.Read();

         }
    }
}
