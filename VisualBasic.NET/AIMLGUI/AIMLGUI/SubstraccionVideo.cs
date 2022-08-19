using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AIMLGUI
{
    class SubstraccionVideo
    {

        private GestionarMemoria objMemoria1;
        private GestionarMemoria objMemoria2;
        private GestionarMemoria objMemoria3;
        private static int maxX, minX, maxY, minY, totalX, totalY, totalPix;

        public static byte umbralRojo { get; set; }
        public static byte umbralVerde { get; set; }
        public static byte umbralAzul { get; set; }
        public static bool imagenBN { get; set; }

        public static int maximoX {get { return maxX;}}
        public static int minimoX { get { return minX; } }
        public static int maximoY { get { return maxY; } }
        public static int minimoY { get { return minY; } }
        public static int totalPixX { get { return totalX; } }
        public static int totalPixY { get { return totalY; } }
        public static int totalPixeles { get { return totalPix; } }

        

        public SubstraccionVideo(byte umbral=35)
        {
            objMemoria1 = new GestionarMemoria();
            objMemoria2 = new GestionarMemoria();
            objMemoria3 = new GestionarMemoria();
            SubstraccionVideo.umbralAzul = umbral;
            SubstraccionVideo.umbralVerde = umbral;
            SubstraccionVideo.umbralRojo = umbral;
            imagenBN = true;
        }

        public Bitmap substraer(Bitmap bmpActual,Bitmap bmpAnterior)
        {

            Bitmap bmpAux = bmpActual.Clone(new Rectangle(0, 0, bmpActual.Width, bmpActual.Height), bmpActual.PixelFormat);
            byte[] rgbValues1 = objMemoria1.Bloquear(bmpActual);
            byte[] rgbValues2 = objMemoria2.Bloquear(bmpAnterior);
            byte[] rgbValues3 = objMemoria3.Bloquear(bmpAux);

            //Calculamos las diferencias entre las dos imágenes
            for (int i = 0; i < rgbValues1.Length-1; i+=4)
            {
                rgbValues3[i] =(byte) Math.Abs(rgbValues1[i] - rgbValues2[i]);
                rgbValues3[i + 1] = (byte)Math.Abs(rgbValues1[i + 1] - rgbValues2[i + 1]);
                rgbValues3[i+2] = (byte)Math.Abs(rgbValues1[i+2] - rgbValues2[i+2]);
            }

            int offset=0;
            int sumaMediaRojo = 0, sumaMediaVerde = 0, sumaMediaAzul = 0;

            //Aplicamos reducción de ruido con media 3 vecinos
            for (int i = 1; i < bmpActual.Width - 2; i++)
            {
                for (int j = 1; j < bmpActual.Height - 2; j++)
                {
                    sumaMediaRojo = 0; sumaMediaAzul = 0; sumaMediaVerde = 0;
                    for (int ii = -1; ii < 2; ii++)
                    {
                        for (int jj = -1; jj < 2; jj++)
                        {
                            offset = ((j + jj) * objMemoria1.getStride) + ((i + ii) * 4);
                            sumaMediaAzul += (rgbValues3[offset]);
                            sumaMediaVerde += (rgbValues3[offset + 1]);
                            sumaMediaRojo += (rgbValues3[offset + 1]);
                        }
                    }
                    offset = (j * objMemoria1.getStride) + (i * 4);
                    rgbValues3[offset] = (byte)(sumaMediaAzul / 9);
                    rgbValues3[offset + 1] = (byte)(sumaMediaVerde / 9);
                    rgbValues3[offset + 2] = (byte)(sumaMediaRojo / 9);

                }
            }

            int offX,offY=0;
            int anchoStride= objMemoria3.getStride;
            int fila=(rgbValues3.Length / anchoStride);
            
            totalPix=0; totalX = 0; totalY = 0;
            minX = 1000; minY = 1000; maxX = 0; maxY = 0;

            //Comparamos con los umbrales y calculamos mínimos y máximos
            for (int i = 0; i < rgbValues3.Length - 1; i += 4)
            {
                if (rgbValues3[i] > SubstraccionVideo.umbralAzul && rgbValues3[i + 1] > SubstraccionVideo.umbralVerde && rgbValues3[i + 2] > SubstraccionVideo.umbralRojo)
                {
                   rgbValues3[i] = 255;
                    rgbValues3[i+1] = 255;
                    rgbValues3[i+2] = 255;
                    offX = (i % anchoStride) / 4;
                    offY = (i / fila) / 4;
                    maxX = (offX > maxX) ? offX : maxX;
                    maxY = (offY > maxY) ? offY : maxY;
                    minX = (offX < minX) ? offX : minX;
                    minY = (offY < minY) ? offY : minY;
                    totalX += offX;
                    totalY += offY;
                    totalPix++;
                   
                }
                else
                {
                    rgbValues3[i] = 0;
                    rgbValues3[i + 1] = 0;
                    rgbValues3[i + 2] = 0;
                    
                }
            }


            objMemoria1.desbloquear(rgbValues1, bmpActual);
            objMemoria2.desbloquear(rgbValues2, bmpAnterior);
            objMemoria3.desbloquear(rgbValues3, bmpAux);
            
            if (SubstraccionVideo.imagenBN == true) {
                return bmpAux;
            }
            else
            {
                return bmpActual;
            }
        
    }

}
}