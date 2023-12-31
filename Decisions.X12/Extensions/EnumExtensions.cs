﻿using Decisions.X12.Attributes;

namespace Decisions.X12.Extensions;

public static class EnumExtensions
{
    public static string EDIFieldValue(this Enum enumValue)
    {
        var attributes = (EDIFieldValueAttribute[])enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttributes(typeof(EDIFieldValueAttribute), false);
        if (attributes.Length > 0)
            return attributes[0].Value;

        throw new InvalidOperationException("No EDIValue Attribute defined for " + enumValue);
    }

    public static T ToEnumFromEDIFieldValue<T>(this string itemValue)
    {
        var type = typeof(T);
        if (!type.IsEnum)
            throw new InvalidOperationException();

        foreach (var field in from field in type.GetFields()
                              let attributes = (EDIFieldValueAttribute[])field.GetCustomAttributes(typeof(EDIFieldValueAttribute), false)
                              where attributes.Length > 0 && attributes[0].Value == itemValue
                              select field)
        {
            return (T)field.GetValue(null);
        }

        throw new InvalidOperationException("No EDI Field Value found for " + itemValue);
    }
}
