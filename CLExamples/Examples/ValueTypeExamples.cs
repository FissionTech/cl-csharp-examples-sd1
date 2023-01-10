using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLExamples.Examples
{
    public static class ValueTypeExamples
    {
        public static void IntegerReassignment() {
            Console.WriteLine($"Running {nameof(IntegerReassignment)}");

            int num1 = 0;
            int num2 = num1;

            num1 = 10;

            // These lines will write the values of num1 and num2.
            // What do you think they will be?
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        public static void CustomValueTypeMemberReassignment() {
            Console.WriteLine($"Running {nameof(CustomValueTypeMemberReassignment)}");

            Point2DStruct point1 = new Point2DStruct(0, 0);
            Point2DStruct point2 = point1;

            point1.X = 10;
            point1.Y = 10;

            Console.WriteLine(point1);
            Console.WriteLine(point2);
        }

        public static void CustomValueTypeVariableReassignment() {
            Console.WriteLine($"Running {nameof(CustomValueTypeVariableReassignment)}");

            Point2DStruct point1 = new Point2DStruct(0, 0);
            Point2DStruct point2 = point1;
            Point2DStruct point3 = point1;

            point1 = new Point2DStruct(10, 10);

        }
    }

    struct Point2DStruct : IPoint2D
    {
        public int X { get; set; }
        
        public int Y { get; set; }

        public Point2DStruct(int x, int y) {
            X = x;
            Y = y;
        }

        public bool Equals(IPoint2D? other) =>
            other is null ? false : other.X == X && other.Y == Y;
    }

    class Point2DClass : IPoint2D {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2DClass(int x, int y) {
            X = x;
            Y = y;
        }

        public bool Equals(IPoint2D? other) =>
            other is null ? false : other.X == X && other.Y == Y;
    }

    interface IPoint2D : IEquatable<IPoint2D> {
        int X { get; set; }
        int Y { get; set; }

        string? ToString() => $"({X}, {Y})";
    }
}
