using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector2DLib;

namespace VectorCalculator
{
    class VectorCalculator
    {

        static void EnterVectors(out Vector2D v1, out Vector2D v2)
        {
            Console.Write("Enter the first vector (x1 y1 x2 y2):");
            double[] data = Console.ReadLine().Split().Select(double.Parse).ToArray();
            v1 = new Vector2D(data[0], data[1], data[2], data[3]);

            Console.Write("Enter the second vector (x1 y1 x2 y2):");
            data = Console.ReadLine().Split().Select(double.Parse).ToArray();
            v2 = new Vector2D(data[0], data[1], data[2], data[3]);
            Console.WriteLine("Source vectors are:\n\t{0}\n\t{1}", v1, v2);
        }

        static VectorOperations Menu()
        {
            Console.WriteLine("Available operations");
            VectorOperations[] ops = (VectorOperations[])Enum.GetValues(typeof(VectorOperations));
            for(int i = 0; i < ops.Length; ++i)
            {
                Console.WriteLine("\t{0}[{1}]", ops[i], i + 1);
            }
            Console.Write("Choose operation: ");
            return (VectorOperations) Enum.Parse(typeof(VectorOperations), Console.ReadLine());
        }

        static int ProcessOperation(VectorOperations operation, params Vector2D[] vectors)
        {
            object result = Vector2DLib.VectorUtils.ProcessVectorOperation(operation, vectors);
            int ret = 0;
            switch (operation)
            {
                case VectorOperations.AddVectors:
                    Console.WriteLine("Sum of vectors: {0}", result);
                    break;
                case VectorOperations.SubsVectors:
                    Console.WriteLine("Subs of vectors: {0}", result);
                    break;
                case VectorOperations.ScalarProdVectors:
                    Console.WriteLine("Scalar prod of vectors: {0}", result);
                    break;
                default:
                    ret = -1;
                    break;
            }
            return ret;
        }

        static void Main(string[] args)
        {
            int ret = 0;
            while(ret == 0)
            {
                Vector2D v1, v2;
                EnterVectors(out v1, out v2);
                VectorOperations op = Menu();
                ret = ProcessOperation(op, v1, v2);
            }
        }
    }
}
