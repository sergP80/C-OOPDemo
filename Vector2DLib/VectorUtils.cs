using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2DLib
{
    public class VectorException: Exception {}
    public class VectorScalarProdException: Exception {}

    public class VectorUtils
    {
        public static Vector2D SumOfVectors(params Vector2D[] vectors)
        {
            Vector2D res = vectors[0];
            for (int i = 1; i < vectors.Length; ++i)
            {
                res = res + vectors[i];
            }
            return res;
        }

        public static Vector2D SubsOfVectors(params Vector2D[] vectors)
        {
            Vector2D res = vectors[0];
            for (int i = 1; i < vectors.Length; ++i)
            {
                res = res - vectors[i];
            }
            return res;
        }

        public static object ProcessVectorOperation(VectorOperations op, params Vector2D[] vectors)
        {
            switch(op)
            {
                case VectorOperations.AddVectors:
                    return SumOfVectors(vectors);
                case VectorOperations.SubsVectors:
                    return SubsOfVectors(vectors);
                case VectorOperations.ScalarProdVectors:
                    if (vectors.Length < 2)
                    {
                        throw new VectorScalarProdException();
                    }
                    return vectors[0] * vectors[1];
                default:
                    return null;
            }
        }
    }
}
