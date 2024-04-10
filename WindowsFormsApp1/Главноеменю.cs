using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Главноеменю : Form
    {
        //Добавил в главное меню
        Настройки sett;
        public Главноеменю()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка изображения персонажа
            Bitmap bitmap = new Bitmap("path_to_character_image.jpg");
             
            // Отображение изображения в PictureBox
            pictureBox1.Image = bitmap;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            sett = new Настройки();
            sett.Show();
            Hide();
        }
    }
}
