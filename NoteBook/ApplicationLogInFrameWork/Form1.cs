global using System;
global using System.Drawing;
global using System.Drawing.Drawing2D;
global using System.Windows.Forms;
global using Rounded;

namespace NoteBook{
    public partial class Form1 : Form {
        private Button b;
        private Timer t;
        private Image backgroundImage;
        private Label backgroundImageLable;
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1199, 670);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(this.CustomForm_Load);

            backgroundImage = Image.FromFile("C:\\Users\\user\\RiderProjects\\NoteBook\\NoteBook\\ApplicationLogInFrameWork\\Images & Icons\\Images\\LoginPage.jpg");
            backgroundImageLable = new Label();
            backgroundImageLable.Image = backgroundImage;
            backgroundImageLable.SetBounds(0,-3,1199,676);
            
            LoginPanel pane = new LoginPanel(50,Color.FromArgb(30,0,0,0),Color.FromArgb(30,0,0,0));
            pane.SetBounds(-1,-1,1201,672);
            pane.BackColor = Color.FromArgb(0, 0, 0, 0);

            
            // Closing Button 
            RoundPanel closePalne = new RoundPanel(30, Color.FromArgb(208,27,1), Color.FromArgb(208,27,1));
            closePalne.SetBounds(1150,20,32,32);
            Image close = Image.FromFile("C:\\Users\\user\\RiderProjects\\NoteBook\\NoteBook\\Images and Icons\\Icons\\Close.png");
            Label closeLabel = new Label();
            closeLabel.SetBounds(2,2,30,30);
            closeLabel.BackColor = Color.Transparent;
            closeLabel.Image = close;
            closeLabel.Parent = closePalne;
            closeLabel.TabStop = true;
            closePalne.Controls.Add(closeLabel);
            
            closeLabel.Click += (sender, args) => {
                Close();
            };
            backgroundImageLable.Controls.Add(closePalne);
            
            // Minimizing button 
            RoundPanel minPalne = new RoundPanel(30, Color.Transparent, Color.Transparent);
            minPalne.SetBounds(1110,20,32,32);
            minPalne.BackColor = Color.Transparent;
            Image mini = Image.FromFile("C:\\Users\\user\\RiderProjects\\NoteBook\\NoteBook\\Images and Icons\\Icons\\Horizontal Line.png");
            Label miniLabel = new Label();
            miniLabel.SetBounds(2,2,30,30);
            miniLabel.BackColor = Color.Transparent;
            miniLabel.Image = mini;
            miniLabel.Parent = closePalne;
            miniLabel.TabStop = true;
            minPalne.Controls.Add(miniLabel);

            miniLabel.Click += (sender, args) => {
                WindowState = FormWindowState.Minimized;
            };
            backgroundImageLable.Controls.Add(minPalne);
            
            // Question button 
            RoundPanel qPanel = new RoundPanel(30, Color.Transparent, Color.Transparent);
            qPanel.SetBounds(1070,20,32,32);
            qPanel.BackColor = Color.Transparent;
            Image Q = Image.FromFile("C:\\Users\\user\\RiderProjects\\NoteBook\\NoteBook\\Images and Icons\\Icons\\Question Mark.png");
            Label QLabel = new Label();
            QLabel.SetBounds(2,2,30,30);
            QLabel.BackColor = Color.Transparent;
            QLabel.Image = Q;
            QLabel.Parent = qPanel;
            QLabel.TabStop = true;
            qPanel.Controls.Add(QLabel);
            backgroundImageLable.Controls.Add(qPanel);
            
            backgroundImageLable.Controls.Add(pane);
            this.Controls.Add(backgroundImageLable);
            
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

namespace Rounded
{
    public class RoundPanel : Panel {
        int radius;
        private Color start, end;

        public Color Start { get; set;}
        public Color End { get; set;}
        
        public RoundPanel(int radius, Color start, Color end) {
            this.radius = radius;
            this.start = start;
            this.end = end;
        }

        protected override void OnPaint(PaintEventArgs e){
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.start, this.end,
                       LinearGradientMode.ForwardDiagonal)) {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

        }
    }
}
