using AssignmentNo7_3_4_;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace OOPsCsharpAssignment3
{
    class Program
    {
        public static void SerializeObject(object o)
        {
            FileStream fs = new FileStream(@"C:\Users\ANNEVASE\source\repos\OopsCSharpAssignment 3.2", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }
        public static void DeserializeObejct()
        {
            FileStream fs = new FileStream(@"C:\Users\ANNEVASE\source\repos\OopsCSharpAssignment 3.2", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager(11, "Kamaksha", 6000);
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"Deserialize Manager\n { m1}");
            fs.Close();
        }
        static void Main(string[] args)
        {
            Manager m = new Manager(79, "Suji", 70000);

            object p = m.Display();
            Console.Write("GrossSalary is ");
            m.GrossSal();
            MarketingExecutive me = new MarketingExecutive(68, "ee", 1000);
            me.Display();
            SerializeObject(m);
            DeserializeObejct();
            object p1 = me.GrossSal();
        }
    }
}

namespace AssignmentNo7_3_4_
{
    class Manager
    {
        private int v1;
        private string v2;
        private int v3;

        public Manager(int v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal object Display()
        {
            throw new NotImplementedException();
        }

        internal void GrossSal()
        {
            throw new NotImplementedException();
        }
    }

    class MarketingExecutive
    {
        private int v1;
        private string v2;
        private int v3;

        public MarketingExecutive(int v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }

        internal object GrossSal()
        {
            throw new NotImplementedException();
        }
    }
}