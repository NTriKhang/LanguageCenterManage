using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LanguageCenterManage.CustomControl
{
    public partial class _TextValid : TextBox
    {
        public bool _email { set; get; } = false;
        public bool _phone { set; get; } = false;
        public bool isValid { set; get; } = false;
        public _TextValid()
        {
            InitializeComponent();

        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if(_email)
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                isValid =  Regex.IsMatch(Text, pattern);
            }
            else if (_phone)
            {
                string phonePattern = @"^0\d{9,10}$";
                isValid = Regex.IsMatch(Text, phonePattern);
            }
        }
    }
}
