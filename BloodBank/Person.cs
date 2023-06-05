using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    internal  class Person
    {
        public string id;
        public string name;
        public string surname;
        public string social_id;
        public string Phonenumber;
        public string email;
        public string bloodtype;
        public string date;

        public Person() {
            setid();
        }
        void setid() {
            Random rd = new Random();
            int fakeid=rd.Next(10000,99999);
            int[] a= { };
            int index = 0;
            if (a.Length != 0)
            {
                foreach (int item in a)
                {
                    if (fakeid == item)
                    {                      
                        setid();
                    }

                    if (index + 1 == a.Length) { id = fakeid.ToString(); a.Append(fakeid); }
                    index++;
                }
            }
            else
            {
                id = fakeid.ToString();
                a.Append(fakeid);
            }



        }




    }
}
