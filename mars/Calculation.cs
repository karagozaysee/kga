using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    public static class Calculation
    {
        public static DirectionEnums Turn(DirectionEnums pos, TypeEnum type)
        {
          
            if (type == TypeEnum.Positive)
            {
                switch (pos)
                {
                    case DirectionEnums.N:
                        return DirectionEnums.W;

                    case DirectionEnums.W:
                        return DirectionEnums.S;

                    case DirectionEnums.S:
                        return DirectionEnums.E;

                    case DirectionEnums.E:
                        return DirectionEnums.N;

                    default:
                        return DirectionEnums.N;

                }
            }
            else if (type == TypeEnum.Negative)

            {
                switch (pos)
                {
                    case DirectionEnums.N:
                        return DirectionEnums.E;


                   case DirectionEnums.E:
                        return DirectionEnums.S;

                    case DirectionEnums.S:
                        return DirectionEnums.W;

                    case DirectionEnums.W:
                        return DirectionEnums.N;


                    default:
                        return DirectionEnums.N;
                }
            }
            else
            {                
                        return DirectionEnums.N;
            }

        }

        public static List<int> Move(DirectionEnums pos, int x, int y)
        {
            if (pos ==DirectionEnums.N)
            {

                y +=1;
            }
            else if (pos == DirectionEnums.E)
            {
                x +=1;
            }
            else if (pos == DirectionEnums.W)
            {
                x -=1;
            }
            else if (pos == DirectionEnums.S)
            {
                y -=1;
            }
            var list = new List<int>();
            list.Add(x);
            list.Add(y);
            return list;
        }

    }
}

