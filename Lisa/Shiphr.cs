using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisa
{
    public partial class Shiphr : Form
    {
        public Shiphr()
        {
            InitializeComponent();
        }
        public class EncDecRYPTOR
        {
            public string Encypt(string row, string col, string mes)
            {
                int rows, cols;
                try
                {
                     rows = int.Parse(row);
                     cols = int.Parse(col);
                }
                catch (Exception)
                {
                    throw;
                }
                char[,] table = new char[rows, cols];
                char[] razbienie = mes.ToCharArray();
                char[] resultedMessage = new char[rows * cols];
                int k = 0;
                
                for (int i = 0; i < rows; i++)     //запись в таблицу
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (k >= razbienie.Length)
                        {
                            table[i, j] = ' ';  //заполнение пустых ячеек
                        }
                        else
                        {
                            table[i, j] = razbienie[k];
                        }
                        k++;
                    }
                }
                k = 0;
                for (int d = cols - 1; d >= 0; d--)       //чтение из таблицы
                {
                    for (int c = 0; c < rows; c++)
                    {
                        resultedMessage[k] = table[c, d];
                        k++;
                    }
                }
                string answer = "";
                for (int z = 0; z < k; z++)
                {
                   answer += resultedMessage[z].ToString();
                }
                return answer;
            }
            public string Decrypt(string row, string col, string mes)
            {
                int rows, cols;
                try
                {
                    rows = int.Parse(row);
                    cols = int.Parse(col);
                }
                catch (Exception)
                {
                    throw;
                }
                char[,] table = new char[rows, cols];
                char[] razbienie = mes.ToCharArray();
                char[] resultedMessage = new char[rows * cols];
                int k = 0;
                for (int d = cols - 1; d >= 0; d--)
                {
                    for (int c = 0; c < rows; c++)
                    {
                        if (k >= razbienie.Length)
                        {
                            table[c, d] = ' ';
                        }
                        else
                        {
                            table[c, d] = razbienie[k];
                        }
                        k++;
                    }
                }
                k = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        resultedMessage[k] = table[i, j];
                        k++;
                    }
                }
                string answer = "";
                for (int z = 0; z < k; z++)
                {
                    answer += resultedMessage[z].ToString();
                }
                return answer;
            }
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncDecRYPTOR makeEnc = new EncDecRYPTOR();
            ResultedString.Text = makeEnc.Encypt(SizeTableLeft.Text, SizeTableRight.Text, EnteredMessage.Text);
        }

        private void DeCryptButton_Click(object sender, EventArgs e)
        {
            EncDecRYPTOR makeEnc = new EncDecRYPTOR();
                ResultedString.Text= makeEnc.Decrypt(SizeTableLeft.Text, SizeTableRight.Text, ResultedString.Text);
        }

        private void WriteToFile_Click(object sender, EventArgs e)
        {
            string somepath = @"C:\Users\megaf\OneDrive\Рабочий стол\Encrypter.txt";
            string text = ResultedString.Text;
            using (StreamWriter sw = new StreamWriter(somepath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
    }
}
