using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    internal class Test_Buttoncs : Button
    {

        private Color _onCoLOr = Color.LightGreen;
        private Color _ofCoLOr = Color.LightGray;
        private bool  _eneble;

        public void SetEnable(bool on)
        {
            _eneble = on;

            if (on)
            {
                BackColor = _onCoLOr;
            }
            else
            {
                BackColor = _ofCoLOr;   
            }
              
        }



        public Test_Buttoncs(Point potision, Size size,string text)
        {
            Location = potision;
            Size = size;
            Text = text;

            SetEnable(false);



            Click += hogehogwClick;

        }
        private void hogehogwClick(object sender, EventArgs e)
        {
            SetEnable(!_eneble);
        }

    }
}
