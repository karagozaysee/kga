using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                var startposition = Console.ReadLine().Trim().Split(' ').ToList();
                var moveval = Console.ReadLine().Trim().ToList();
                int x = Convert.ToInt32(startposition[0]);
                int y = Convert.ToInt32(startposition[1]);
                DirectionEnums position = (DirectionEnums)Enum.Parse(typeof(DirectionEnums), startposition[2]);
                List<int> sonuc = new List<int>();
                sonuc.Add(x);
                sonuc.Add(y);

                foreach (var item in moveval)
                {

                    if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.L)
                    {
                        position = Calculation.Turn(position, TypeEnum.Positive);
                    }
                    else if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.M)
                    {
                        sonuc = Calculation.Move(position, sonuc[0], sonuc[1]);
                    }
                    else if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.R)
                    {
                        position = Calculation.Turn(position, TypeEnum.Negative);
                    }
           
                }
                Console.WriteLine("x:{0} ,y:{1},pos:{2}", sonuc[0], sonuc[1], position);
                Console.Read();
            }
            catch
            {
                Console.WriteLine("Tanımsız bir giriş yapıldı lütfen kontrol ediniz.");
                Console.Read();
            }
        
        }


    }
}
