using System;
using System.ComponentModel;
using System.Reflection;

namespace CharpEvolution.Ext;

public static class EnumExt
{
    
    
    public static T GetEnumValueFromDescription<T>(this string description)
    {
        FieldInfo[] enums = typeof(T).GetFields();

        foreach (var @enum in enums)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])@enum.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0 && attributes[0].Description == description)
                return (T)Enum.Parse(typeof(T), @enum.Name);
        }

        throw new Exception("Not found");
    }

   
}