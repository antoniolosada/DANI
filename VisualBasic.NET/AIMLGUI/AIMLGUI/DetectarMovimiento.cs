using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace AIMLGUI
{
    public class DetectarMovimiento
    {
        private SubstraccionVideo objSubstraccion = new SubstraccionVideo();
        private Bitmap imagenAnterior;
        public int resolucionImagen { get; set; }
        private Graphics gr;

        public void webcam_CapturarMovimiento(PictureBox picture, Image image)
        {
            this.resolucionImagen = 300;
            if (this.imagenAnterior == null)
                this.imagenAnterior = new Bitmap(image);
            if (gr == null) gr = picture.CreateGraphics();

            //Calculamos la diferencia de imágenes
            picture.Image = objSubstraccion.substraer(new Bitmap(image, this.resolucionImagen, this.resolucionImagen),
                new Bitmap(this.imagenAnterior, this.resolucionImagen, this.resolucionImagen));
            //Almacenamos la imagen actual como imagen anterior
            this.imagenAnterior = new Bitmap(image);
            this.dibujarRecuadro(picture);
        }

        private void dibujarRecuadro(PictureBox picture)
        {
            Pen lapiz = new Pen(Color.Red);
            Font fuente = new Font("Arial", 8);
            Brush brocha = Brushes.Red;
            string texto;

            picture.Refresh();

            //Calculamos coeficientes de reducción ancho/alto y calculamos el centro de la imagen
            float coefX = ((float)picture.Width) / resolucionImagen;
            float coefY = ((float)picture.Height) / resolucionImagen;
            PointF centro = new PointF(((coefX * SubstraccionVideo.totalPixX) / SubstraccionVideo.totalPixeles),
                ((coefY * SubstraccionVideo.totalPixY) / SubstraccionVideo.totalPixeles));

            //Delimitamos área de movimiento
            gr.DrawRectangle(lapiz, coefX * SubstraccionVideo.minimoX, coefY * SubstraccionVideo.minimoY, coefX * (SubstraccionVideo.maximoX - SubstraccionVideo.minimoX),
               coefY * (SubstraccionVideo.maximoY - SubstraccionVideo.minimoY));

            //Dibujamos cruz en el centro
            gr.DrawLine(lapiz, new PointF(centro.X - 4, centro.Y), new PointF(centro.X + 4, centro.Y));
            gr.DrawLine(lapiz, new PointF(centro.X, centro.Y - 4), new PointF(centro.X, centro.Y + 4));

            //Escribimos texto con coordenadas
            if (SubstraccionVideo.minimoX != 1000 && SubstraccionVideo.minimoY != 1000)
            {
                texto = Convert.ToString(SubstraccionVideo.minimoX) + "," + Convert.ToString(SubstraccionVideo.minimoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.minimoX) - 15, (coefY * SubstraccionVideo.minimoY) - 15));

                texto = Convert.ToString(SubstraccionVideo.minimoX) + "," + Convert.ToString(SubstraccionVideo.maximoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.minimoX) - 15, (coefY * SubstraccionVideo.maximoY)));

                texto = Convert.ToString(SubstraccionVideo.maximoX) + "," + Convert.ToString(SubstraccionVideo.minimoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.maximoX) - 15, (coefY * SubstraccionVideo.minimoY) - 15));

                texto = Convert.ToString(SubstraccionVideo.maximoX) + "," + Convert.ToString(SubstraccionVideo.maximoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.maximoX) - 15, (coefY * SubstraccionVideo.maximoY)));
            }
        }
    }
}
