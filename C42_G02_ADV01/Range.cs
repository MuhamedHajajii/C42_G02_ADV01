using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV01
{
    public class Range<T> where T : IComparable<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public Range(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) >= 0;
        }

        public T length()
        {
            dynamic mx = MaxValue;
            dynamic mn = MinValue;
            return mx - mn;
        }

    }
}
