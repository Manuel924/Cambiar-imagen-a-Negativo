using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revertir_BN_Imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Buscar una imagen.
            Bitmap bmp = new Bitmap("C:\\Users\\Manuel\\Pictures\\prueba.jpg"); //La ruta donde esta su imagen.

            //Cargar imagen.
            pictureBox1.Image = Image.FromFile("C:\\Users\\Manuel\\Pictures\\prueba.jpg");

            //Dimensionar imagen.
            int width = bmp.Width;
            int height = bmp.Height;

            //Convertir a color negativo.
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //Evualuar
                    Color p = bmp.GetPixel(x, y);

                    //Extraer los valores ARGB de P
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //Buscar valores negativos.
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //Colocar el nuevo ARGB.    
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            //Cargar la imagen negativa.
            pictureBox2.Image = bmp;

            //Guardar la imagen negativa.
            bmp.Save("C:\\Users\\Manuel\\Pictures\\prueba1.jpg"); //Ruta donde quieren guardar la imagen
        }
    }
}
