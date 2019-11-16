using System;
using System.Reflection;

public static class ViewPathEnum
{
    public static string GetPath(Enum value)
    {
        string output = null;
        Type type = value.GetType();

        //Check first in our cached results...
        //Look for our 'StringValueAttribute' 
        //in the field's custom attributes

        FieldInfo fi = type.GetField(value.ToString());
        ViewPath[] attrs =
           fi.GetCustomAttributes(typeof(ViewPath),
                                   false) as ViewPath[];
        if (attrs.Length > 0)
        {
            output = attrs[0].Value;
        }

        return output;
    }
}