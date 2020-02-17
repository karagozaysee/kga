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
                var size= Console.ReadLine().Trim().Split(' ').ToList();

                var startPosition = Console.ReadLine().Trim().Split(' ').ToList();
                var moveVal = Console.ReadLine().Trim().ToList();
                int x = Convert.ToInt32(startPosition[0]);
                int y = Convert.ToInt32(startPosition[1]);
                DirectionEnums position = (DirectionEnums)Enum.Parse(typeof(DirectionEnums), startPosition[2]);
                List<int> result = new List<int>();
                result.Add(x);
                result.Add(y);

                foreach (var item in moveVal)
                {

                    if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.L)
                    {
                        position = Calculation.Turn(position, TypeEnum.Positive);
                    }
                    else if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.M)
                    {
                        result = Calculation.Move(position, result[0], result[1]);
                    }
                    else if ((InputEnum)Enum.Parse(typeof(InputEnum), item.ToString()) == InputEnum.R)
                    {
                        position = Calculation.Turn(position, TypeEnum.Negative);
                    }
           
                }
                Console.WriteLine("x:{0} ,y:{1},pos:{2}", result[0], result[1], position);
                Console.Read();
            }
            catch(Exception ex)
            {
                //TODO : exception yazılımcıya ilet
                Console.WriteLine("Tanımsız bir giriş yapıldı lütfen kontrol ediniz.");
                Console.Read();
            }
        
        }


    }
}
