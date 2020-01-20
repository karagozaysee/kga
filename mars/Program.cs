using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var startposition = Console.ReadLine().Trim().Split(' ').ToList();
            var moveval = Console.ReadLine().Trim().ToList();
            int x = Convert.ToInt32(startposition[0]);
            int y = Convert.ToInt32(startposition[1]);
            string pos = startposition[2].ToString();


            foreach (var item in moveval)
            {
                if (item.ToString() == "L")
                {
                  pos = Left(pos);
                }
                else if (item.ToString() == "M")
                {
                    //if()
                }
                else if (item.ToString() == "R")
                {
                    pos = Right(pos);
                }
            }

            Console.WriteLine("x:{0} ,y:{1},pos:{2}", x, y, pos);
        }

        public static string Right(string pos)
        {
            if (pos == "N")
            {
                pos = "E";
            }
            else if (pos == "W")
            {
                pos = "S";
            }
            else if (pos == "S")
            {
                pos = "E";
            }
            else if (pos == "E")
            {
                pos = "N";
            }
            else
            {
                Console.WriteLine("Girilen veri standarda uygun değildir.");
            }
            return pos;
        }

        public static string Left(string pos)
        {
            if (pos == "N")
            {
                pos = "W";
            }
            else if (pos == "W")
            {
                pos = "S";
            }
            else if (pos == "S")
            {
                pos = "E";
            }
            else if (pos == "E")
            {
                pos = "N";
            }
            else
            {
                Console.WriteLine("Girilen veri standarda uygun değildir.");
            }

            return pos;
        }
    }
}
