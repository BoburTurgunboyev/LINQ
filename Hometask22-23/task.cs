using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask22_23
{
    public class task
    {
        public static void Run()
        {
            //////////////////////////////////////////////1-misol
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var query = from num in numbers where (num%2) ==0 select num;

            //foreach( var num in query ) 
            //{
            //    Console.WriteLine(num);
            //}



            //////////////////////////////////////////////2-misol

            //int[] numbers = new int[] { 1, 2,12,3,4,5,6,0,112,-12,-5, 3, 4, 5, 6, 7, 8,11 };

            //var query = from num in numbers where num >= 0 where num <=11 select num;

            //foreach (var num in query)
            //{
            //    Console.WriteLine(num);
            //}


            ////////////////////////////////////////////////3-misol

            //int[] numbers = new int[] { 5,6,7 };
            //var query = from num in numbers let c=num*num select new {c, num};
            //foreach (var num in query)
            //{
            //    Console.WriteLine(num);
            //}

            ///////////////////////////////////////////////////////4-misol

            //int[] numbers = new int[] { 1,1, 2, 3,3,3,3,3 };

            //var query = from num in numbers
            //            group num by num into asd
            //            select asd;

            //foreach (var a in query)
            //{
            //    Console.WriteLine("son=" +a.Key + "   "+ a.Count()+" martta yozilgan");
            //}

            //////////////////////////////////////////////////////////5-misol

            //string asd =  "manchestr yunayted eng zori zamonini eng zori" ;
            //var query = from a in asd
            //            group a by a into asad
            //            select asad;

            //foreach (var b in query)
            //{
            //    Console.WriteLine(b.Key+"  harfi  "+b.Count()+"marrta ishlatilgan");
            //}

            ////////////////////////////////////////////////////////////6-misol

            //string[] asd = new string[] { "dushanba","seshanba","hapshanba","bozorkuni" };

            //var query = from a in asd
            //            select a;

            //foreach (var b in query)
            //{
            //    Console.WriteLine(b);
            //}

            //////////////////////////////////////////////////////////////////7-misol

            //int[] numbers = new int[] { 1, 2,2,2,3,3 ,4,4,4,2,2,9,9,9,9,9,9,12,12,12};

            //var query = from num in numbers
            //            group num by num into asd
            //            select asd;

            //foreach (var num in query)
            //{
            //    Console.WriteLine(num.Key+" "+num.Key*num.Count()+" "+num.Count());
            //}

            ////////////////////////////////////////////////////////////////////8-misol
            ///


            // string[] cities =
            //{
            //     "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            // };

            // string a = Console.ReadLine();
            // string b= Console.ReadLine();

            // var query = from word in cities
            //             where word.StartsWith(a) && word.EndsWith(b)  
            //             select word;

            // foreach (var num in query)
            // {
            //     Console.WriteLine(num);
            // }


            ////////////////////////////////////////////////////////////////////////9-misol


            //int[] numbers = new int[] { 10, 16, 77,13,99,87 };
            //var query = from num in numbers 
            //            where num > 50
            //            select num;
            //foreach (var num in query)
            //{
            //    Console.WriteLine(num);
            //}


            ////////////////////////////////////////////////////////////////////////10-misol

            //int[] numbers = new int[] { 10, 16, 77, 13, 99, 87 };
            //int a =Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}

            ////////////////////////////////////////////////////////////////////////////11-misol


            //List <int > numbers = new List<int>();
            //numbers.Add (0);
            //numbers.Add (12);
            //numbers.Add (2);
            //numbers.Add (32);
            //numbers.Add (4);
            //numbers.Add (15);
            //numbers.Add (62);
            //numbers.Add (17);

            //numbers.Sort ();
            //numbers.Reverse ();

            //foreach(int i in numbers)
            //{
            //    Console.WriteLine (i);
            //}

            ////////////////////////////////////////////////////////////////////////////13-misol


            //int a;
            //a = Convert.ToInt32(Console.ReadLine());
            //string[] array= new string[a];



            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("Element[{0}] : ", i);
            //    array[i] = Console.ReadLine();
            //}

            //string newstring = String.Join(", ", array.Select(s => s.ToString()));

            //Console.WriteLine(newstring);

            ////////////////////////////////////////////////////////////////////////////17-18-19-20-21-misol

            List<string> asd = new List<string>();
            asd.Add("m");
            asd.Add("n");
            asd.Add("o");
            asd.Add("p");
            asd.Add("q");



            var _result1 = from y in asd
                           select y;

            foreach (var x in _result1)
            {
                Console.WriteLine("Char: {0} ", x);
            }

            string newstr = asd.FirstOrDefault(a => a == "o");
            asd.Remove(newstr);


            var _result = from z in asd
                          select z;

            foreach (var x in _result)
            {
                Console.WriteLine("Char: {0} ", x);
            }
            


        }
    }
}
