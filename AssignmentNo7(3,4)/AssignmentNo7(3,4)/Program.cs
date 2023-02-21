using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace OOPsCsharpAssignment3
{
    class Program
    {
        public static void SerializeObject(object o)
        {
            FileStream fs = new FileStream(@"C:\Users\SDABEKAR\source\repos\OOPsCsharpAssignment3\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }
        public static void DeserializeObejct()
        {
            FileStream fs = new FileStream(@"C:\Users\SDABEKAR\source\repos\OOPsCsharpAssignment3\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager(11, "Kamaksha", 6000);
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"Deserialize Manager\n { m1}");
            fs.Close();
        }
        static void Main(string[] args)
        {
            Manager m = new Manager(79, "Suji", 70000);

            m.Display();
            Console.Write("GrossSalary is ");
            m.GrossSal();
            MarketingExecutive me = new MarketingExecutive(68, "ee", 1000);
            me.Display();
            SerializeObject(m);
            DeserializeObejct();
            me.GrossSal();
        }
    }
}

