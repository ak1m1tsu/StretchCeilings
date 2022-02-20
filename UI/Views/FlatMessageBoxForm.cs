using System.Windows.Forms;
using StretchCeilings.UI.Extensions;
using StretchCeilings.UI.Structs;
using StretchCeilings.UI.Views.Enums;

namespace StretchCeilings.UI.Views
{
    public partial class FlatMessageBoxForm : Form
    {
        private readonly MessageBoxState _state;

        public FlatMessageBoxForm()
        {
            InitializeComponent();
        }

        public FlatMessageBoxForm(string text, string caption, MessageBoxState state)
        {
            _state = state;
            InitializeComponent();
            lblCaption.Text = caption;
            lblMessage.Text = text;
            SetUpButtons();
        }

        private void SetUpButtons()
        {
            btnOk.DialogResult = DialogResult.OK;
            btnOk.FlatAppearance.MouseOverBackColor = DraculaColor.Green;

            btnCloseForm.DialogResult = DialogResult.Cancel;
            btnCloseForm.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            if (_state != MessageBoxState.Question)
                return;

            btnNo.DialogResult = DialogResult.No;
            btnNo.Visible = true;
            btnNo.FlatAppearance.MouseOverBackColor = DraculaColor.Red;

            btnYes.DialogResult = DialogResult.Yes;
            btnYes.Visible = true;
            btnYes.FlatAppearance.MouseOverBackColor = DraculaColor.Green;

            btnOk.Visible = false;
        }

        private void DragMove(object sender, MouseEventArgs e)
        {
            Handle.DragMove(e);
        }
    }

    public static class FlatMessageBox
    {
        public static DialogResult ShowDialog(string text, string caption, MessageBoxState state = MessageBoxState.Default)
        {
            using (var form = new FlatMessageBoxForm(text, caption, state))
                return form.ShowDialog();
        }
    }
}
