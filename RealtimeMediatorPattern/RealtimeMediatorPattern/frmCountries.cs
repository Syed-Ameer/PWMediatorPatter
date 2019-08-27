using System;
using System.Windows.Forms;

namespace RealtimeMediatorPattern
{
    public partial class frmCountries : Form
    {
        IMediator mediator = new ConcreteMediator();

        public frmCountries()
        {
            InitializeComponent();

            mediator.AddColleague(txt_Country);
            mediator.AddColleague(btn_Add);
            mediator.AddColleague(btn_Clear);
            mediator.AddColleague(lst_Countries);
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            mediator.AddButtonClick();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            mediator.ClearButtonClick();
        }
        private void Txt_Country_TextChanged(object sender, EventArgs e)
        {
            mediator.TextChange();
        }
    }
}
