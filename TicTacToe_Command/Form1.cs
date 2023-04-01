using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Command
{
    public partial class Form1 : Form
    {
        private int posX = 30;
        private int posY = 30;
        private int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Создает поле игры
        private void NewGame(object sender, System.EventArgs e)
        { 
            if(flag > 0)
            {
                for (int f = 10; f > 1; f--)
                {
                    this.Controls.RemoveAt(f);
                }
            }
            
            flag = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int x = posX + i * 110;
                    int y = posY + j * 110;
                    Button btn = new Button();
                    btn.Enabled = true;
                    btn.Size = new Size(100, 100);
                    btn.BackColor = Color.FromArgb(150, 0, 155, 0);
                    btn.Location = new Point(x, y);
                    btn.Font = new Font("Ubuntu", 60);
                    btn.Click += Btn_Click;
                    this.Controls.Add(btn);
                }
            }   
        }
        //ставит Х или О при нажатии на кнопку
        private void Btn_Click(object sender, EventArgs e)
        {
            if(flag%2 == 0)
            {
                (sender as Button).Text = "X";
            }
            else (sender as Button).Text = "O";
            flag++;
           (sender as Button).Enabled = false;
        }
    }
}
