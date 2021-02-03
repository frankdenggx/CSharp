using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Org.Hotel1802
{
    /// <summary>
    /// 包含所有扩展的方法
    /// </summary>
    public static class MethodExtend
    {
        public static string revert(this System.String target)
        {
            if (target == null || target.Length == 1)
            {
                return target;
            }
            char[] chars = target.ToCharArray();
            char c;
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == chars.Length/2 || i == (chars.Length /2 + 1))
                {
                    return new string(chars);
                }
                c = chars[i];
                chars[i] = chars[chars.Length - 1 - i];
                chars[chars.Length - 1 - i] = c;
            }
            return new string(chars);
        }

        /// <summary>
        /// 获取枚举Description
        /// </summary>
        /// <param name="target">枚举参数</param>
        /// <returns>枚举的Description属性</returns>
        public static string fetchEnumDescription(this System.Enum target)
        {
            FieldInfo fieldInfo = target.GetType().GetField(target.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : target.ToString();
        }

    }
}
