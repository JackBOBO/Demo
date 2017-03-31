using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }


        public static int GetOverlappingCount(Interval[] arr)
        {
            int max = 0, count = 1;

            if (arr == null || arr.Length == 0)
                return max;

            Point[] points = new Point[arr.Length * 2];
            for (int i = 0; i < arr.Length; i++)
            {
                points[2 * i] = new Point(arr[i].Start, 0);
                points[2 * i + 1] = new Point(arr[i].End, 1);
            }

            points = points.OrderBy(n => n.value).ToArray();

            for (int i = 0; i < points.Length; i++)
            {

                if (points[i].type == 0)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                    count--;

            }

            return max;
        }
    }

    public class Point : Comparer<Point>
    {
       public int value;
        public int type;
        public Point(int v, int t)
        {
            this.value = v;
            this.type = t;
        }

        public override int Compare(Point x, Point y)
        {
            if (x.value == y.value)
                return 0;
            else if (x.value > y.value)
                return 1;
            else
                return -1;
        }
    }
}
