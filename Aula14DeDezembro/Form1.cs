using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula14DeDezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha) // Aqui e para saber se a senha é boa ou não 
            {
                int placar = geraPontosSenha(senha);    //int placar seria o pontos gerado pelas caracteres digitados
                                                        // ai o resultado dos placares somados define qual é sua resposta

                if (placar < 50)                        // IF = se placar <50 (um desvio condicional)
                    return ForcaDaSenha.Inaceitavel;    // return = seria a resposta do se
                else if (placar < 60)                   // ELSE IF = senao se
                    return ForcaDaSenha.Fraca;          // return = seria a resposta do senao se
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            InputSenha.Text = ""; // Essa linha ela apaga a senha digitada para você digitar novamente
            Menssagem1.Text = ""; // Essa liha apaga a resposta que o codigo te indica 
        }

        private void VerificarCaracter(object sender, KeyEventArgs e) // esse codigo foi gerado quando utilizamos a funcção KeyDown
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();//Essa linha ta utilizando uma variavel chamada "verifica" para checar o nivel da sua senha 
            ChecaForcaSenha.ForcaDaSenha forca;// Ja nessa linha esta usando a varial "forca" para exibir o nivel da sia senha 
            forca = verifica.GetForcaDaSenha(InputSenha.Text);//  Aqui é onde esta armazenando sua resposta baseada nas leras digitadas
            Menssagem1.Text=forca.ToString();//Aqui ele mostra qual respostas exibir devido as letras digitadas 
        }
    }
}
