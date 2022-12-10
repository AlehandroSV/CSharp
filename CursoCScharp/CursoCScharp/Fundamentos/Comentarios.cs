using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    public class Comentarios {
        public static void Executar() {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor");

            /// <summary>
            /// 
            /// </summary>
            Console.WriteLine("O C# tem o XML Comments");

            /*
             * Esse é um comentário
             * de múltiplas linhas...
             */
            Console.WriteLine("Comentários de multiplas linhas");
        }
    }
}
