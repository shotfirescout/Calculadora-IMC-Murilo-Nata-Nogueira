using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {

        private double altura, peso, resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void efetuarIMC()
        {
            altura *= altura;
            resultado = peso / altura;
            resultadoImcText.Text = resultado.ToString("n2", new System.Globalization.CultureInfo("pt-BR"));
            condicaoExibir(resultado);
        }

        private void condicaoExibir(double resultadoIMC)
        {
            if (resultadoIMC < 18.5)
            {
                resultadoCondicao.Text = "Abaixo do Peso";
            } else if(resultadoIMC >= 18.5 && resultadoIMC < 24.9)
            {
                resultadoCondicao.Text = "Peso Normal";
            } else if(resultadoIMC >= 24.9 && resultadoIMC < 29.9)
            {
                resultadoCondicao.Text = "Sobre Peso";
            } else
            {
                resultadoCondicao.Text = "Obesidade";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resultadoCondicao.Text = String.Empty;
            resultadoImcText.Text = "0,00";
            textAltura.Text = String.Empty;
            textPeso.Text = String.Empty;
        }

        private void verificarCampos()
        {
            bool campoInvalido = false;
            if(!double.TryParse(textAltura.Text, out altura) || textAltura.Text.Contains("."))
            {
                MessageBox.Show("Campo inválido para altura, coloque um número decimal positivo usando a vírgula");
                campoInvalido = true;
            }
            else
            {
                if(altura < 0)
                {
                    MessageBox.Show("Campo inválido para altura, coloque um número decimal positivo usando a vírgula");
                    campoInvalido = true;
                }
            }

            if(!double.TryParse(textPeso.Text, out peso) || textPeso.Text.Contains("."))
            {
                MessageBox.Show("Campo inváloido para peso, coloque um número decimal positivo usando a vírgula");
                campoInvalido = true;
            } else
            {
                if(peso < 0)
                {
                    MessageBox.Show("Campo inváloido para peso, coloque um número decimal positivo usando a vírgula");
                    campoInvalido = true;
                }
            }

            if(campoInvalido == false)
            {
                efetuarIMC();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            verificarCampos();
        }
    }
}
