using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class ControlPanel : Control
{
    private Graphics G = null;

    public ControlPanel()
    {
        this.DoubleBuffered = true;
    }

    /// <summary>
    /// OnPaint event of the object.
    /// </summary>
    /// <param name=""e""></param>
    protected override void OnPaint(PaintEventArgs e)
    {
        G = e.Graphics;
        G.SetHighQuality();
        DrawNode();
    }

    /// <summary>
    /// On resize event of the object.
    /// </summary>
    /// <param name=""e""></param>
    protected override void OnResize(EventArgs e)
    {
        Invalidate();
        base.OnResize(e);
    }

    /// <summary>
    /// Draws a node control.
    /// </summary>
    protected void DrawNode()
    {
        G.Clear(Color.Magenta);
    }
}