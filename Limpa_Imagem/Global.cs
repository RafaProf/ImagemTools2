using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Imagem
{
    public class Global
    {
        public static string nomeArquivo1, nomeArquivo2;
        public Bitmap img1, img2;
        public int contador1 = 0, contador2 = 0;
        public bool flag = true;

        public static List<string> listaImagens = new List<string>();
        public static List<string[]> listaPixels = new List<string[]>();  
        public static List <string> listaTamanho = new List<string>();
        public static List<string> resultGeralPasta = new List<string>();

        public static List<string> listaImagemColeta = new List<string>();

        public static string host, database, porta, usuario, senha;
        
        public static void LimparListas()
        {
            listaImagens.Clear();
            listaPixels.Clear();
            listaTamanho.Clear();
            resultGeralPasta.Clear();
            //listaImagemColeta.Clear();
        }
    }
}
