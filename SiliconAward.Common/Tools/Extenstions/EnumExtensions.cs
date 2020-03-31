using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SiliconAward.Common.Tools.Extenstions
{
    public static class EnumExtensions
    {

        /// <summary>
        /// new EnumName() || EnumName.Item
        /// </summary>
        /// <param name="enum"></param>
        /// <returns></returns>
        public static List<int> GetList(Enum @enum)
        {
            Array arr = Enum.GetValues(@enum.GetType());
            return ((int[])arr).ToList();
        }


        /// <summary>
        /// EnumName.Item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDescription<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }
}
