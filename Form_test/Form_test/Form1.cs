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
        //constをつけると初期化時にのみ値の変更が可能になる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;

        const int BOARD_SIZE_Y = 3;
        private Test_Buttoncs[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();
            _buttonArray = new Test_Buttoncs[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {    //インスタンスの生成
                    Test_Buttoncs testButton =
                        new Test_Buttoncs(this,
                        new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");

                    //配列にボタンも参照を追加
                    _buttonArray[j, i] = testButton;




                    //コントロール内にボタンを設定
                    Controls.Add(testButton);

                }
            }

            GetTestButton(0, 0).SetEnable(true);
        }

        public Test_Buttoncs GetTestButton(int x, int y)
        {
            return _buttonArray[y, x];
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