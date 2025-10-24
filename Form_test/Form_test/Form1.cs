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
            for (int i = 0; i < 6; i++)//四回繰り返す
            for (int j = 0; j < 4; j++)
            {    //インスタンスの設定
                Test_Buttoncs testButton = new Test_Buttoncs();
                //ボタンの位置を設定


                testButton.Location = new Point(50 * i, 50*j);

                //ボタンの大きさを設定
                testButton.Size = new Size(50, 50);
                //ボタン内のテキスト            
                testButton.Text = "ぼたん２";

                //コントロール内にボタンを設定
                Controls.Add(testButton);
            }
        }
                private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("高市早苗");
        }
       
    }
}
