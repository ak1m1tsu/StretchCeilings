using System.Windows.Forms;
using StretchCeilingsApp.Utility.DLL;

namespace StretchCeilingsApp.Utility.Controls
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
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.MouseOverBackColor = Constants.DraculaRed;
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
