using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)//6回繰り返す
            {
                for (int j = 0; j < 3; j++)//４回繰り返す
                {    //インスタンスの設定
                    Test_Buttoncs testButton = new Test_Buttoncs(new Point(50 * i, 50 * j), new Size(50, 50), "a");                

                    //コントロール内にボタンを設定
                    Controls.Add(testButton);

                }
            }
        }
        private void hogehogwClick(object sender, EventArgs e)
        {
            MessageBox.Show("小泉進次郎");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("高市早苗");
        }

    }
}
