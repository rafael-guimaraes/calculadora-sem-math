/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 26/06/2023
 * Autores do Projeto: Rafael Augusto Guimarães da Silva
 *                     Gabriel Costa Fileno
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * problema_aula.cs
 * ************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVB_Projeto_2
{
    public partial class Form1 : Form
    {
        string texto = "0";
        string operador = "";
        string texto_aux = "";
        int tamanho = 0;
        double numero_anterior = 0;
        bool grau = false;
        int pos_virgula = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = texto;
        }
        private void botao_virgula_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto); 
            if (pos_virgula == 0 )
            {
                if (tamanho == 0)
                {
                    texto = "0,";
                    texto_aux = "0,";
                }
                else
                {
                    texto += ",";
                    texto_aux += ",";
                }
                    
                textBox1.Text = texto_aux;
                pos_virgula = ++tamanho;
            }
        }

        private void botao_zero_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
            {
                texto += "0";
                tamanho++;
                double n = double.Parse(texto);
                if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
                    textBox1.Text = texto;
                else
                {
                    if (pos_virgula == 0)
                    {
                        string texto_formatado = "";
                        bool negativo = false;
                        if (n < 0)
                        {
                            n *= -1;
                            negativo = true;
                        }
                        int cont = 0;
                        while (n >= 1)
                        {
                            if (cont % 3 == 0 && cont != 0)
                            {
                                texto_formatado = "." + texto_formatado;
                            }
                            double d = n % 10;
                            if (d >= 9)
                                d = 9;
                            else if (d >= 8)
                                d = 8;
                            else if (d >= 7)
                                d = 7;
                            else if (d >= 6)
                                d = 6;
                            else if (d >= 5)
                                d = 5;
                            else if (d >= 4)
                                d = 4;
                            else if (d >= 3)
                                d = 3;
                            else if (d >= 2)
                                d = 2;
                            else if (d >= 1)
                                d = 1;
                            else
                                d = 0;
                            n = n / 10 - (d / 10);
                            texto_formatado = d + texto_formatado;
                            cont++;
                        }
                        if (negativo)
                            texto_formatado = "-" + texto_formatado;
                        texto_aux = texto_formatado;
                        textBox1.Text = texto_formatado;
                    }
                    else
                    {
                        texto_aux += "0";
                        textBox1.Text = texto_aux;
                    }
                }
            }
            else
            {
                texto = "0";
                textBox1.Text = texto;
            }
        }      
            
           

        private void botao_um_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "1";
            else
                texto = "1";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "5";
                    textBox1.Text = texto_aux;
                }
            }
        }
        private void botao_dois_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "2";
            else
                texto = "2";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "2";
                    textBox1.Text = texto_aux;
                }
            }
        }
        private void botao_tres_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "3";
            else
                texto = "3";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "3";
                    textBox1.Text = texto_aux;
                }
            }
        }
        private void botao_quatro_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "4";
            else
                texto = "4";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "4";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_cinco_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "5";
            else
                texto = "5";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0)) {
                textBox1.Text = texto;
                texto_aux = texto;
            } else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "5";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_seis_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "6";
            else
                texto = "6";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "6";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_sete_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "7";
            else
                texto = "7";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "7";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_oito_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "8";
            else
                texto = "8";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "8";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_nove_Click(object sender, EventArgs e)
        {
            if (tamanho != 0)
                texto += "9";
            else
                texto = "9";
            tamanho++;
            double n = double.Parse(texto);
            if ((n < 1000 && n > 0) || (n > -1000 && n < 0))
            {
                textBox1.Text = texto;
                texto_aux = texto;
            }
            else
            {
                if (pos_virgula == 0)
                {
                    string texto_formatado = "";
                    bool negativo = false;
                    if (n < 0)
                    {
                        n *= -1;
                        negativo = true;
                    }
                    int cont = 0;
                    while (n >= 1)
                    {
                        if (cont % 3 == 0 && cont != 0)
                        {
                            texto_formatado = "." + texto_formatado;
                        }
                        double d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        n = n / 10 - (d / 10);
                        texto_formatado = d + texto_formatado;
                        cont++;
                    }
                    if (negativo)
                        texto_formatado = "-" + texto_formatado;
                    texto_aux = texto_formatado;
                    textBox1.Text = texto_formatado;
                }
                else
                {
                    texto_aux += "9";
                    textBox1.Text = texto_aux;
                }
            }
        }

        private void botao_voltar_Click(object sender, EventArgs e)
        {
            if (tamanho > 0)
            {
                double numero = double.Parse(texto);
                bool negativo = false;
                bool zero = false;
                if (numero < 0)
                {
                    numero *= -1;
                    tamanho--;
                    negativo = true;
                }
                if (numero < 1)
                    zero = true;

                string texto_formatado = "";
                int pos = 0;
                texto = "";
                if (pos_virgula != 0)
                {
                    int casas_decimais = tamanho - pos_virgula;
                    for (int i = 0; i < casas_decimais; i++)
                    {
                        numero *= 10;
                        pos++;
                    }
                }
                double virgula_contrario = (tamanho - pos_virgula + 1);


                for (int i = 1; i <= tamanho; i++)
                {
                    if (i == virgula_contrario)
                    {
                        if (i != 1)
                        {
                            texto_formatado = "," + texto_formatado;
                            texto = "," + texto;
                        }
                        else
                            pos_virgula = 0;

                    }
                    else if (i != 1)
                    {
                        if ((i - 2) % 3 == 0 && pos_virgula == 0 && (i - 2) != 0)
                            texto_formatado = "." + texto_formatado;
                        else if (i > virgula_contrario && (i - virgula_contrario - 1) % 3 == 0 && (i - virgula_contrario - 1) != 0)
                            texto_formatado = "." + texto_formatado;

                        double digito = numero % 10;
                        if (digito + 0.000001 >= 9)
                            digito = 9;
                        else if (digito + 0.000001 >= 8)
                            digito = 8;
                        else if (digito + 0.000001 >= 7)
                            digito = 7;
                        else if (digito + 0.000001 >= 6)
                            digito = 6;
                        else if (digito + 0.000001 >= 5)
                            digito = 5;
                        else if (digito + 0.000001 >= 4)
                            digito = 4;
                        else if (digito + 0.000001 >= 3)
                            digito = 3;
                        else if (digito + 0.000001 >= 2)
                            digito = 2;
                        else if (digito + 0.000001 >= 1)
                            digito = 1;
                        else
                            digito = 0;
                        texto_formatado = digito.ToString() + texto_formatado;
                        texto = digito.ToString() + texto;
                        numero = numero / 10 - digito / 10;

                    }
                    else
                    {
                        double digito = numero % 10;
                        numero = numero / 10 - digito / 10;
                    }
                }

                if (zero)
                {
                    texto_formatado = "0" + texto_formatado;
                    texto = "0" + texto;
                }
                if (texto_formatado == "")
                    texto_formatado = "0";
                if (negativo && texto_formatado != "0")
                {
                    tamanho++;
                    texto_formatado = "-" + texto_formatado;
                    texto = "-" + texto;
                }
                else if (negativo)
                    tamanho++;

                textBox1.Text = texto_formatado;
                tamanho--;
            }
            else
            {
                texto = "0";
                textBox1.Text = texto;
            }
        }

        private void botao_cancelar_Click(object sender, EventArgs e)
        {
            texto = "0";
            tamanho = 0;
            pos_virgula = 0;
            textBox1.Text = texto;
        }

        private void botao_limpar_Click(object sender, EventArgs e)
        {
            operador = "";
            texto = "0";
            tamanho = 0;
            pos_virgula = 0;
            numero_anterior = 0;
            textBox1.Text = texto;
        }

        private void botao_mais_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "mais";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "mais";
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }

        private void botao_menos_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "menos";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "menos";
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }

        private void botao_multiplicacao_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "multiplicacao";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "multiplicacao";
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }

        private void botao_divisao_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "divisao";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "divisao";

                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }
        private void botao_resto_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "resto";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "resto";
                double n = numero_anterior;
                bool num_negativo = false;
                bool zero = false;
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }
        private void botao_igual_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(textBox1.Text);
            int i = 0;
            switch (operador)
            {
                case "mais":
                    numero_anterior += numero;
                    break;
                case "menos":
                    numero_anterior -= numero;
                    break;
                case "divisao":
                    if (numero != 0)
                        numero_anterior /= numero;
                    else
                    {
                        numero_anterior = 0;
                        texto = "ERRO Matemático";
                    }
                    break;
                case "multiplicacao":
                    numero_anterior *= numero;
                    break;
                case "resto":
                    if (numero != 0)
                        numero_anterior %= numero;
                    else
                    {
                        numero_anterior = 0;
                        texto = "ERRO Matemático";
                    }
                    break;
                case "porcentagem":
                    numero_anterior = numero_anterior / 100 * numero;
                    break;
                case "potencia":
                    bool negativo = false;
                    double resultado = 1;
                    if (numero % 1 == 0)
                    {
                        if (numero < 0)
                        {
                            negativo = true;
                            numero *= -1;
                        }
                        for (i = 0; i < numero; i++)
                        {
                            resultado *= numero_anterior;
                        }
                        if (negativo)
                            resultado = 1 / resultado;
                        numero_anterior = resultado;
                    }
                    else
                    {
                        double ln = 0;
                        while (numero_anterior >= 1)
                        {
                            numero_anterior = numero_anterior / 2.71828182845904523;
                            ln++;
                        }
                        double potencia = numero_anterior - 1;

                        i = 1;
                        while (i <= 500)
                        {
                            if (i % 2 == 0)
                            {
                                ln -= potencia / i;
                            }
                            else
                            {
                                ln += potencia / i;
                            }
                            potencia *= (numero_anterior - 1);
                            i++;
                        }
                        double x = numero * ln;
                        if (x < 0)
                        {
                            negativo = true;
                            x *= -1;
                        }
                        double termo = 1;
                        resultado = 1;
                        i = 1;
                        while (termo > 0.0000000000001 && i <= 500)
                        {
                            termo *= x / i;
                            resultado += termo;
                            i++;
                        }
                        if (negativo)
                        resultado = 1 / resultado;
                        numero_anterior = resultado;
                    }
                    break;
                case "raiz":
                    if (numero_anterior != 0 && numero != 0)
                    {
                        double ln = 0;
                        while (numero >= 1)
                        {
                            numero = numero / 2.71828182845904523;
                            ln++;
                        }
                        double potencia = numero - 1;

                        i = 1;
                        while (i <= 500)
                        {
                            if (i % 2 == 0)
                                ln -= potencia / i;
                            else
                                ln += potencia / i;
                            potencia *= (numero - 1);
                            i++;
                        }
                        double x = 1.0 / numero_anterior * ln;
                        if (x < 0)
                        {
                            negativo = true;
                            x *= -1;
                        }
                        double termo = 1;
                        resultado = 1;
                        i = 1;
                        while (termo > 0.0000000000001 && i <= 500)
                        {
                            termo *= x / i;
                            resultado += termo;
                            i++;
                        }
                        numero_anterior = resultado;
                    }
                    else
                        texto = "ERRO Matemático";
                    break;

            }
            
            texto = numero_anterior.ToString();
            tamanho = 0;
            operador = "";
            pos_virgula = 0;
            if (numero_anterior < 1000)
            {
                textBox1.Text = texto;
            }
            else
            {
                double n = numero_anterior;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                i = 0;
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
            
        }

        private void botao_maismenos_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(textBox1.Text);
            if (numero < 0)
                tamanho--;
            else if (numero > 0)
                tamanho++;
            numero *= -1;
            texto = numero.ToString();

            double n = numero;
            bool num_negativo = false;
            bool zero = false;

            if (n < 0)
            {
                num_negativo = true;
                n *= -1;
            }

            if (n < 1)
                zero = true;

            string texto_formatado = "";
            int pos = 0;
            while (n % 1 > .00001)
            {
                n *= 10;
                pos++;
            }
            int i = 0;
            double d = 0;
            while (n >= 1)
            {
                if ((i - pos) % 3 == 0 && i > pos)
                    texto_formatado = "." + texto_formatado;
                d = n % 10;
                if (d >= 9)
                    d = 9;
                else if (d >= 8)
                    d = 8;
                else if (d >= 7)
                    d = 7;
                else if (d >= 6)
                    d = 6;
                else if (d >= 5)
                    d = 5;
                else if (d >= 4)
                    d = 4;
                else if (d >= 3)
                    d = 3;
                else if (d >= 2)
                    d = 2;
                else if (d >= 1)
                    d = 1;
                else
                    d = 0;
                texto_formatado = d.ToString() + texto_formatado;
                n = n / 10 - (d / 10);

                if (i == pos - 1)
                    texto_formatado = "," + texto_formatado;
                i++;
            }
            if (zero)
                texto_formatado = "0" + texto_formatado;

            if (num_negativo)
                texto_formatado = "-" + texto_formatado;

            textBox1.Text = texto_formatado;

        }

        private void botao_fatorial_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (numero % 1 == 0 && numero >= 0)
            {
                double resposta = 1;
                for (int x = 1; x <= numero; x++)
                    resposta *= x;
                texto = resposta.ToString();
                double n = numero;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                int i = 0;
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
            else if (numero % 1 != 0 || numero < 0)
            {
                texto = "ERRO Matemático";
                textBox1.Text = texto;
            }
            
            tamanho = 0;
            pos_virgula = 0;
        }

        private void botao_quadrado_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            numero *= numero;
            tamanho = 0;
            pos_virgula = 0;
            texto = numero.ToString();
            double n = numero;
            bool num_negativo = false;
            bool zero = false;

            if (n < 0)
            {
                num_negativo = true;
                n *= -1;
            }

            if (n < 1)
                zero = true;

            string texto_formatado = "";
            int pos = 0;
            while (n % 1 > .00001)
            {
                n *= 10;
                pos++;
            }
            int i = 0;
            double d = 0;
            while (n >= 1)
            {
                if ((i - pos) % 3 == 0 && i > pos)
                    texto_formatado = "." + texto_formatado;
                d = n % 10;
                if (d >= 9)
                    d = 9;
                else if (d >= 8)
                    d = 8;
                else if (d >= 7)
                    d = 7;
                else if (d >= 6)
                    d = 6;
                else if (d >= 5)
                    d = 5;
                else if (d >= 4)
                    d = 4;
                else if (d >= 3)
                    d = 3;
                else if (d >= 2)
                    d = 2;
                else if (d >= 1)
                    d = 1;
                else
                    d = 0;
                texto_formatado = d.ToString() + texto_formatado;
                n = n / 10 - (d / 10);

                if (i == pos - 1)
                    texto_formatado = "," + texto_formatado;
                i++;
            }
            if (zero)
                texto_formatado = "0" + texto_formatado;

            if (num_negativo)
                texto_formatado = "-" + texto_formatado;

            textBox1.Text = texto_formatado;
        }

        private void botao_cubo_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            numero *= numero * numero;
            tamanho = 0;
            pos_virgula = 0;
            texto = numero.ToString();
            double n = numero;
            bool num_negativo = false;
            bool zero = false;

            if (n < 0)
            {
                num_negativo = true;
                n *= -1;
            }

            if (n < 1)
                zero = true;

            string texto_formatado = "";
            int pos = 0;
            while (n % 1 > .00001)
            {
                n *= 10;
                pos++;
            }
            int i = 0;
            double d = 0;
            while (n >= 1)
            {
                if ((i - pos) % 3 == 0 && i > pos)
                    texto_formatado = "." + texto_formatado;
                d = n % 10;
                if (d >= 9)
                    d = 9;
                else if (d >= 8)
                    d = 8;
                else if (d >= 7)
                    d = 7;
                else if (d >= 6)
                    d = 6;
                else if (d >= 5)
                    d = 5;
                else if (d >= 4)
                    d = 4;
                else if (d >= 3)
                    d = 3;
                else if (d >= 2)
                    d = 2;
                else if (d >= 1)
                    d = 1;
                else
                    d = 0;
                texto_formatado = d.ToString() + texto_formatado;
                n = n / 10 - (d / 10);

                if (i == pos - 1)
                    texto_formatado = "," + texto_formatado;
                i++;
            }
            if (zero)
                texto_formatado = "0" + texto_formatado;

            if (num_negativo)
                texto_formatado = "-" + texto_formatado;

            textBox1.Text = texto_formatado;
        }

        private void botao_inverter_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (numero != 0)
            {
                numero = 1 / numero;
                texto = numero.ToString();
            }
            else
                texto = "ERRO Matemático";
            tamanho = 0;
            pos_virgula = 0;
            double n = numero;
            bool num_negativo = false;
            bool zero = false;

            if (n < 0)
            {
                num_negativo = true;
                n *= -1;
            }

            if (n < 1)
                zero = true;

            string texto_formatado = "";
            int pos = 0;
            while (n % 1 > .00001)
            {
                n *= 10;
                pos++;
            }
            int i = 0;
            double d = 0;
            while (n >= 1)
            {
                if ((i - pos) % 3 == 0 && i > pos)
                    texto_formatado = "." + texto_formatado;
                d = n % 10;
                if (d >= 9)
                    d = 9;
                else if (d >= 8)
                    d = 8;
                else if (d >= 7)
                    d = 7;
                else if (d >= 6)
                    d = 6;
                else if (d >= 5)
                    d = 5;
                else if (d >= 4)
                    d = 4;
                else if (d >= 3)
                    d = 3;
                else if (d >= 2)
                    d = 2;
                else if (d >= 1)
                    d = 1;
                else
                    d = 0;
                texto_formatado = d.ToString() + texto_formatado;
                n = n / 10 - (d / 10);

                if (i == pos - 1)
                    texto_formatado = "," + texto_formatado;
                i++;
            }
            if (zero)
                texto_formatado = "0" + texto_formatado;

            if (num_negativo)
                texto_formatado = "-" + texto_formatado;

            textBox1.Text = texto_formatado;
        }

        private void botao_notacao_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            double resultado = 1;
            bool negativo = false;
            int i = 0;
            if (numero % 1 == 0)
            {
                if (numero < 0)
                {
                    negativo = true;
                    numero *= -1;
                }
                for (i = 0; i < numero; i++)
                {
                    resultado *= 10;
                }
                if (negativo)
                    resultado = 1 / resultado;
            }
            else
            {
                double x = numero * 2.30258509299404568;
                double termo = 1.0;
                if (x < 0)
                {
                    negativo = true;
                    x *= -1;
                }
                for (i = 1; i < 300; i++)
                {
                    termo *= x / i;
                    resultado += termo;
                }
                if (negativo)
                    resultado = 1 / resultado;
                
            }
            numero = resultado;
            texto = resultado.ToString();
            tamanho = 0;
            pos_virgula = 0;
            if (resultado < 999)
            {
                textBox1.Text = texto;
            }
            else
            {
                double n = numero;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
            
        }

        private void botao_seno_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (grau)
                numero *= 3.14159265358979323 / 180;
            numero = numero % (2 * 3.14159265358979323);
            int i = 1;
            double atual = numero;
            double termo = 1;
            double fact = 1;
            double potencia = numero;
            while (termo > .0000000000001 && i < 200)
            {
                fact *= ((2 * i) * (2 * i + 1));
                potencia *= -1 * atual * atual;
                termo = potencia / fact;
                numero += termo;
                i++;
                if (termo < 0)
                    termo *= -1;
            }
            texto = numero.ToString();
            textBox1.Text = texto;
            tamanho = 0;
            pos_virgula = 0;
        }
        private void botao_cosseno_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (grau)
                numero *= 3.14159265358979323 / 180;
            numero = numero % (2 * 3.14159265358979323);
            int i = 1;
            double atual = 1;
            double termo = 1;
            double fact = 1;
            double potencia = 1;
            while (termo > .0000000000001 && i < 200)
            {
                fact *= ((2 * i - 1) * (2 * i));
                potencia *= -1 * numero * numero;
                termo = potencia / fact;
                atual += termo;
                i++;
                if (termo < 0)
                    termo *= -1;
            }
            texto = atual.ToString();
            textBox1.Text = texto;
        }

        private void botao_tangente_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (grau)
                numero *= 3.14159265358979323 / 180;
            numero = numero % (2 * 3.14159265358979323);

            int i = 1;
            double atual = numero;
            double termo = 1;
            double fact = 1;
            double potencia = numero;
            while (termo > .0000000000001 && i < 200)
            {
                fact *= ((2 * i) * (2 * i + 1));
                potencia *= -1 * numero * numero;
                termo = potencia / fact;
                atual += termo;
                i++;
                if (termo < 0)
                    termo *= -1;
            }
            double resultado = atual;
            i = 1;
            atual = 1;
            termo = 1;
            fact = 1;
            potencia = 1;
            while (termo > .0000000000001 && i < 200)
            {
                fact *= ((2 * i - 1) * (2 * i));
                potencia *= -1 * numero * numero;
                termo = potencia / fact;
                atual += termo;
                i++;
                if (termo < 0)
                    termo *= -1;
            }
            if (atual != 0) {
                resultado /= atual;
                numero = resultado;
                texto = numero.ToString();
            }
            else
            {
                numero = 0;
                texto = "ERRO Matemático";
            }
            tamanho = 0;
            pos_virgula = 0;

            double n = numero;
            bool num_negativo = false;
            bool zero = false;

            if (n < 0)
            {
                num_negativo = true;
                n *= -1;
            }

            if (n < 1)
                zero = true;

            string texto_formatado = "";
            int pos = 0;
            while (n % 1 > .00001)
            {
                n *= 10;
                pos++;
            }
            i = 0;
            double d = 0;
            while (n >= 1)
            {
                if ((i - pos) % 3 == 0 && i > pos)
                    texto_formatado = "." + texto_formatado;
                d = n % 10;
                if (d >= 9)
                    d = 9;
                else if (d >= 8)
                    d = 8;
                else if (d >= 7)
                    d = 7;
                else if (d >= 6)
                    d = 6;
                else if (d >= 5)
                    d = 5;
                else if (d >= 4)
                    d = 4;
                else if (d >= 3)
                    d = 3;
                else if (d >= 2)
                    d = 2;
                else if (d >= 1)
                    d = 1;
                else
                    d = 0;
                texto_formatado = d.ToString() + texto_formatado;
                n = n / 10 - (d / 10);

                if (i == pos - 1)
                    texto_formatado = "," + texto_formatado;
                i++;
            }
            if (zero)
                texto_formatado = "0" + texto_formatado;

            if (num_negativo)
                texto_formatado = "-" + texto_formatado;

            textBox1.Text = texto_formatado;
            
        }
        private void botao_trigonometria_Click(object sender, EventArgs e)
        {
            if (grau)
                botao_trigonometria.Text = "Grau";
            else
                botao_trigonometria.Text = "Rad"; 
             grau = !grau;
        }

        private void botao_pi_Click(object sender, EventArgs e)
        {
            
            texto = "3,141592";
            textBox1.Text = texto;
        }

        private void botao_log_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            double resultado = 0;
            while (numero >= 1)
            {
                numero = numero / 10;
                resultado++;
            }
            double ln = 0;
            double potencia = numero - 1;

            for (int i = 1; i <= 500; ++i)
            {
                if (i % 2 == 0)
                {
                    ln -= potencia / i;
                }
                else
                {
                    ln += potencia / i;
                }
                potencia *= (numero - 1);
            }
            resultado += ln / 2.30258509299404568;
            numero = resultado;
            texto = numero.ToString();
            tamanho = 0;
            pos_virgula = 0;
            if (numero < 999)
                textBox1.Text = texto;
            else
            {
                double n = numero;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                int i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
        }


        private void botao_porcentagem_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "porcentagem";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "porcentagem";
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }

        private void botao_raiz_quadrada_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            if (numero > 0)
            {
                double ln = 0;
                double multiplicador = 1;
                while (numero < 1)
                {
                    multiplicador *= 100;
                    numero *= multiplicador;
                }
                
                while (numero >= 1)
                {
                    numero = numero / 2.71828182845904523;
                    ln++;
                }
                double potencia = numero - 1;

                int i = 1;
                while (i <= 500) {
                    if (i % 2 == 0)
                    {
                        ln -= potencia / i;
                    }
                    else
                    {
                        ln += potencia / i;
                    }
                    potencia *= (numero - 1);
                    i++;
                }
                double x = 0.5 * ln;
                
                double termo = 1;
                double resultado = 1;
                i = 1;
                while (termo > 0.0000000000001 && i <= 500)
                {
                    termo *= x / i;
                    resultado += termo;
                    i++;
                }

                numero = resultado / multiplicador;

                texto = numero.ToString();
                if (numero < 1000)
                {
                    textBox1.Text = texto;
                }
                else
                {
                    double n = numero;
                    bool num_negativo = false;
                    bool zero = false;

                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
            else if (numero == 0)
            {
                numero = 0;
                texto = numero.ToString();
                textBox1.Text = texto;
            }
            else
            {
                texto = "ERRO Matemático";
                textBox1.Text = texto;
            }
                

            tamanho = 0;
            pos_virgula = 0;
            textBox1.Text = texto;

        }

        private void botao_raiz_cubica_Click(object sender, EventArgs e)
        {
            double numero = double.Parse(texto);
            int i = 0;
            if  (numero != 0)
            {
                double ln = 0;
                double multiplicador = 1;
                double negativo = 1;
                if (numero < 0)
                {
                    numero *= -1;
                    negativo *= -1;
                }
                while (numero < 1)
                {
                    multiplicador *= 1000;
                    numero *= multiplicador;
                }
                while (numero >= 1)
                {
                    numero = numero / 2.71828182845904523;
                    ln++;
                }
                double potencia = numero - 1;

                i = 1;
                while (i <= 500)
                {
                    if (i % 2 == 0)
                    {
                        ln -= potencia / i;
                    }
                    else
                    {
                        ln += potencia / i;
                    }
                    potencia *= (numero - 1);
                    i++;
                }
                
                double x = 1.0 / 3.0 * ln;
                
                double termo = 1;
                double resultado = 1;
                i = 1;
                while (termo > 0.0000000000001 && i <= 500)
                {
                    termo *= x / i;
                    resultado += termo;
                    i++;
                }
                if (multiplicador != 1)
                    numero = (resultado / (multiplicador / 100)) * negativo;
                else
                    numero = resultado * negativo;
                texto = numero.ToString();
            }else if (numero == 0)
            {
                numero = 0;
                texto = numero.ToString();
            }
            tamanho = 0;
            pos_virgula = 0;
            if (numero < 1000)
            {
                textBox1.Text = texto;
            }
            else
            {
                double n = numero;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
        }

        private void botao_potencia_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "potencia";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior != 0 && numero != 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "potencia";
                double n = numero_anterior;
                bool num_negativo = false;
                bool zero = false;

                if (n < 0)
                {
                    num_negativo = true;
                    n *= -1;
                }

                if (n < 1)
                    zero = true;

                string texto_formatado = "";
                i = 0;
                int pos = 0;
                while (n % 1 > .00001)
                {
                    n *= 10;
                    pos++;
                }
                i = 0;
                double d = 0;
                while (n >= 1)
                {
                    if ((i - pos) % 3 == 0 && i > pos)
                        texto_formatado = "." + texto_formatado;
                    d = n % 10;
                    if (d >= 9)
                        d = 9;
                    else if (d >= 8)
                        d = 8;
                    else if (d >= 7)
                        d = 7;
                    else if (d >= 6)
                        d = 6;
                    else if (d >= 5)
                        d = 5;
                    else if (d >= 4)
                        d = 4;
                    else if (d >= 3)
                        d = 3;
                    else if (d >= 2)
                        d = 2;
                    else if (d >= 1)
                        d = 1;
                    else
                        d = 0;
                    texto_formatado = d.ToString() + texto_formatado;
                    n = n / 10 - (d / 10);

                    if (i == pos - 1)
                        texto_formatado = "," + texto_formatado;
                    i++;
                }
                if (zero)
                    texto_formatado = "0" + texto_formatado;

                if (num_negativo)
                    texto_formatado = "-" + texto_formatado;

                textBox1.Text = texto_formatado;
            }
        }

        private void botao_raiz_Click(object sender, EventArgs e)
        {
            if (operador == "")
            {
                operador = "raiz";
                numero_anterior = double.Parse(texto);
                texto = "0";
                tamanho = 0;
                pos_virgula = 0;
                textBox1.Text = texto;
            }
            else
            {
                double numero = double.Parse(textBox1.Text);
                int i = 0;
                switch (operador)
                {
                    case "mais":
                        numero_anterior += numero;
                        break;
                    case "menos":
                        numero_anterior -= numero;
                        break;
                    case "divisao":
                        if (numero != 0)
                            numero_anterior /= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "multiplicacao":
                        numero_anterior *= numero;
                        break;
                    case "resto":
                        if (numero != 0)
                            numero_anterior %= numero;
                        else
                        {
                            numero_anterior = 0;
                            texto = "ERRO Matemático";
                        }
                        break;
                    case "porcentagem":
                        numero_anterior = numero_anterior / 100 * numero;
                        break;
                    case "potencia":
                        bool negativo = false;
                        double resultado = 1;
                        if (numero % 1 == 0)
                        {
                            if (numero < 0)
                            {
                                negativo = true;
                                numero *= -1;
                            }
                            for (i = 0; i < numero; i++)
                            {
                                resultado *= numero_anterior;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        else
                        {
                            double ln = 0;
                            while (numero_anterior >= 1)
                            {
                                numero_anterior = numero_anterior / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero_anterior - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                {
                                    ln -= potencia / i;
                                }
                                else
                                {
                                    ln += potencia / i;
                                }
                                potencia *= (numero_anterior - 1);
                                i++;
                            }
                            double x = numero * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 1;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.0000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            if (negativo)
                                resultado = 1 / resultado;
                            numero_anterior = resultado;
                        }
                        break;
                    case "raiz":
                        if (numero_anterior % 2 == 0 && numero < 0)
                        {
                            double ln = 0;
                            while (numero >= 1)
                            {
                                numero = numero / 2.71828182845904523;
                                ln++;
                            }
                            double potencia = numero - 1;

                            i = 1;
                            while (i <= 500)
                            {
                                if (i % 2 == 0)
                                    ln -= potencia / i;
                                else
                                    ln += potencia / i;
                                potencia *= (numero - 1);
                                i++;
                            }
                            double x = 1.0 / numero_anterior * ln;
                            if (x < 0)
                            {
                                negativo = true;
                                x *= -1;
                            }
                            double termo = 2;
                            resultado = 1;
                            i = 1;
                            while (termo > 0.000000000000001 && i <= 500)
                            {
                                termo *= x / i;
                                resultado += termo;
                                i++;
                            }
                            numero_anterior = resultado;
                        }
                        else
                            texto = "ERRO Matemático";
                        break;

                }

                texto = numero_anterior.ToString();
                tamanho = 0;
                pos_virgula = 0;
                operador = "raiz";
                if ((numero_anterior < 1000 && numero_anterior > 0) || (numero_anterior > -1000 && numero_anterior < 0))
                    textBox1.Text = texto;
                else
                {
                    double n = numero_anterior;
                    bool num_negativo = false;
                    bool zero = false;
                    if (n < 0)
                    {
                        num_negativo = true;
                        n *= -1;
                    }

                    if (n < 1)
                        zero = true;

                    string texto_formatado = "";
                    i = 0;
                    int pos = 0;
                    while (n % 1 > .00001)
                    {
                        n *= 10;
                        pos++;
                    }
                    i = 0;
                    double d = 0;
                    while (n >= 1)
                    {
                        if ((i - pos) % 3 == 0 && i > pos)
                            texto_formatado = "." + texto_formatado;
                        d = n % 10;
                        if (d >= 9)
                            d = 9;
                        else if (d >= 8)
                            d = 8;
                        else if (d >= 7)
                            d = 7;
                        else if (d >= 6)
                            d = 6;
                        else if (d >= 5)
                            d = 5;
                        else if (d >= 4)
                            d = 4;
                        else if (d >= 3)
                            d = 3;
                        else if (d >= 2)
                            d = 2;
                        else if (d >= 1)
                            d = 1;
                        else
                            d = 0;
                        texto_formatado = d.ToString() + texto_formatado;
                        n = n / 10 - (d / 10);

                        if (i == pos - 1)
                            texto_formatado = "," + texto_formatado;
                        i++;
                    }
                    if (zero)
                        texto_formatado = "0" + texto_formatado;

                    if (num_negativo)
                        texto_formatado = "-" + texto_formatado;

                    textBox1.Text = texto_formatado;
                }
            }
        }
    }
}
