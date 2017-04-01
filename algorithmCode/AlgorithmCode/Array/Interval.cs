using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Array
{
    /// <summary>
    /// 区间
    /// </summary>
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public static bool operator ==(Interval x, Interval y)
        {
            if (x.Equals(y))
                return true;

            if (x.Equals(null) || y.Equals(null))
            {
                return x.Equals(y);
            }

            return (x.Start == y.Start && x.End == y.End);
        }

        public static bool operator !=(Interval x, Interval y)
        {
            if (x.Equals(y))
                return false;

            if (x.Equals(null) || y.Equals(null))
            {
                return !x.Equals(y);
            }

            return !(x.Start == y.Start && x.End == y.End);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 重叠区间个数
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 为有序、无重叠区间插入新区间，并保持无重叠
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        public static IList<Interval> Insert(Interval[] intervals, Interval newInterval)
        {
            IList<Interval> res = new List<Interval>();

            if (intervals == null || intervals.Length == 0)
            {
                res.Add(newInterval);
                return res;
            }

            int i = 0, n = intervals.Length;
            while (i < n && newInterval.Start > intervals[i].End)
                res.Add(intervals[i++]);

            while (i < n && newInterval.End >= intervals[i].Start)
            {
                newInterval.End = Math.Max(newInterval.End, intervals[i].End);
                newInterval.Start = Math.Min(newInterval.Start, intervals[i].Start);
                i++;
            }

            res.Add(newInterval);

            while (i < n)
                res.Add(intervals[i++]);

            return res;
        }

        public static IList<Interval> Merge(Interval[] arr)
        {
            IList<Interval> res = new List<Interval>();
            if (arr == null || arr.Length == 0)
                return res;

            arr = arr.OrderBy(item => item.Start).ThenBy(item => item.End).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Interval current = arr[i];
                if (res.Count == 0)
                {
                    res.Add(current);
                }
                else
                {
                    Interval last = res[res.Count - 1];
                    if (last.End >= current.Start)
                        last.End = Math.Max(last.End, current.End);
                    else
                        res.Add(current);
                }
            }

            return res;
        }

        public override string ToString()
        {
            return string.Format("start:{0},end:{1}", this.Start, this.End);
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
