﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper()
                .Insert(3, " Word!")
                .Replace("Word", "Mundo");

            Console.WriteLine(saudacao);
        }
    }
}