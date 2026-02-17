using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button_Image_Click(object sender, EventArgs e)
        {
            // Создаём стандартное окно выбора картинки
            OpenFileDialog dialog = new OpenFileDialog();

            // Разрешаем выбирать только картинки
            dialog.Filter = "Картинки|*.jpg;*.png;*.bmp";

            // Показываем окно и проверяем, нажали ли "ОК"
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Загружаем выбранную картинку и ставим её фоном формы
                this.BackgroundImage = Image.FromFile(dialog.FileName);

                // Растягиваем картинку на весь экран
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}

