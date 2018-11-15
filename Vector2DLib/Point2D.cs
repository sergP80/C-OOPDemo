using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2DLib
{

    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D()
        {
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        //Метод для вычисления расстояния между точками
        public double Distance(Point2D other)
        {
            double dX = this.X - other.X;
            double dY = this.Y - other.Y;
            return Math.Sqrt(dX*dX + dY*dY);
        }
        //Переопределяем строковое представление объекта "Точка на плоскости"
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
        //Переопределяем метод сравнения точек
        public override bool Equals(object obj)
        {
            if (typeof(Point2D) != obj.GetType())
            {
                return false;
            }
            Point2D other = (Point2D)obj;
            return this.X == other.X && this.Y == other.Y;
        }
        //Переопределять hash code нужно всегда, даже если не хочется :)
        public override int GetHashCode()
        {
            int hash = 17;
            unchecked
            {
                hash = 23 * hash + X.GetHashCode();
                hash = 23 * hash + Y.GetHashCode();
                return hash;
            }
        }
    }
}
