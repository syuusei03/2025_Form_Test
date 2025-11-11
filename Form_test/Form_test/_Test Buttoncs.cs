using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public class Test_Buttoncs : Button
    {
        //ランダム関数
        private static Random random = new Random();
        //理論値を格納する変数
        private bool Boolrandom;        
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
            // 0 =true 1=farse.
            Boolrandom = random.Next(0, 2) == 0;

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

            SetEnable(Boolrandom);



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
            //判定の基準を保管(0.0)
            bool kijun = _form1.GetTestButton(0, 0)._eneble;
            //全部そろっているか状態を保存.
            bool hozon = true;
            
            
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (kijun != _form1.GetTestButton(i, j)._eneble)
                        {
                            hozon = !hozon;
                            break;
                        }
                    }
                    if (!hozon)
                    {
                        break;
                    }
                }
                if (hozon)
                {
                DialogResult result= MessageBox.Show("コンティニュー","",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    
                    for (int k = 0; k < 3; k++)
                    {
                        for(int f = 0;f < 3; f++)
                        {


                            _form1.GetTestButton(k, f).SetEnable(random.Next(0, 2) == 0);



                        }

                    }
                        

                    

                }
                else
                    Application.Exit();


                }
            
          //
            



            //関数を全部変えたいときはｒ二回

        }
        
         
     
    }
}
