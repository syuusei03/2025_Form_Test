using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public class Test_Buttoncs : Button
    {

        private Color _onCoLOr = Color.LightGreen;
        private Color _ofCoLOr = Color.LightGray;
        private bool _eneble;
        private Form1 _form1;

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



        public Test_Buttoncs(Form1 form1, Point potision, Size size, string text)
        {
            //Form1の参照を補完
            _form1 = form1;
            //ボタンの位置を設定
            Location = potision;
            Size = size;
            Text = text;

            SetEnable(false);



            Click += hogehogwClick;

        }
        private void hogehogwClick(object sender, EventArgs e)
        {
            _form1.GetTestButton(1, 1).SetEnable(true);

        }

    }
}
