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
        //<summary>横位置<summary>
        private int _x;
        //<summary>縦位置<summary>
        private int _y;

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

        public void Toggle()
        {
            SetEnable(!_eneble);
        }


        public Test_Buttoncs(Form1 form1, int x, int y, Point potision, Size size, string text)
        {
            //Form1の参照を補完

            _form1 = form1;

            //横位置を参照

            _x = x;

            //縦位置を参照

            _y = y;

            //ボタンの位置を設定

            Location = potision;

            //ボタンの大きさを設定

            Size = size;

            Text = text;

            SetEnable(false);



            Click += hogehogwClick;

        }
        private void hogehogwClick(object sender, EventArgs e)
        {
            //楽な書き方
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x + 1, _y)?.Toggle();
            _form1.GetTestButton(_x - 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y + 1)?.Toggle();
            _form1.GetTestButton(_x, _y - 1)?.Toggle();

            //かっこいい書き方
            //for (int i = 0; i < _toggleDate.Length; i++)
            //{
            //    var data = _toggleDate[i];
            //    var button = _form1.GetTestButton(_x + data[0], _y + data[1]);
            //
            //    if (button != null)
            //    {
            //        button.Toggle();
            //    }
            //}
            //関数を全部変えたいときはｒ二回

        }
       //
       //private int[][] _toggleDate =
       //{
       //    new int[]{0,0 },
       //    new int[]{1,0 },
       //    new int[]{-1,0},
       //    new int[]{0,1},
       //
       //};
       //
    }
}
