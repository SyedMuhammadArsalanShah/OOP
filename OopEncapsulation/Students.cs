using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation
{
    class Students
    {
        string name, email, contact, address;

        public Students()
        {
        }

        public Students(string name, string email, string contact, string address)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.address = address;




            Console.WriteLine("welcome in our app "+email);
        }

        public Students(string name, string email, string contact)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;

            Console.WriteLine("welcome in our app " + email);
        }

        public Students(string name, string email)
        {
            this.name = name;
            this.email = email;

            Console.WriteLine("welcome in our app " + email);
        }






        public void ammarahsuststudent()
        {

            Console.WriteLine("true");
        }


    }
}
