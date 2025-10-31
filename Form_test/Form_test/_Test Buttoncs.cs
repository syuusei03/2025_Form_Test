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
        public Test_Buttoncs(Point potision, Size size,string text)
        {
            Location = potision;
            Size = size;
            Text = text;

            Click += hogehogwClick;

        }
        private void hogehogwClick(object sender, EventArgs e)
        {
            MessageBox.Show("小泉進次郎");
        }

    }
}
