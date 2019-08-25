using System;
using System.Windows.Forms;

namespace BasicMediatorPattern
{
    public partial class frmCountries : Form
    {
        private readonly Mediator _mediator = new Mediator();

        public frmCountries()
        {
            InitializeComponent();

            _mediator.Register(txt_Country);
            _mediator.Register(lst_Countries);
            _mediator.Register(btn_Add);
            _mediator.Register(btn_Clear);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            _mediator.ClickAddButton();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _mediator.ClickClearButton();
        }

        private void Txt_Country_TextChanged(object sender, EventArgs e)
        {
            _mediator.TextChange();
        }
    }
}
