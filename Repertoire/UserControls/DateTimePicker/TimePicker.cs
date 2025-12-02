using System.Windows.Forms;

namespace Theaters.UserControls
{
    class TimePicker : DatePicker
    {
        public TimePicker()
        {
            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = "HH:mm";
            this.calenderIcon = Properties.Resources.clock;
        }
    }
}
