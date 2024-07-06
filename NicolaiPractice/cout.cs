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
    public partial class cout : Form
    {
        public cout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Получаем текст из текстового поля
            string textToSave = textBox1.Text;

            // Определяем путь к файлу
            string filePath = "savedText.txt";

            try
            {
                // Записываем текст в файл
                File.WriteAllText(filePath, textToSave);
                MessageBox.Show("Текст успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Выводим сообщение об ошибке, если что-то пошло не так
                MessageBox.Show($"Произошла ошибка при сохранении текста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
