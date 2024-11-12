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

namespace NoteBook{
    public partial class Form1 : Form {
        private Button b;
        private Timer t;
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.CustomForm_Load);

        }

        private void CustomForm_Load(object sender, EventArgs e) {
            int radius = 50;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            
            this.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
        }
    }
}

class RoundPanel : Panel {
    int radius;
    private Color start, end;
    public RoundPanel(int radius, Color start, Color end) {
        this.radius = radius;
        this.start = start;
        this.end = end;
    }
    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
        path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
        path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
        path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
        path.CloseFigure();
            
        this.Region = new Region(path);

        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,this.start, this.end, LinearGradientMode.ForwardDiagonal)) {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        
    }
}