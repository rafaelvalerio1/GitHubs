using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sExercicioJogoDaVelha
{
    public partial class Form1 : Form
    {
        public string jogadorAtual;
        public Form1()
        {
            InitializeComponent();

        }
        public string InverterJogador()
        {
            if(jogadorAtual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void Ganhar()
        {
            MessageBox.Show($"O jogador {jogadorAtual} ganhou a partida");
            Zerar();
        }
        public bool Verificar(string jogador_at)
        {
            if (btn1.Text == jogador_at && btn2.Text == jogador_at && btn3.Text == jogador_at)
            {
                Ganhar();
                return true;    
            }
            if (btn4.Text == jogador_at && btn5.Text == jogador_at && btn6.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn7.Text == jogador_at && btn8.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn1.Text == jogador_at && btn5.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn3.Text == jogador_at && btn5.Text == jogador_at && btn7.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn1.Text == jogador_at && btn4.Text == jogador_at && btn7.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn2.Text == jogador_at && btn5.Text == jogador_at && btn8.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (btn3.Text == jogador_at && btn6.Text == jogador_at && btn9.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            lbl2.Text = jogadorAtual;
            jogadorAtual = InverterJogador();
            return false;
        }
        public void Zerar()
        {
            btn1.Text = null;
            btn2.Text = null;
            btn3.Text = null;
            btn4.Text = null;
            btn5.Text = null;
            btn6.Text = null;
            btn7.Text = null;
            btn8.Text = null;
            btn9.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.Text == "")
            {
                btn1.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Zerar();
        }
    }
}
