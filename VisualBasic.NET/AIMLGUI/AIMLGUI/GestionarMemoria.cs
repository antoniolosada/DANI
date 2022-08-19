using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AIMLGUI
{
    class GestionarMemoria
    {
        private System.Drawing.Imaging.BitmapData bmpData;
        private IntPtr ptr;
        private int bytes;
        private int strideAux;

        /// <summary>
        /// Obtiene el ancho propio del Bitmap
        /// </summary>
        public int getStride
        {
            get
            {
                return strideAux;
            }

        }


        /// <summary>
        /// Bloquea el bitmap y devuelve un vector de bytes con los valores RGBA.
        /// </summary>
        /// <param name="bmp">Bitmap que se desea bloquear</param>
        /// <returns>Vector con los bytes de los colores RGBA</returns>
        public byte[] Bloquear(Bitmap bmp)
        {
            //Define una estructura de tipo Rectangle 
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            //Define bmpData para acceder a los datos del mapa de bits
            //y bloquea el mapa de bits
            bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            //Obtiene la dirección en memoria del mapa de bits
            ptr = bmpData.Scan0;
            //Declara un array de bytes
            //Este código es específico para un bitmap de 24 bits per pixels.
            bytes = bmpData.Stride * bmp.Height;
            strideAux = bmpData.Stride;
            byte[] rgbValues = new byte[bytes];
            //Copia los valores RGB en el array
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
            return rgbValues;
        }

        /// <summary>
        /// Desbloquea y copia los valores del mapa de bits
        /// </summary>
        /// <param name="rgbval">vector de bytes obtenido con la función bloquear</param>
        /// <param name="bmp">Bitmap bloqueado con la función bloquear</param>
        public void desbloquear(byte[] rgbval, Bitmap bmp)
        {
            //Copia el array en la dirección de memoria
            System.Runtime.InteropServices.Marshal.Copy(rgbval, 0, ptr, bytes);
            //Desbloquea el mapa de bits
            bmp.UnlockBits(bmpData);
        }


    }
}
