using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
namespace YB.CMS.Utility
{
    public static class EnumHelper
    {
        private static Hashtable enumDesciption = GetDescriptionContainer();

        private static void AddToEnumDescription(Type enumType)
        {
            enumDesciption.Add(enumType, GetEnumDic(enumType));
        }

        private static string GetDescription(Type enumType, string enumText)
        {
            if (string.IsNullOrEmpty(enumText))
            {
                return null;
            }
            if (!enumDesciption.ContainsKey(enumType))
            {
                AddToEnumDescription(enumType);
            }
            var obj2 = enumDesciption[enumType];
            if ((obj2 == null) || string.IsNullOrEmpty(enumText))
            {
                throw new ApplicationException("不存在枚举的描述");
            }
            var dictionary = (Dictionary<string, string>)obj2;
            return dictionary[enumText];
        }

        private static Hashtable GetDescriptionContainer()
        {
            enumDesciption = new Hashtable();
            return enumDesciption;
        }

        private static Dictionary<string, string> GetEnumDic(Type enumType)
        {
            var dictionary = new Dictionary<string, string>();
            var fields = enumType.GetFields();
            foreach (var info in fields)
            {
                if (info.FieldType.IsEnum)
                {
                    var customAttributes = info.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    dictionary.Add(info.Name, ((DescriptionAttribute)customAttributes[0]).Description);
                }
            }
            return dictionary;
        }

        private static bool IsIntType(double d)
        {
            return (((int)d) != d);
        }

        public static string ToDescription(this Enum value)
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);
            return GetDescription(enumType, name);
        }

        public static Dictionary<int, string> ToDescriptionDictionary<TEnum>()
        {
            var enumType = typeof(TEnum);
            var values = Enum.GetValues(enumType);
            return values.Cast<Enum>().ToDictionary(Convert.ToInt32, enum2 => enum2.ToDescription());
        }

        public static Dictionary<int, string> ToDictionary<TEnum>()
        {
            var enumType = typeof(TEnum);
            var values = Enum.GetValues(enumType);
            return values.Cast<Enum>().ToDictionary(Convert.ToInt32, enum2 => enum2.ToString());
        }
    }
}
