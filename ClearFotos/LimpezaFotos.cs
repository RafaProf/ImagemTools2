using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestarDll
{
    public static class LimpezaFotos
    {

        public static Bitmap img1;
        public static int contador1 = 0, contador2 = 0;
        public static bool flag = true;
        public static FileInfo teste;

        public static void Limpar(string caminho, out int pixel, out double tamanho, out List<string> listaImagem)
        {
            // pixel = 0; tamanho = 0;
            string img1_ref;
            img1 = new Bitmap(caminho);
            flag = true;


            FileInfo fileinfo = new FileInfo(caminho);
            tamanho = fileinfo.Length;
            List<string> aux = new List<string>();



            if (flag == true)
            {
                for (int i = 0; i < img1.Width; i = i + 50)
                {
                    for (int j = 0; j < img1.Height; j = j + 50)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();

                        aux.Add(img1_ref);

                        //contador2++;
                        //flag = false;
                        //break;

                        contador1++;

                    }
                }

                if (flag == false)
                {
                    //diferentes - em desuso por hora..
                    pixel = contador1;
                    listaImagem = aux;
                    //return contador1;
                }
                else
                {
                    //iguais
                    pixel = contador1;
                    listaImagem = aux;
                    //return contador1;

                }
            }
            else
            {
                try
                {
                    pixel = contador1;
                    listaImagem = aux;
                    //return 0;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            img1.Dispose();
        }

    }
}



/*
 
 Task task = new Task(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("x");
                }
            });
            task.Start();
            task.Wait();*/