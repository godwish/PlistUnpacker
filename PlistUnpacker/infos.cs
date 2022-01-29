using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlistUnpacker;
using LitJson;
using System.Drawing;
public static class infos
{
    private static Form1 frm;
    public static void Load(Form1 f)
    {
        frm = f;
        string str_json = Util.LoadTextString("setting.json");
        if (string.IsNullOrEmpty(str_json))
        { // 기본값으로 설정 후 저장
            Save();
            return;
        }
        JsonData jd = LitJsonGet.Get(str_json);
        JsonData jd_pos = jd["window_position"];
        JsonData jd_size = jd["window_size"];
        JsonData jd_col_box = jd["color_sprite_box"];
        JsonData jd_col_grid = jd["color_grid"];
        int x = LitJsonGet.Int(jd_pos[0]);
        int y = LitJsonGet.Int(jd_pos[1]);
        int width = LitJsonGet.Int(jd_size[0]);
        int height = LitJsonGet.Int(jd_size[1]);
        

        Color box = Color.FromArgb(LitJsonGet.Int(jd_col_box[3]), LitJsonGet.Int(jd_col_box[1]), LitJsonGet.Int(jd_col_box[2]), LitJsonGet.Int(jd_col_box[3]));
        Color grid = Color.FromArgb(LitJsonGet.Int(jd_col_grid[3]), LitJsonGet.Int(jd_col_grid[1]), LitJsonGet.Int(jd_col_grid[2]), LitJsonGet.Int(jd_col_grid[3]));

        frm.col_box = box;
        frm.col_grid = grid;

        //frm.Location = new Point(x, y);
        frm.SetDesktopLocation(x,y);
        frm.Size = new Size(width, height);
    }
    public static void Save()
    {
        JsonData jd = new();
        JsonData jd_pos = new();
        JsonData jd_size = new();
        JsonData jd_col_box = new();
        JsonData jd_col_grid = new();

        Point pnt = frm.Location;
        Size sz = frm.Size;
        
        jd_pos.Add(pnt.X);
        jd_pos.Add(pnt.Y);
        
        jd_size.Add(sz.Width);
        jd_size.Add(sz.Height);
        Color box = frm.col_box;
        Color grid = frm.col_grid;

        jd_col_box.Add((int)box.R);
        jd_col_box.Add((int)box.G);
        jd_col_box.Add((int)box.B);
        jd_col_box.Add((int)box.A);

        jd_col_grid.Add((int)grid.R);
        jd_col_grid.Add((int)grid.G);
        jd_col_grid.Add((int)grid.B);
        jd_col_grid.Add((int)grid.A);

        jd["window_position"] = jd_pos;
        jd["window_size"] = jd_size;
        jd["color_sprite_box"] = jd_col_box;
        jd["color_grid"] = jd_col_grid;
        Util.SaveTextString("setting.json", jd.ToJson());
    }
}
