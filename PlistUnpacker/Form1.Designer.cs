
namespace PlistUnpacker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_plist = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tb_png = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_folder = new System.Windows.Forms.TextBox();
            this.btn_extract = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_protage = new System.Windows.Forms.TextBox();
            this.btn_scale_down = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_view = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_change_grid_color = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_scale_1 = new System.Windows.Forms.Button();
            this.btn_scale_2 = new System.Windows.Forms.Button();
            this.btn_scale_5 = new System.Windows.Forms.Button();
            this.btn_scale_3 = new System.Windows.Forms.Button();
            this.btn_scale_20 = new System.Windows.Forms.Button();
            this.btn_scale_10 = new System.Windows.Forms.Button();
            this.btn_change_box_color = new System.Windows.Forms.Button();
            this.tb_alpha_box = new System.Windows.Forms.TextBox();
            this.tb_alpha_grid = new System.Windows.Forms.TextBox();
            this.btn_alpha_box = new System.Windows.Forms.Button();
            this.btn_alpha_col = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Image File";
            // 
            // tb_plist
            // 
            this.tb_plist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_plist.Location = new System.Drawing.Point(6, 109);
            this.tb_plist.Name = "tb_plist";
            this.tb_plist.ReadOnly = true;
            this.tb_plist.Size = new System.Drawing.Size(188, 23);
            this.tb_plist.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(6, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(188, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Plist File";
            // 
            // tb_png
            // 
            this.tb_png.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_png.Location = new System.Drawing.Point(6, 51);
            this.tb_png.Name = "tb_png";
            this.tb_png.ReadOnly = true;
            this.tb_png.Size = new System.Drawing.Size(188, 23);
            this.tb_png.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(6, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(188, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Output Folder";
            // 
            // tb_folder
            // 
            this.tb_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_folder.Location = new System.Drawing.Point(6, 167);
            this.tb_folder.Name = "tb_folder";
            this.tb_folder.ReadOnly = true;
            this.tb_folder.Size = new System.Drawing.Size(188, 23);
            this.tb_folder.TabIndex = 4;
            // 
            // btn_extract
            // 
            this.btn_extract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_extract.Location = new System.Drawing.Point(589, 616);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(200, 32);
            this.btn_extract.TabIndex = 7;
            this.btn_extract.Text = "Extract";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tb_png);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.tb_plist);
            this.groupBox1.Controls.Add(this.tb_folder);
            this.groupBox1.Location = new System.Drawing.Point(589, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tb_protage
            // 
            this.tb_protage.AllowDrop = true;
            this.tb_protage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_protage.Location = new System.Drawing.Point(671, 222);
            this.tb_protage.Name = "tb_protage";
            this.tb_protage.ReadOnly = true;
            this.tb_protage.Size = new System.Drawing.Size(80, 23);
            this.tb_protage.TabIndex = 6;
            this.tb_protage.Text = "100";
            this.tb_protage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_scale_down
            // 
            this.btn_scale_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_down.Location = new System.Drawing.Point(589, 251);
            this.btn_scale_down.Name = "btn_scale_down";
            this.btn_scale_down.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_down.TabIndex = 9;
            this.btn_scale_down.Text = "Zoom Out";
            this.btn_scale_down.UseVisualStyleBackColor = true;
            this.btn_scale_down.Click += new System.EventHandler(this.btn_scale_down_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(689, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zoom In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_view
            // 
            this.pn_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_view.Location = new System.Drawing.Point(12, 12);
            this.pn_view.Name = "pn_view";
            this.pn_view.Size = new System.Drawing.Size(571, 636);
            this.pn_view.TabIndex = 11;
            this.pn_view.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_view_Paint);
            this.pn_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_view_MouseDown);
            this.pn_view.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_view_MouseMove);
            this.pn_view.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_view_MouseUp);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btn_change_grid_color
            // 
            this.btn_change_grid_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_grid_color.Location = new System.Drawing.Point(589, 559);
            this.btn_change_grid_color.Name = "btn_change_grid_color";
            this.btn_change_grid_color.Size = new System.Drawing.Size(106, 23);
            this.btn_change_grid_color.TabIndex = 12;
            this.btn_change_grid_color.Text = "Change Grid Col";
            this.btn_change_grid_color.UseVisualStyleBackColor = true;
            this.btn_change_grid_color.Click += new System.EventHandler(this.btn_change_grid_color_Click);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(589, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 23);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Scale";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(757, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(32, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "%";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_scale_1
            // 
            this.btn_scale_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_1.Location = new System.Drawing.Point(589, 280);
            this.btn_scale_1.Name = "btn_scale_1";
            this.btn_scale_1.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_1.TabIndex = 15;
            this.btn_scale_1.Text = "Scale 1x";
            this.btn_scale_1.UseVisualStyleBackColor = true;
            this.btn_scale_1.Click += new System.EventHandler(this.btn_scale_1_Click);
            // 
            // btn_scale_2
            // 
            this.btn_scale_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_2.Location = new System.Drawing.Point(689, 280);
            this.btn_scale_2.Name = "btn_scale_2";
            this.btn_scale_2.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_2.TabIndex = 16;
            this.btn_scale_2.Text = "Scale 2x";
            this.btn_scale_2.UseVisualStyleBackColor = true;
            this.btn_scale_2.Click += new System.EventHandler(this.btn_scale_2_Click);
            // 
            // btn_scale_5
            // 
            this.btn_scale_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_5.Location = new System.Drawing.Point(689, 309);
            this.btn_scale_5.Name = "btn_scale_5";
            this.btn_scale_5.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_5.TabIndex = 18;
            this.btn_scale_5.Text = "Scale 5x";
            this.btn_scale_5.UseVisualStyleBackColor = true;
            this.btn_scale_5.Click += new System.EventHandler(this.btn_scale_5_Click);
            // 
            // btn_scale_3
            // 
            this.btn_scale_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_3.Location = new System.Drawing.Point(589, 309);
            this.btn_scale_3.Name = "btn_scale_3";
            this.btn_scale_3.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_3.TabIndex = 17;
            this.btn_scale_3.Text = "Scale 3x";
            this.btn_scale_3.UseVisualStyleBackColor = true;
            this.btn_scale_3.Click += new System.EventHandler(this.btn_scale_3_Click);
            // 
            // btn_scale_20
            // 
            this.btn_scale_20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_20.Location = new System.Drawing.Point(689, 338);
            this.btn_scale_20.Name = "btn_scale_20";
            this.btn_scale_20.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_20.TabIndex = 20;
            this.btn_scale_20.Text = "Scale 20X";
            this.btn_scale_20.UseVisualStyleBackColor = true;
            this.btn_scale_20.Click += new System.EventHandler(this.btn_scale_20_Click);
            // 
            // btn_scale_10
            // 
            this.btn_scale_10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale_10.Location = new System.Drawing.Point(589, 338);
            this.btn_scale_10.Name = "btn_scale_10";
            this.btn_scale_10.Size = new System.Drawing.Size(100, 23);
            this.btn_scale_10.TabIndex = 19;
            this.btn_scale_10.Text = "Scale 10X";
            this.btn_scale_10.UseVisualStyleBackColor = true;
            this.btn_scale_10.Click += new System.EventHandler(this.btn_scale_10_Click);
            // 
            // btn_change_box_color
            // 
            this.btn_change_box_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_box_color.Location = new System.Drawing.Point(589, 530);
            this.btn_change_box_color.Name = "btn_change_box_color";
            this.btn_change_box_color.Size = new System.Drawing.Size(106, 23);
            this.btn_change_box_color.TabIndex = 21;
            this.btn_change_box_color.Text = "Change Box Col";
            this.btn_change_box_color.UseVisualStyleBackColor = true;
            this.btn_change_box_color.Click += new System.EventHandler(this.btn_change_box_color_Click);
            // 
            // tb_alpha_box
            // 
            this.tb_alpha_box.AllowDrop = true;
            this.tb_alpha_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_alpha_box.Location = new System.Drawing.Point(701, 531);
            this.tb_alpha_box.Name = "tb_alpha_box";
            this.tb_alpha_box.Size = new System.Drawing.Size(32, 23);
            this.tb_alpha_box.TabIndex = 22;
            this.tb_alpha_box.Text = "100";
            this.tb_alpha_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_alpha_grid
            // 
            this.tb_alpha_grid.AllowDrop = true;
            this.tb_alpha_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_alpha_grid.Location = new System.Drawing.Point(701, 558);
            this.tb_alpha_grid.Name = "tb_alpha_grid";
            this.tb_alpha_grid.Size = new System.Drawing.Size(32, 23);
            this.tb_alpha_grid.TabIndex = 23;
            this.tb_alpha_grid.Text = "100";
            this.tb_alpha_grid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_alpha_box
            // 
            this.btn_alpha_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alpha_box.Location = new System.Drawing.Point(739, 531);
            this.btn_alpha_box.Name = "btn_alpha_box";
            this.btn_alpha_box.Size = new System.Drawing.Size(50, 23);
            this.btn_alpha_box.TabIndex = 24;
            this.btn_alpha_box.Text = "Alpha";
            this.btn_alpha_box.UseVisualStyleBackColor = true;
            this.btn_alpha_box.Click += new System.EventHandler(this.btn_alpha_box_Click);
            // 
            // btn_alpha_col
            // 
            this.btn_alpha_col.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alpha_col.Location = new System.Drawing.Point(739, 558);
            this.btn_alpha_col.Name = "btn_alpha_col";
            this.btn_alpha_col.Size = new System.Drawing.Size(50, 23);
            this.btn_alpha_col.TabIndex = 25;
            this.btn_alpha_col.Text = "Alpha";
            this.btn_alpha_col.UseVisualStyleBackColor = true;
            this.btn_alpha_col.Click += new System.EventHandler(this.btn_alpha_col_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(589, 587);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 660);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_alpha_col);
            this.Controls.Add(this.btn_alpha_box);
            this.Controls.Add(this.tb_alpha_grid);
            this.Controls.Add(this.tb_alpha_box);
            this.Controls.Add(this.btn_change_box_color);
            this.Controls.Add(this.btn_scale_20);
            this.Controls.Add(this.btn_scale_10);
            this.Controls.Add(this.btn_scale_5);
            this.Controls.Add(this.btn_scale_3);
            this.Controls.Add(this.btn_scale_2);
            this.Controls.Add(this.btn_scale_1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_change_grid_color);
            this.Controls.Add(this.pn_view);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_scale_down);
            this.Controls.Add(this.tb_protage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_extract);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PlistUnpacker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tb_plist;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tb_png;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tb_folder;
        private System.Windows.Forms.Button btn_extract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_protage;
        private System.Windows.Forms.Button btn_scale_down;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_view;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_change_grid_color;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_scale_1;
        private System.Windows.Forms.Button btn_scale_2;
        private System.Windows.Forms.Button btn_scale_5;
        private System.Windows.Forms.Button btn_scale_3;
        private System.Windows.Forms.Button btn_scale_20;
        private System.Windows.Forms.Button btn_scale_10;
        private System.Windows.Forms.Button btn_change_box_color;
        private System.Windows.Forms.TextBox tb_alpha_box;
        private System.Windows.Forms.TextBox tb_alpha_grid;
        private System.Windows.Forms.Button btn_alpha_box;
        private System.Windows.Forms.Button btn_alpha_col;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

