using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace PlistUnpacker
{
    public partial class Form1 : Form
    {
        string[] name_ext_info = { "plist"};
        string[] name_ext_image = {"png","jpg","jpeg" };
        Pen pen_box, pen_grid;
        Image img;
        public Color col_box, col_grid;
        Timer graphicsTimer;

        bool is_change_grid_color;
        bool is_change_box_color;
        int pos_push_x, pos_push_y;
        int pos_add_x, pos_add_y;
        info_part[] parts;

        public Form1()
        {
            InitializeComponent();
            img = null;
            pn_view.DoubleBuffered(true);
            is_change_grid_color = false;
            is_change_box_color = false;

            col_grid = Color.FromArgb(64, 255, 255, 255);
            pen_grid = new Pen(col_grid, 1);

            col_box = Color.White;
            pen_box = new Pen(col_box, 1);
            tb_alpha_grid.Text = col_grid.A.ToString();
            tb_alpha_box.Text = col_box.A.ToString();
            infos.Load(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            parts = null;
            pos_add_x = 0;
            pos_add_y = 0;
            graphicsTimer = new();
            graphicsTimer.Interval = 10;
            graphicsTimer.Tick += GraphicsTimer_Tick;
            graphicsTimer.Start();
        }
        void ScaleUp()
        {
            if (!int.TryParse(tb_protage.Text, out int protage)) protage = 100;
            protage /= 2;
            pos_add_x /= 2;
            pos_add_y /= 2;
            tb_protage.Text = protage.ToString();
        }
        void ScaleDown()
        {
            if (!int.TryParse(tb_protage.Text, out int protage)) protage = 100;
            protage *= 2;
            pos_add_x *= 2;
            pos_add_y *= 2;
            tb_protage.Text = protage.ToString();
        }
        private void GraphicsTimer_Tick(object sender, EventArgs e) { pn_view.Invalidate(); }
        private void Form1_DragEnter(object sender, DragEventArgs e) { if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy; }
        private void Form1_DragDrop(object sender, DragEventArgs e) { MakeDropFile(((string[])(e.Data.GetData(DataFormats.FileDrop)))[0]); }
        private void btn_scale_down_Click(object sender, EventArgs e) { ScaleUp(); }
        private void button1_Click(object sender, EventArgs e) { ScaleDown(); }
        private void btn_change_grid_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            tb_alpha_grid.Text = col_grid.A.ToString();
            if (!byte.TryParse(tb_alpha_grid.Text, out byte alpha)) alpha = 255;
            col_grid = Color.FromArgb(alpha, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            is_change_grid_color = true;
        }
        private void btn_change_box_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            tb_alpha_box.Text = col_box.A.ToString();
            if (!byte.TryParse(tb_alpha_box.Text, out byte alpha)) alpha = 255;
            col_box = Color.FromArgb(alpha, colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            is_change_box_color = true;
        }
        private void pn_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            pos_push_x = e.X;
            pos_push_y = e.Y;
        }
        private void pn_view_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            pos_push_x = e.X;
            pos_push_y = e.Y;
        }
        void ScaleProtage(int prot) {
            if (!int.TryParse(tb_protage.Text, out int protage)) protage = 100;
            float scale = prot / protage;
            protage = prot;
            pos_add_x = (int)(pos_add_x * scale);
            pos_add_y = (int)(pos_add_y * scale);
            tb_protage.Text = protage.ToString();
        }
        private void btn_scale_1_Click(object sender, EventArgs e){ ScaleProtage(100); }

        private void btn_scale_2_Click(object sender, EventArgs e) { ScaleProtage(200); }

        private void btn_scale_3_Click(object sender, EventArgs e) { ScaleProtage(300); }

        private void btn_scale_5_Click(object sender, EventArgs e) { ScaleProtage(500); }

        private void btn_scale_10_Click(object sender, EventArgs e) { ScaleProtage(1000); }

        private void btn_scale_20_Click(object sender, EventArgs e) { ScaleProtage(2000); }

        private void btn_alpha_box_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(tb_alpha_box.Text, out byte alpha)) alpha = 255;
            col_box = Color.FromArgb(alpha, col_box.R, col_box.G, col_box.B);
            is_change_box_color = true;
            //infos.Save();
        }

        private void btn_alpha_col_Click(object sender, EventArgs e)
        {
            if (!byte.TryParse(tb_alpha_grid.Text, out byte alpha)) alpha = 255;
            col_grid = Color.FromArgb(alpha, col_box.R, col_box.G, col_box.B);
            is_change_grid_color = true;
            //infos.Save();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Add) ScaleUp();
            else if (e.KeyChar == (char)Keys.Subtract) ScaleDown();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) { infos.Save(); }

        private void pn_view_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            pos_add_x += e.X - pos_push_x;
            pos_add_y += e.Y - pos_push_y;
            pos_push_x = e.X;
            pos_push_y = e.Y;
        }
        void MakeDropFile(string full_name)
        {
            FileAttributes fa = File.GetAttributes(full_name);
            if ((fa & FileAttributes.Directory) == FileAttributes.Directory)
            {
                tb_folder.Text = full_name;
                return;
            }

            string[] tmp = full_name.Split('.');
            if (tmp.Length < 2) return;
            // 앞 이름 만들기;;
            StringBuilder sb = new();
            for(int i = 0; i < tmp.Length - 1; ++i)
            {
                if (i > 0) sb.Append('.');
                sb.Append(tmp[i]);
            }
            string front = sb.ToString();

            // 정보 파일 있는지 
            for(int i = 0; i < name_ext_info.Length; ++i)
            {
                string name = front + "." + name_ext_info[i];
                FileInfo fi = new(name);
                if (!fi.Exists) continue;
                tb_plist.Text = name;
                Process.ParsingXml(name, out parts);
                break;
            }
            // 이미지 있는지 확인
            for (int i = 0; i < name_ext_image.Length; ++i)
            {
                string name = front + "." + name_ext_image[i];
                FileInfo fi = new(name);
                if (!fi.Exists) continue;
                tb_png.Text = name;
                img = Image.FromFile(name);
                break;
            }
        }
        private void pn_view_Paint(object sender, PaintEventArgs e)
        {
            if (is_change_box_color)
            {
                is_change_box_color = false;
                pen_box.Dispose();
                pen_box = new Pen(col_box, 1);
            }
            if (is_change_grid_color)
            {
                is_change_grid_color = false;
                pen_grid.Dispose();
                pen_grid = new Pen(col_grid, 1);
            }
            Graphics grp = e.Graphics;
            grp.Clear(Color.Black);
            grp.InterpolationMode = InterpolationMode.NearestNeighbor;
            if (!int.TryParse(tb_protage.Text, out int protage)) protage = 0;
            if (protage == 0) return;
            
            if (img != null)
            {
                int x = pos_add_x;
                int y = pos_add_y;
                int width = img.Width * protage / 100;
                int height = img.Height * protage / 100;
                grp.DrawImage(img, x, y, width, height);
            }
            float scale = protage / 100;
            if (parts != null)
            { // 스프라이트 영역 그리기
                for (int i = 0; i < parts.Length; ++i)
                {
                    int x = (int)((parts[i].x+0.5f) * scale + pos_add_x);
                    int y = (int)((parts[i].y+0.5f) * scale + pos_add_y);
                    int xl = (parts[i].xl-1) * protage / 100;
                    int yl = (parts[i].yl-1) * protage / 100;
                    grp.DrawRectangle(pen_box, x, y, xl, yl);
                }
            }
            if (protage >= 500)
            {   // 그리드 그리기
                for (int i = 0; i <= img.Width; ++i)
                {
                    int x = (int)((i + 0.5f) * scale + pos_add_x);
                    if (x < 0 && x >= pn_view.Width) continue;
                    grp.DrawLine(pen_grid, x,0, x,pn_view.Height);
                }
                for (int i = 0; i < img.Height; ++i)
                {
                    int y = (int)((i + 0.5f) * scale + pos_add_y);
                    if (y < 0 && y >= pn_view.Height) continue;
                    grp.DrawLine(pen_grid,0, y,pn_view.Width, y);
                }
            }
        }
        private void btn_extract_Click(object sender, EventArgs e)
        {
            if (parts == null) return;
            if (string.IsNullOrEmpty(tb_folder.Text)) return;
            if (string.IsNullOrEmpty(tb_plist.Text)) return;
            if (string.IsNullOrEmpty(tb_png.Text)) return;
            progressBar1.Maximum = parts.Length;
            for (int i = 0; i < parts.Length; ++i)
            {
                progressBar1.Value = i + 1;
                Rectangle rect_src = new(parts[i].pos_x, parts[i].pos_y, parts[i].xl, parts[i].yl);
                Rectangle rect_dest = new(parts[i].x,parts[i].y,parts[i].xl,parts[i].yl);
                Bitmap bmp = new (parts[i].sprite_width,parts[i].sprite_height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.Transparent);
                g.DrawImage(img,rect_src,rect_dest,GraphicsUnit.Pixel);
                g.Dispose();
                string name_out = tb_folder.Text + "\\" + parts[i].name+".png";
                bmp.Save(name_out);
            }
        }
    }
}
