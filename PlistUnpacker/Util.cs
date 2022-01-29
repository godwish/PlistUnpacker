using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;

public static class Util
{
    public static string LoadTextString(string name)
    {
        try{ return System.IO.File.ReadAllText(name); } catch (Exception){ }
        return null;
    }
    public static void SaveTextString(string name,string data)
    {
        try { System.IO.File.WriteAllText(name,data); } catch (Exception) { }
    }
}
