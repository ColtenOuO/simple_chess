using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_chess
{
    public partial class Form1 : Form
    {
        Button[,] a = new Button[8, 8];
        int time = 10,choose = 0;
        int now = 1, p1 = 3, p2 = 3;
        Chess[,] info = new Chess[8, 8];

        int atk_check1 = -1,atk_check2 = -1;
        int move_idx1 = -1, move_idx2 = -1;
        int skill = -1;

        public Form1()
        {
            InitializeComponent();
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


            button16.Visible = false;

            label1.Text = "";
            label3.Visible = false;
            label4.Visible = false;
            label2.Visible = false;

            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }
        public void init()
        {
            timer1.Enabled = true;
            time = 10;
            for (int i = 1; i <= 7; i++)
            {
                for(int k=1;k<=6;k++) info[i,k] = new Chess();
            }

            for(int i=1;i<=7;i++)
            {
                for(int k=1;k<=6;k++)
                {
                    a[i, k] = new Button();
                    a[i, k].SetBounds(100 + 50 * k, 40 + 50 * i, 50, 50);
                //    a[i, k].Text = "" + i + k;
                    Controls.Add(a[i, k]);

                    int idx1 = i, idx2 = k;
                    a[i, k].Click += (sender, ex) => a_Click(a[idx1,idx2]);

                    info[i, k].atk = -1;
                }
            }

            label1.Text = "P1 準備階段";

            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

        }
        public void prepare2()
        {
            for (int k = 6; k >= 4; k--)
            {
                for (int i = 1; i <= 7; i++)
                {
                    if (button5.Enabled == false && button6.Enabled == false && button7.Enabled == false) break;

                    if (button5.Enabled == true && a[i, k].Enabled == true)
                    {
                        a[i, k].BackColor = Color.LightPink;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "戰士";
                        button5.Enabled = false;
                        button5.Text = "戰士: 0 顆";

                        info[i, k].init1();
                    }
                    if (button6.Enabled == true && a[i, k].Enabled == true)
                    {
                        a[i, k].BackColor = Color.LightPink;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "法師";
                        button6.Enabled = false;
                        button6.Text = "法師: 0 顆";

                        info[i, k].init2();
                    }
                    if (button7.Enabled == true && a[i, k].Enabled == true)
                    {
                        a[i, k].BackColor = Color.LightPink;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "遊俠";
                        button7.Enabled = false;
                        button7.Text = "遊俠: 0 顆";

                        info[i, k].init3();
                    }
                }
            }

            timer1.Enabled = false;
            time = 10;
            label1.Text = "P2 準備階段";
            timer1.Enabled = true;
        }
        public void prepare1()
        {
            for(int k=1;k<=3;k++)
            {
                for(int i=1;i<=7;i++)
                {
                    if (button2.Enabled == false && button3.Enabled == false && button4.Enabled == false) break;

                    if( button2.Enabled == true && a[i,k].Enabled == true )
                    {
                        a[i, k].BackColor = Color.LightBlue;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "戰士";
                        button2.Enabled = false;
                        button2.Text = "戰士: 0 顆";

                        info[i, k].init1();
                    }
                    if (button3.Enabled == true && a[i, k].Enabled == true)
                    {
                        a[i, k].BackColor = Color.LightBlue;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "法師";
                        button3.Enabled = false;
                        button3.Text = "法師: 0 顆";

                        info[i, k].init2();
                    }
                    if (button4.Enabled == true && a[i, k].Enabled == true)
                    {
                        a[i, k].BackColor = Color.LightBlue;
                        a[i, k].Enabled = false;
                        a[i, k].Text = "遊俠";
                        button4.Enabled = false;
                        button4.Text = "遊俠: 0 顆";

                        info[i, k].init3();
                    }
                }
            }

            timer1.Enabled = false;
            time = 10;
            label1.Text = "P2 準備階段";
            timer1.Enabled = true;
        }
        private void a_Click(object sender)
        {
            string s = ((Button)sender).Text;
            ((Button)sender).Text = "check";
            int idx1 = 1, idx2 = 1;
            for (int i = 1; i <= 7; i++)
            {
                for (int k = 1; k <= 6; k++)
                {
                    if (a[i, k].Text == "check")
                    {
                        idx1 = i;
                        idx2 = k;
                    }
                }
            }

            ((Button)sender).Text = s;

            if (choose == 0 && button2.Enabled == true && button16.Visible == false ) choose = 1;
            else if (choose == 0 && button3.Enabled == true && button16.Visible == false) choose = 2;
            else if (choose == 0 && button4.Enabled == true && button16.Visible == false) choose = 3;
            else if (choose == 0 && button5.Enabled == true && button16.Visible == false) choose = 1;
            else if (choose == 0 && button6.Enabled == true && button16.Visible == false) choose = 2;
            else if (choose == 0 && button7.Enabled == true && button16.Visible == false) choose = 1;
            else if( atk_check1 != -1 && info[idx1,idx2].atk != -1 )
            {
                if( a[idx1,idx2].BackColor == a[atk_check1,atk_check2].BackColor )
                {
                    MessageBox.Show("不能攻擊自己的棋子");
                    return;
                }

                if( now % 6 != 0 && now % 6 <= 3  )
                {
                    if( label1.Text[1] == '1' )
                    {
                        int len1 = idx1 - atk_check1, len2 = idx2 - atk_check2;
                        if (len1 < 0) len1 *= -1;
                        if (len2 < 0) len2 *= -1;

                        if( len1 + len2 > info[atk_check1,atk_check2].atkRange )
                        {
                            MessageBox.Show("超出攻擊範圍");
                            atk_check1 = atk_check2 = -1;

                            button8.Enabled = true;
                            button9.Enabled = true;
                            button10.Enabled = true;
                            button11.Enabled = true;
                            button12.Enabled = true;
                            button13.Enabled = true;
                            button14.Enabled = true;
                            button15.Enabled = true;
                        }
                        else
                        {
                            if (skill == 1) info[atk_check1, atk_check2].hp += info[atk_check1, atk_check2].atk / 2;
                            else if (skill == 2) info[atk_check1, atk_check2].atk *= 2;
                            else if (skill == 3) info[atk_check1, atk_check2].moveRange++;

                            info[idx1, idx2].hp -= info[atk_check1, atk_check2].atk;

                            if( skill != -1 && skill == 2 )
                            {
                                if( skill == 2 ) info[atk_check1, atk_check2].atk /= 2;
                                if( skill == 3 ) info[atk_check1, atk_check2].moveRange--;

                                skill = -1;
                                info[atk_check1, atk_check2].mp -= 10;
                            }

                            if ( info[idx1,idx2].hp <= 0 )
                            {
                                info[idx1, idx2].atk = -1;
                                a[idx1, idx2].Text = "";
                                a[idx1,idx2].BackColor = Color.White;

                                p2--;
                            }
                            atk_check1 = atk_check2 = -1;

                            button16.Enabled = true;
                            MessageBox.Show("攻擊成功!\n");

                        }
                    }

                    return;
                }
                else
                {
                    if ( label1.Text[1] == '2')
                    {
                        int len1 = idx1 - atk_check1, len2 = idx2 - atk_check2;
                        if (len1 < 0) len1 *= -1;
                        if (len2 < 0) len2 *= -1;

                        if (len1 + len2 > info[atk_check1, atk_check2].atkRange)
                        {
                            MessageBox.Show("超出攻擊範圍");
                            atk_check1 = atk_check2 = -1;

                            button8.Enabled = true;
                            button9.Enabled = true;
                            button10.Enabled = true;
                            button11.Enabled = true;
                            button12.Enabled = true;
                            button13.Enabled = true;
                            button14.Enabled = true;
                            button15.Enabled = true;

                        }
                        else
                        {
                            if (skill == 1) info[atk_check1, atk_check2].hp += info[atk_check1, atk_check2].atk / 2;
                            else if (skill == 2) info[atk_check1, atk_check2].atk *= 2;
                            else if (skill == 3) info[atk_check1, atk_check2].moveRange++;

                            if (skill != -1 && skill == 2)
                            {
                                if (skill == 2) info[atk_check1, atk_check2].atk /= 2;
                                if (skill == 3) info[atk_check1, atk_check2].moveRange--;

                                skill = -1;
                                info[atk_check1, atk_check2].mp -= 10;
                            }

                            info[idx1, idx2].hp -= info[atk_check1, atk_check2].atk;
                            if (info[idx1, idx2].hp <= 0)
                            {
                                info[idx1, idx2].atk = -1;
                                a[idx1, idx2].Text = "";
                                a[idx1, idx2].BackColor = Color.White;
                                p1--;
                            }
                            atk_check1 = atk_check2 = -1;

                            button16.Enabled = true;
                            MessageBox.Show("攻擊成功!\n");
                        }
                    }
                }

                return;
            }
            else if( move_idx1 != -1 )
            {
                int len1 = idx1 - move_idx1, len2 = idx2 - move_idx2;
                if (len1 < 0) len1 *= -1;
                if (len2 < 0) len2 *= -1;

                if(((Button)sender).Enabled == true && len1 + len2 <= info[move_idx1,move_idx2].moveRange && info[idx1,idx2].atk == -1 )
                {
                    Button u = new Button();
                    u = a[move_idx1, move_idx2];

                    a[idx1, idx2].Text = a[move_idx1, move_idx2].Text;
                    a[idx1, idx2].BackColor = a[move_idx1, move_idx2].BackColor;
                    info[idx1, idx2] = info[move_idx1, move_idx2];
                    info[move_idx1, move_idx2].atk = -1;

                    a[move_idx1, move_idx2].Enabled = true;
                    a[move_idx1, move_idx2].BackColor = Color.White;
                    a[move_idx1, move_idx2].Text = "";


                    move_idx1 = move_idx2 = -1;

                    button16.Enabled = true;

                }
                else
                {
                    MessageBox.Show("超出移動範圍");

                    move_idx1 = move_idx2 = -1;

                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                }

                return;
            }
            else if( info[idx1,idx2].atk != -1 )
            {

                if ( idx2 <= 3 )
                {
                    label3.Text = "P1\n" + a[idx1, idx2].Text; 

                    label5.Text = "";
                    label5.Text += "HP: " + info[idx1, idx2].hp + "\n";
                    label5.Text += "MP: " + info[idx1, idx2].mp + "\n";
                    label5.Text += "ATK: " + info[idx1, idx2].atk + "\n";
                    label5.Text += "ATK Range: " + info[idx1, idx2].atkRange + "\n";
                    label5.Text += "MOVE Range: " + info[idx1, idx2].moveRange + "\n";
                }
                else
                {
                    label4.Text = "P2\n" + a[idx1, idx2].Text;

                    label6.Text = "";
                    label6.Text += "HP: " + info[idx1, idx2].hp + "\n";
                    label6.Text += "MP: " + info[idx1, idx2].mp + "\n";
                    label6.Text += "ATK: " + info[idx1, idx2].atk + "\n";
                    label6.Text += "ATK Range: " + info[idx1, idx2].atkRange + "\n";
                    label6.Text += "MOVE Range: " + info[idx1, idx2].moveRange + "\n";
                }

                return;
            }


            if ( ((Button)sender).Enabled == true )
            {
                if (choose == 1) ((Button)sender).Text = "戰士";
                else if (choose == 2) ((Button)sender).Text = "法師";
                else if (choose == 3) ((Button)sender).Text = "遊俠";
                else return;

                if (choose == 1) info[idx1, idx2].init1();
                if (choose == 2) info[idx1, idx2].init2();
                if (choose == 3) info[idx1, idx2].init3();

                if (label1.Text[1] == '1' ) ((Button)sender).BackColor = Color.LightBlue;
                else ((Button)sender).BackColor = Color.LightPink;

                ((Button)sender).Enabled = false;
            }

            choose = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            button1.Visible = false;
            timer1.Enabled = true;
            init();

            for(int i=1;i<=7;i++)
            {
                for(int k=4;k<=6;k++)
                {
                    a[i, k].Enabled = false;
                }
            }

           // prepare1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            choose = 1;
            button2.Enabled = false;
            button2.Text = "戰士: 0 顆";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choose = 2;
            button3.Enabled = false;
            button3.Text = "法師: 0 顆";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choose = 3;
            button4.Enabled = false;
            button4.Text = "遊俠: 0 顆";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            choose = 1;
            button5.Enabled = false;
            button5.Text = "戰士: 0 顆";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            choose = 2;
            button6.Enabled = false;
            button6.Text = "法師: 0 顆";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            choose = 3;
            button7.Enabled = false;
            button7.Text = "法師: 0 顆";
        }
        public void p1_attack1()
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            int idx1 = 0, idx2 = 0;

            if (now % 6 == 1 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;

                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if (now % 6 == 2 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if( now % 6 == 3 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if( now % 6 == 4 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if (now % 6 == 5)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if (now % 6 == 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    if (info[idx1, idx2].mp < 10) return;
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }

            if (idx1 == 0)
            {
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;

                now++;
                game();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = false;

            now++;
            game();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            now++;
            game();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            int idx1 = 0, idx2 = 0;

            if (now % 6 == 1 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }
            else if (now % 6 == 2 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }
            else if( now % 6 == 3 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }
            else if( now % 6 == 4 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }
            else if (now % 6 == 5)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }
            else if (now % 6 == 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    move_idx1 = idx1;
                    move_idx2 = idx2;
                }
            }

            if (idx1 == 0)
            {
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;

                now++;
                game();
            }
        }

        private void button8_Click(object sender, EventArgs e) 
        {
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

            int idx1 = 0, idx2 = 0;

            if ( now % 6 == 1  )
            {

                for(int i=1;i<=7;i++)
                {
                    for(int k=1;k<=3;k++)
                    {
                        if( a[i,k].Text == "戰士" )
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if( idx1 != 0 )
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if( now % 6 == 2  )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if( now % 6 == 3 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if( now % 6 == 4 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if (now % 6 == 5)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }
            else if (now % 6 == 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                            break;
                        }
                    }
                }

                if (idx1 != 0)
                {
                    atk_check1 = idx1;
                    atk_check2 = idx2;
                }
            }

            if ( idx1 == 0 )
            {
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;

                now++;
                game();
            }
            
        }

        public void game()
        {
            if (now % 6 != 0 && now % 6 <= 3 ) label1.Text = "P1 TURN";
            else label1.Text = "P2 TURN";

            if (p1 == 0)
            {
                MessageBox.Show("P2 贏了");
                this.Close();

            }
            else if( p2 == 0 )
            {
                MessageBox.Show("P1 贏了");
                this.Close();
            }

            label5.Visible = true;
            label6.Visible = true;
            label5.Text = label6.Text = "";
            int idx1 = 0, idx2 = 0;
            if( now % 6 == 1 )
            {
                for(int i=1;i<=7;i++)
                {
                    for(int k=1;k<=3;k++)
                    {
                        if( a[i,k].Text == "戰士" )
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label3.Text = "P1\n戰士";
            }
            else if( now % 6 == 2 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label3.Text = "P1\n法師";
            }
            else if (now % 6 == 3)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label3.Text = "P1\n遊俠";
            }
            else if (now % 6 == 4)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "戰士")
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label4.Text = "P2\n戰士";
            }
            else if (now % 6 == 5 )
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "法師")
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label4.Text = "P2\n法師";
            }
            else if (now % 6 == 0)
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 4; k <= 6; k++)
                    {
                        if (a[i, k].Text == "遊俠")
                        {
                            idx1 = i;
                            idx2 = k;
                        }
                    }
                }

                label4.Text = "P2\n遊俠";
            }

            if (idx1 == 0 || idx2 == 0) return;

            if( label1.Text[1] == '1' )
            {
                label5.Text = "";
                label5.Text += "HP: " + info[idx1, idx2].hp + "\n";
                label5.Text += "MP: " + info[idx1, idx2].mp + "\n";
                label5.Text += "ATK: " + info[idx1, idx2].atk + "\n";
                label5.Text += "ATK Range: " + info[idx1, idx2].atkRange + "\n";
                label5.Text += "MOVE Range: " + info[idx1, idx2].moveRange + "\n";

                label6.Text = "";
            }
            else
            {
                label6.Text = "";
                label6.Text += "HP: " + info[idx1, idx2].hp + "\n";
                label6.Text += "MP: " + info[idx1, idx2].mp + "\n";
                label6.Text += "ATK: " + info[idx1, idx2].atk + "\n";
                label6.Text += "ATK Range: " + info[idx1, idx2].atkRange + "\n";
                label6.Text += "MOVE Range: " + info[idx1, idx2].moveRange + "\n";

                label5.Text = "";
            }
            
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled == false) return;

            if ( label1.Text[1] == '1' && time <= 0 )
            {
                prepare1();

                for (int i = 1; i <= 7; i++)
                {
                    for (int k = 1; k <= 3; k++) a[i, k].Enabled = false;
                    for (int k = 4; k <= 6; k++) a[i, k].Enabled = true;
                }

                label1.Text = "P2 準備階段";
                label2.Text = "0";

                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;


                return;
            }

            if (label1.Text[1] == '2' && time <= 0 )
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;

                prepare2();

                for(int i=1;i<=7;i++)
                {
                    for (int k = 1; k <= 6; k++) a[i, k].Enabled = true;
                }

                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;


                button16.Visible = true;
                button16.Enabled = false;
                label1.Text = "P1 TURN";
                time = 10;
                label2.Visible = false;
                game();

                timer1.Enabled = false;

                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "" + time;
        }
    }
}
