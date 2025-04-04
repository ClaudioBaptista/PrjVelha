using System;

namespace PrjVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0; // Contador para as jogadas

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;
            jogadas++;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se alguém ganhou
            if (VerificarVitoria("X"))
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            else if (VerificarVitoria("O"))
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }
            else if (jogadas == 9) // Verificando se deu empate
            {
                DisplayAlert("Empate!", "O jogo terminou em empate!", "OK");
                Zerar();
            }
        }

        // Método para verificar se alguém ganhou
        bool VerificarVitoria(string jogador)
        {
            // Linhas
            if (btn10.Text == jogador && btn11.Text == jogador && btn12.Text == jogador) return true;
            if (btn20.Text == jogador && btn21.Text == jogador && btn22.Text == jogador) return true;
            if (btn30.Text == jogador && btn31.Text == jogador && btn32.Text == jogador) return true;

            // Colunas
            if (btn10.Text == jogador && btn20.Text == jogador && btn30.Text == jogador) return true;
            if (btn11.Text == jogador && btn21.Text == jogador && btn31.Text == jogador) return true;
            if (btn12.Text == jogador && btn22.Text == jogador && btn32.Text == jogador) return true;

            // Diagonais
            if (btn10.Text == jogador && btn21.Text == jogador && btn32.Text == jogador) return true;
            if (btn12.Text == jogador && btn21.Text == jogador && btn30.Text == jogador) return true;

            return false;
        }

        void Zerar()
        {
            // Limpa os botões
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            // Habilita os botões
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            // Reseta o contador de jogadas
            jogadas = 0;
        }
    }
}

