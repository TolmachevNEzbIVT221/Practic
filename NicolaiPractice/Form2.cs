using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace NicolaiPractice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Путь к файлу
            string filePath = "savedText.txt"; // Замените на путь к вашему файлу

            try
            {
                // Чтение текста из файла
                string fileContent = File.ReadAllText(filePath);

                // Отображение текста в TextBox
                textBox1.Text = fileContent;
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке, если что-то пошло не так
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
