using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {


            //Car obj = new Car();
            //obj.name  = "CIVIC";
            //obj.model = "2022";
            //obj.engineno = "xyz009346";
            //obj.numberplate = "abc-404";



            //Console.WriteLine("car Name :" +obj.name);
            //Console.WriteLine("car model :"+obj.model);
            //Console.WriteLine("car engine no :"+obj.engineno);
            //Console.WriteLine("car numberplate :"+obj.numberplate);





            Car c1 = new Car();
            c1.cardetails("mehran", "abc-1234", "123456", 1989);

            Car c2 = new Car();
            c2.cardetails("kia", "abc-1234", "123456", 2022);


            Car c3 = new Car();
            c3.cardetails("alto", "abc-1234", "123456", 2004);






            Students obj = new Students("Misbah", "ma@gmail.com");
            Students obj1 = new Students("Ammarah", "aa@gmail.com", "0589");
            Students obj2 = new Students("HHiba", "ha@gmail.com","03034456", "karachi");



            Console.ReadKey();



        }
    }
}
