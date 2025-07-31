using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoTeste
{
    public partial class Form1 : Form
    {
        private string jogadorAtual = "X";
        int Xponto = 0, Oponto = 0, empate = 0;

        public Form1()
        {
            InitializeComponent();
            AtualizarMensagem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogar(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jogar(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jogar(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jogar(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jogar(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Jogar(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Jogar(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Jogar(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Jogar(button9);
        }


        private void Jogar(Button botao)
        {
            if (botao.Text == "")
            {
                botao.Text = jogadorAtual;

                if (VerificarVitoria())
                {
                    if (jogadorAtual == "X")
                    {
                        Xponto++;
                        Xpontos.Text = Xponto.ToString();
                        jogadorXO.Text = "X ganhou!";
                        MessageBox.Show("Jogador X ganhou!");
                    }
                        
                    else
                    {
                        Oponto++;
                        Opontos.Text = Oponto.ToString();
                        jogadorXO.Text = "O ganhou!";
                        MessageBox.Show("Jogador O ganhou!");
                    }
                    ResetarJogo();
                }

                else if (TodosBotoesPreenchidos())
                {
                    empate++;
                    empates.Text = empate.ToString();
                    jogadorXO.Text = "Empate!";
                    MessageBox.Show("Empate!");
                    ResetarJogo();
                }
                else
                {
                    jogadorAtual = jogadorAtual == "X" ? "O" : "X";
                    AtualizarMensagem();
                }
            }
        }

        private void AtualizarMensagem()
        {
            if (jogadorAtual == "X")
            {
                jogadorXO.Text = "Jogador X";
            }
            else
            {
                jogadorXO.Text = "Jogador O";
            }
            
        }


        private bool VerificarVitoria()
        {
            return (VerificarLinha(button1, button2, button3) || // Linhas
                    VerificarLinha(button4, button5, button6) ||
                    VerificarLinha(button7, button8, button9) ||
                    VerificarLinha(button1, button4, button7) || // Colunas
                    VerificarLinha(button2, button5, button8) ||
                    VerificarLinha(button3, button6, button9) ||
                    VerificarLinha(button1, button5, button9) || // Diagonais
                    VerificarLinha(button3, button5, button7));
        }

        private bool VerificarLinha(Button b1, Button b2, Button b3)
        {
            return b1.Text == jogadorAtual && b2.Text == jogadorAtual && b3.Text == jogadorAtual;
        }

        private bool TodosBotoesPreenchidos()
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                   button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                   button7.Text != "" && button8.Text != "" && button9.Text != "";
        }

        private void ResetarJogo()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            jogadorAtual = "X";
            jogadorXO.Text = "Jogador X";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Xponto = 0;
            Oponto = 0;
            empate = 0;

            Xpontos.Text = "0";
            Opontos.Text = "0";
            empates.Text = "0";

            ResetarJogo();
        }

    
    }
}
