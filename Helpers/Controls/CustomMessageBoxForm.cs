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
            btnAccept.FlatAppearance.MouseOverBackColor = DraculaColor.Green;
            btnCloseForm.DialogResult = DialogResult.Cancel;
            btnCloseForm.FlatAppearance.MouseOverBackColor = DraculaColor.Red;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            User32Helper.ReleaseCapture();
            User32Helper.SendMessage(Handle, 0x112, 0xf012, 0);
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
