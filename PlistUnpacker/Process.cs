using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public static class Process
{
    static void SwapInt(ref int a,ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    public static void ParsingXml(string name,out info_part[] infos)
    {
        List<info_part> ret = new();
        XmlDocument xf = new ();
        xf.Load(name);
        XmlNode nod_dict = xf.SelectSingleNode("plist/dict");
        XmlNodeList lst_frame = nod_dict.ChildNodes;
        if (lst_frame[0].Name.Equals("key") && lst_frame[0].InnerText.Equals("frames"))
        {
            if (lst_frame[1].Name.Equals("dict"))
            {
                XmlNodeList lst = lst_frame[1].ChildNodes;
                for(int i = 0; i < lst.Count; i+=2)
                {
                    info_part inf = new();
                    ret.Add(inf);
                    inf.name = lst[i].InnerText.Split('.')[0];
                    XmlNodeList info = lst[i + 1].ChildNodes;
                    for(int j = 0; j < info.Count; j += 2)
                    {
                        switch( info[j].InnerText)
                        {
                            case "anchor":
                                {
                                    break;
                                }
                            case "spriteOffset":
                                {
                                    string tmp = info[j + 1].InnerText.Replace("{", "").Replace("}", "");
                                    string[] tt = tmp.Split(',');
                                    if (!int.TryParse(tt[0], out inf.pos_x)) inf.pos_x = 0;
                                    if (!int.TryParse(tt[1], out inf.pos_y)) inf.pos_y = 0;
                                    break;
                                }
                            case "spriteSize":
                                {
                                    
                                    break;
                                }
                            case "spriteSourceSize":
                                {
                                    string tmp = info[j + 1].InnerText.Replace("{", "").Replace("}", "");
                                    string[] tt = tmp.Split(',');
                                    if (!int.TryParse(tt[0], out inf.sprite_width)) inf.sprite_width = 0;
                                    if (!int.TryParse(tt[1], out inf.sprite_height)) inf.sprite_height = 0;
                                    break;
                                }
                            case "textureRect":
                                {
                                    string tmp = info[j + 1].InnerText.Replace("{", "").Replace("}", "");
                                    string[] tt = tmp.Split(',');
                                    if (!int.TryParse(tt[0], out inf.x)) inf.x = 0;
                                    if (!int.TryParse(tt[1], out inf.y)) inf.y = 0;
                                    if (!int.TryParse(tt[2], out inf.xl)) inf.xl = 0;
                                    if (!int.TryParse(tt[3], out inf.yl)) inf.yl = 0;
                                    inf.x2 = inf.x + inf.xl - 2;
                                    inf.y2 = inf.y + inf.yl - 2;
                                    break;
                                }
                            case "textureRotated":
                                {
                                    if (info[j].NextSibling.OuterXml.Contains("true")) inf.is_rotate = true;
                                    else inf.is_rotate = false;
                                    break;
                                }
                            default:break;
                        }
                    }
                    if (inf.is_rotate)
                    {
                        SwapInt(ref inf.xl, ref inf.yl);
                        SwapInt(ref inf.x2, ref inf.y2);
                        SwapInt(ref inf.sprite_width, ref inf.sprite_height);
                    }
                }
            }
        }
        infos = ret.ToArray();
    }
}
