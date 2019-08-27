using System.Windows.Forms;

namespace RealtimeMediatorPattern
{
    public interface IMediator
    {
        void AddColleague(Control colleague);

        void TextChange();

        void AddButtonClick();

        void ClearButtonClick();
    }
}
