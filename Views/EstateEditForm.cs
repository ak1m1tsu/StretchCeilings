using System.Windows.Forms;
using StretchCeilings.Models;

namespace StretchCeilings.Views
{
    public partial class EstateEditForm : Form
    {
        private readonly Estate _estate;

        public EstateEditForm(Estate estate)
        {
            _estate = estate;
            InitializeComponent();
        }
    }
}
