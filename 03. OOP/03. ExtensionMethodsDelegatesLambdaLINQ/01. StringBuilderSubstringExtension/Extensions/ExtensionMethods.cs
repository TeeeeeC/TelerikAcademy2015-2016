namespace _01.StringBuilderSubstringExtension.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            var result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }

        public static T Sum<T>(this IEnumerable<T> collection) where T: struct
        {
            T result = default(T);
            foreach (var number in collection)
            {
                result += (dynamic)number;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = (dynamic)(1);
            foreach (var number in collection)
            {
                result *= (dynamic)number;
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : struct
        {
            T result = default(T);
            int counter = 0;
            foreach (var number in collection)
            {
                result += (dynamic)number;
                counter++;
            }

            return result / (dynamic)counter;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : struct
        {
            T i = default(T);
            Type type = i.GetType();
            object maxValue = type.InvokeMember("MaxValue", BindingFlags.GetField, null, i, null);
            T result = (T)maxValue;

            foreach (var number in collection)
            {
                if (number < (dynamic)result)
                {
                    result = number;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : struct
        {
            T i = default(T);
            Type type = i.GetType();
            object maxValue = type.InvokeMember("MinValue", BindingFlags.GetField, null, i, null);
            T result = (T)maxValue;

            foreach (var number in collection)
            {
                if (number > (dynamic)result)
                {
                    result = number;
                }
            }

            return result;
        }
    }
}
