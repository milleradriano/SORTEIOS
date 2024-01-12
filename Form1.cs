using System;
using System.Data;
using System.IO;
using OfficeOpenXml;
using System.Collections.Generic;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
namespace SORTEIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pressionaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                    SendKeys.Send("{TAB}");
                if (Convert.ToInt32(textItemLinha.Text) > 14)
                {
                    textItemLinha.Text = "14";

                }
            }   

        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            if (TodosCamposPreenchidos())

            {
                if (Convert.ToInt32(textItemLinha.Text) > 14)
                {
                    textItemLinha.Text = "14";

                }


                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls|Todos os Arquivos|*.*";
                int colFim = 0;
                /*LOTO MANIA - 30 - 20 SORTE
                MEGA SENA -10 - 6 SORTEADAS
                LOTO FACIL - 15 - 15 SORTEADAS
                */
                if (comboBox1.Text == "LOTO MANIA")
                {
                    colFim = 22;
                }
                if (comboBox1.Text == "MEGA SENA")
                {
                    colFim = 8;
                }
                if (comboBox1.Text == "LOTO FACIL")
                {
                    colFim = 17;
                }
                int qntRegistrosSorteados = Convert.ToInt32(textMaisSorteado.Text);
                try
                {
                    lblNumSorteados.Text = "";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string caminhoPlanilha = openFileDialog.FileName;
                        int valorMinimo = Convert.ToInt32(textValorMinimo.Text);
                        int valorMaximo = Convert.ToInt32(textValorMaximo.Text);

                        List<int> numerosMaisFrequentes = ObterNumerosMaisFrequentes(caminhoPlanilha, valorMinimo, valorMaximo, colFim);

                        if (numerosMaisFrequentes.Count > 0)
                        {
                            // Encontrar os números mais frequentes com a quantidade de repetições
                            var numerosFrequentes = EncontrarNumerosFrequentes(numerosMaisFrequentes);

                            // Exibir a contagem dos números mais frequentes
                            string mensagem = "Números mais frequentes e suas quantidades de repetição:\n";

                            /*
                            foreach (var numeroFrequente in numerosFrequentes.Take(qntRegistrosSorteados))
                            {

                                lblNumSorteados.Text += $"{numeroFrequente.Numero}: {numeroFrequente.Contagem}  ";

                            }
                            */
                         
                            int qntRegistros = qntRegistrosSorteados; // Defina a quantidade de registros conforme necessário
                            int itemLinha = Convert.ToInt32(textItemLinha.Text);
                            for (int i = 0; i < numerosFrequentes.Count && i < qntRegistros; i++)
                            {
                                lblNumSorteados.Text += $"{numerosFrequentes[i].Numero}: {numerosFrequentes[i].Contagem}";
                                if (i + 1 < qntRegistros)
                                {
                                    lblNumSorteados.Text += " - ";
                                }
                                // Adiciona uma quebra de linha a cada 10 registros
                                if ((i + 1) % itemLinha == 0 && i + 1 < qntRegistros)
                                {
                                    lblNumSorteados.Text += "\n";
                                }
                            }

                            //    MessageBox.Show(mensagem, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foram encontrados números dentro do intervalo especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }

        }

        static List<int> ObterNumerosMaisFrequentes(string caminhoPlanilha, int valorMinimo, int valorMaximo, int colFim)
        {
            List<int> numerosMaisFrequentes = new List<int>();

            try
            {

                using (var package = new ExcelPackage(new FileInfo(caminhoPlanilha)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                    {
                        string valorColunaAString = worksheet.Cells[row, 1].Text;

                        if (int.TryParse(valorColunaAString, out int valorColunaA))
                        {
                            if (valorColunaA >= valorMinimo && valorColunaA <= valorMaximo)
                            {
                                for (int col = 3; col <= colFim; col++)
                                {
                                    string valorCelulaString = worksheet.Cells[row, col].Text;

                                    if (int.TryParse(valorCelulaString, out int valorCelula))
                                    {
                                        numerosMaisFrequentes.Add(valorCelula);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"A célula ({row}, {col}) não contém um valor numérico.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"A célula ({row}, 1) não contém um valor numérico. Ignorando esta linha.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao processar a planilha: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return numerosMaisFrequentes;
        }

        static List<NumeroComContagem> EncontrarNumerosFrequentes(List<int> numeros)
        {
            // Utiliza LINQ para contar a frequência de cada número
            var contagemNumeros = numeros.GroupBy(x => x)
                                         .Select(g => new NumeroComContagem { Numero = g.Key, Contagem = g.Count() })
                                         .OrderByDescending(x => x.Contagem)
                                         .ToList();

            return contagemNumeros;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                textValorMinimo.Focus();
                string data, hora;
                data = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortDateString();
                hora = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToShortTimeString();
                this.Text = "Nº Sorteados - " + data + " " + hora;
                lblNumSorteados.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool TodosCamposPreenchidos()
        {
            return CamposPreenchidosNoGroupBox(groupBox1);
        }

        private bool CamposPreenchidosNoGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            return false;
                        }
                    }
                    else if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (string.IsNullOrWhiteSpace(comboBox1.Text))
                        {
                            return false;
                        }
                    }
                }
                // Adicione mais verificações para outros tipos de controles, se necessário
            }
            return true;
        }

       
    }



}

// Classe para armazenar número e sua contagem
public class NumeroComContagem
    {
        public int Numero { get; set; }
        public int Contagem { get; set; }
    }




