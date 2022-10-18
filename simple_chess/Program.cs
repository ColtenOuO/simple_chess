using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_chess
{

    class Chess
    {
        public string character;
        public int hp, mp, atk, atkRange, moveRange;

        public void init1()
        {
            hp = 100;
            mp = 15;
            atk = 30;
            atkRange = 1;
            moveRange = 2;
        }
        public void init2()
        {
            hp = 70;
            mp = 25;
            atk = 20;
            atkRange = 2;
            moveRange = 2;
        }
        public void init3()
        {
            hp = 90;
            mp = 10;
            atk = 30;
            atkRange = 3;
            moveRange = 1;
        }
    }
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
