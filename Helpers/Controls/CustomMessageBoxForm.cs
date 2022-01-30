using System.Windows.Forms;
using StretchCeilings.Helpers.DLL;

namespace StretchCeilings.Helpers.Controls
{
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm()
        {
            InitializeComponent();
        }

        public CustomMessageBoxForm(string text, string caption)
        {
            InitializeComponent();

            lblCaption.Text = caption;
            lblMessage.Text = text;
            SetUpButtons();
        }

        private void SetUpButtons()
        {
            btnAccept.DialogResult = DialogResult.OK;
            btnAccept.FlatAppearance.MouseOverBackColor = Constants.DraculaGreen;
            btnCloseForm.DialogResult = DialogResult.Cancel;
            btnCloseForm.FlatAppearance.MouseOverBackColor = Constants.DraculaRed;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            User32.ReleaseCapture();
            User32.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

    public static class CustomMessageBox
    {
        public static void Show(string text, string caption)
        {
            using (var form = new CustomMessageBoxForm(text, caption))
                form.ShowDialog();
        }
    }
}
