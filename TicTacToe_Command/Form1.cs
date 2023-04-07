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
        private int posX = 10;
        private int posY = 10;
        private int flag = 0;
        private bool winner = false;
        private Button[,] board = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        // Создает поле игры
        private void NewGame(object sender, System.EventArgs e)
        {
            if (flag > 0)
            {
                for (int f = 8; f >= 0; f--)
                {
                    panel.Controls.RemoveAt(f);
                }
            }

            flag = 0;
            winner = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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
                    panel.Controls.Add(btn);
                    board[i, j] = btn;
                }   
            }
        }

        // Проверяет, есть ли победитель
        private void CheckForWinner()
        {
            // Проверяем горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Text != "" && board[i, 0].Text == board[i, 1].Text && board[i, 1].Text == board[i, 2].Text)
                {
                    winner = true;
                    board[i, 0].BackColor = board[i, 1].BackColor = board[i, 2].BackColor = Color.FromArgb(150, 0, 255, 0);
                }
            }

            // Проверяем вертикали
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i].Text != "" && board[0, i].Text == board[1, i].Text && board[1, i].Text == board[2, i].Text)
                {
                    winner = true;
                    board[0, i].BackColor = board[1, i].BackColor = board[2, i].BackColor = Color.FromArgb(150, 0, 255, 0);
                }
            }

            // Проверяем диагонали
            if (board[0, 0].Text != "" && board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text)
            {
                winner = true;
                board[0, 0].BackColor = board[1, 1].BackColor = board[2, 2].BackColor = Color.FromArgb(150, 0, 255, 0);
            }
            if (board[2, 0].Text != "" && board[2, 0].Text == board[1, 1].Text && board[1, 1].Text == board[0, 2].Text)
            {
                winner = true;
                board[2, 0].BackColor = board[1, 1].BackColor = board[0, 2].BackColor = Color.FromArgb(150, 0, 255, 0);
            }

            // Если есть победитель, блокируем все кнопки и выводим сообщение
            if (winner)
            {
                foreach (Button btn in board)
                {
                    btn.Enabled = false;
                }

                info.Text = ("Winner: " + (flag % 2 == 0 ? "O" : "X"));

            }
            // Если все кнопки заняты и нет победителя, выводим сообщение о ничьей
            else if (flag == 9)
            {
                info.Text = ("Draw!");
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

            CheckForWinner();
        }
    }
}