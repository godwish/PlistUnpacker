using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;

public static class Extension
{
    public static void ResizeRedraw(this Control control, bool enabled) {
        var prop = control.GetType().GetProperty("ResizeRedraw", BindingFlags.Instance | BindingFlags.NonPublic); prop.SetValue(control, enabled, null);
    }
    public static void DoubleBuffered(this Control control, bool enabled) {
        var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic); prop.SetValue(control, enabled, null);
    }

    public static void SetHighQuality(this Graphics g)
    {
        g.CompositingMode = CompositingMode.SourceOver;
        g.CompositingQuality = CompositingQuality.HighQuality;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.SmoothingMode = SmoothingMode.HighQuality;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
    }

    public static void DrawCircle(this Graphics g, Pen pen, float centerX, float centerY, float radius)
    {
        g.DrawEllipse(pen, centerX - radius, centerY - radius, radius + radius, radius + radius);
    }

    public static void FillCircle(this Graphics g, Brush brush, float centerX, float centerY, float radius)
    {
        g.FillEllipse(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
    }
}
