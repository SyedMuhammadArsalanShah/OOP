using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation
{
  public class Car
    {
        public string name;
        public string numberplate;
        public string engineno;
        public int model;





        // return type methodname(){ statements }

        public void cardetails(string name, string numberplate, 
            string engineno, int m) {

            this.name = name;
            this.numberplate = numberplate;
            this.engineno = engineno;
            model = m;


            Console.WriteLine("car Name :" + name + ",car model :" + model +
                ",car engine no :" + engineno+ ",car numberplate :" + numberplate);
       

        }


    }
}
