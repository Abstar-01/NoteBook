using System.Windows.Forms;
using NoteBook;
namespace NoteBook
{
    public class LoginPanel : RoundPanel {
        private Label Title;
        private RoundPanel signin;
        public LoginPanel(int x, Color s, Color e) : base(x,s,e) {
            Title = new Label();
            Title.Text = "People move around";
            Title.SetBounds(50,50,100,50);
            Title.BackColor = Color.Transparent;
            this.Controls.Add(Title);
        }
    }
}