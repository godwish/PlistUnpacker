using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;

public static class LitJsonGet
{
    public static JsonData Get(in string str) => JsonMapper.ToObject(str);
    public static bool Bool(JsonData jd)
    {
        if (jd == null) return false;
        if (jd.IsBoolean) return (bool)jd;
        if (jd.IsObject) return false;
        if (jd.IsArray) return false;
        if (jd.IsInt) return (int)jd > 0;
        if (jd.IsLong) return (long)jd > 0;
        if (jd.IsDouble) return ((double)jd) > 0.0;
        string str = (string)jd;
        if (str.ToLower().Equals("true")) return true;
        if (double.TryParse(str, out double value)) return value > 0.0;
        return false;
    }
    public static int Int(JsonData jd)
    {
        if (jd == null) return 0;
        if (jd.IsInt) return (int)jd;
        if (jd.IsObject) return 0;
        if (jd.IsArray) return 0;
        if (jd.IsBoolean) return (bool)jd ? 1 : 0;
        if (jd.IsLong) return (int)((long)jd);
        if (jd.IsDouble) return (int)((double)jd);
        if (int.TryParse((string)jd, out int value)) return value;
        return 0;
    }
    public static long Long(JsonData jd)
    {
        if (jd == null) return 0;
        if (jd.IsLong) return (int)((long)jd);
        if (jd.IsObject) return 0;
        if (jd.IsArray) return 0;
        if (jd.IsInt) return (long)((int)jd);
        if (jd.IsBoolean) return (bool)jd ? 1 : 0;
        if (jd.IsDouble) return (long)(double)jd;
        if (long.TryParse((string)jd, out long value)) return value;
        return 0;
    }
    public static double Double(JsonData jd)
    {
        if (jd == null) return 0;
        if (jd.IsDouble) return (double)jd;
        if (jd.IsObject) return 0;
        if (jd.IsArray) return 0;
        if (jd.IsLong) return (double)((long)jd);
        if (jd.IsInt) return (double)((int)jd);
        if (jd.IsBoolean) return (bool)jd ? 1 : 0;
        if (double.TryParse((string)jd, out double value)) return value;
        return 0;
    }
    public static string String(JsonData jd)
    {
        if (jd == null) return null;
        if (jd.IsString) return (string)jd;
        if (jd.IsObject) return jd.ToJson();
        if (jd.IsArray) return jd.ToJson();
        return jd.ToString();
    }
}
