using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2DLib
{
    public class Vector2D
    {
        public Point2D StartPoint { get; set; }
        public Point2D EndPoint { get; set; }

        public Vector2D()
        {
        }

        public Vector2D(Point2D startPoint, Point2D endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
        //Конструирование вектора по начальной точке и его координатам
        public Vector2D(Point2D startPoint, double x, double y)
        {
            StartPoint = startPoint;
            EndPoint = new Point2D(startPoint.X + x, startPoint.Y + y);
        }

        //Конструирование из последовательности координат
        public Vector2D(double x1, double y1, double x2, double y2)
        {
            StartPoint = new Point2D(x1, y1);
            EndPoint = new Point2D(x2, y2);
        }

        //Вычисляемые свойства: проекция на горизонталь
        public double X
        {
            get
            {
                return EndPoint.X - StartPoint.X;
            }
        }
        //Вычисляемые свойства: проекция на вертикаль
        public double Y
        {
            get
            {
                return EndPoint.Y - StartPoint.Y;
            }
        }

        //Вычисляемые свойства: длина вектора
        public double Length
        {
            get
            {
                return StartPoint.Distance(EndPoint);
            }
        }

        //Вычисляемые свойства: угол относительно OX
        public double AngleX
        {
            get
            {
                return Math.Atan2(Y, X);
            }
        }

        //Вычисляемые свойства: угол относительно OY
        public double AngleY
        {
            get
            {
                return Math.Atan2(X, Y);
            }
        }

        public override string ToString()
        {
            return string.Format("[({0}, {1}) L: {2} AX: {3}, AY: {4}]", X, Y, Length, AngleX, AngleY);
        }

        public override bool Equals(object obj)
        {
            if (typeof(Vector2D) != obj.GetType())
            {
                return false;
            }
            Vector2D other = (Vector2D)obj;
            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            unchecked
            {
                hash = 23 * hash + StartPoint.GetHashCode();
                hash = 23 * hash + EndPoint.GetHashCode();
            }
            return hash;
        }
        /*
         * Операции над векторами
         */
        public static Vector2D operator + (Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.StartPoint, v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.StartPoint, v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2D operator *(Vector2D v, double k)
        {
            return new Vector2D(v.StartPoint, v.X * k, v.Y * k);
        }

        public static Vector2D operator *(double k, Vector2D v)
        {
            return v*k;
        }

        public static double operator *(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static double GetAngleVectors(Vector2D v1, Vector2D v2)
        {
            return Math.Acos(v1 * v2 / v1.Length / v2.Length);
        }
    }
}
