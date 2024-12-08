using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.CustomControl
{
    public partial class _DateTimePickerValid : DateTimePicker
    {
        public bool isValid { set; get; } = false;
        public bool _teacher { set; get; } = false;
        public bool _user { set; get; } = false;
        public bool _student { set; get; } = false;
        public _DateTimePickerValid()
        {
            InitializeComponent();
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);

            if(_student && DateTime.Now.Year - Value.Year >= 6)
            {
                isValid = true;
            }
            else if((_teacher || _user) && DateTime.Now.Year - Value.Year >= 18)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
        }
    }
}
