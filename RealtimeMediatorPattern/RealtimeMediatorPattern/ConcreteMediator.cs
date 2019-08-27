using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RealtimeMediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        List<Control> colleagues = new List<Control>();
        public void AddColleague(Control colleague)
        {
            colleagues.Add(colleague);
        }
        public void AddButtonClick()
        {
            TextBox textBox = (TextBox)colleagues.Where(c => c is TextBox).FirstOrDefault();
            ListBox listBox = (ListBox)colleagues.Where(c => c is ListBox).FirstOrDefault();

            enableDisableButton(false);

            listBox.Items.Add(textBox.Text);
            textBox.ResetText();
        }
        public void ClearButtonClick()
        {
            TextBox textBox = (TextBox)colleagues.Where(c => c is TextBox).FirstOrDefault();

            textBox.ResetText();
            enableDisableButton(false);
        }
        public void TextChange()
        {
            TextBox textBox = (TextBox)colleagues.Where(c => c is TextBox).FirstOrDefault();

            enableDisableButton(textBox.Text.Length > 0);
        }
        private void enableDisableButton(bool enableFlag = true)
        {
            List<Control> buttons = colleagues.Where(c => c is Button).ToList();

            foreach (Control control in buttons)
            {
                ((Button)control).Enabled = enableFlag;
            }

        }
    }
}
