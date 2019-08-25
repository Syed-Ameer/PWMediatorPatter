using System.Windows.Forms;

namespace BasicMediatorPattern
{
    public class Mediator
    {
        private TextBox _textBox;
        private ListBox _listBox;
        private Button _buttonAdd;
        private Button _buttonClear;

        public void Register(TextBox control)
        {
            _textBox = control;
        }
        public void Register(ListBox control)
        {
            _listBox = control;
        }
        public void Register(Button control)
        {
            if (control.Name == "btn_Add")
                _buttonAdd = control;

            if (control.Name == "btn_Clear")
                _buttonClear = control;
        }
        public void TextChange()
        {
            bool enableFlag = (_textBox.Text.Length > 0);
            enableDisableButtons(enableFlag);
        }
        public void ClickAddButton()
        {
            enableDisableButtons(false);

            _listBox.Items.Add(_textBox.Text);
            _textBox.ResetText();
        }
        public void ClickClearButton()
        {
            enableDisableButtons(false);
            _textBox.ResetText();
        }
        private void enableDisableButtons(bool enableFlag = true)
        {
            _buttonAdd.Enabled = enableFlag;
            _buttonClear.Enabled = enableFlag;
        }
    }
}




