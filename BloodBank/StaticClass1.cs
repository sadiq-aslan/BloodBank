using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public static class StaticClass1
    {
        public static List<string> listt = File.ReadAllLines(@"Persondata.txt").ToList();
        public static List<string> list = new List<string>();

        public static void txt(string data)
        {
            FileStream fs = new FileStream("Persondata.txt", FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            sw.Close();
            fs.Close();
      

        }
        public static List<string> list1= new List<string>();
        public static void read()
        {
     list1 = File.ReadAllLines("Persondata.txt").ToList();
           





        }
    }
}
