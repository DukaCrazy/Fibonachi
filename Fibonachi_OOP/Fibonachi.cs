using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_OOP {
    internal class Fibonachi {

        public int FirstValor;
        public int SecondValor;
        public int Result;
        public void ResultC(int resultc) {
           resultc = FirstValor + SecondValor;
            Result = resultc;
        }
        public int MenorQueX;
        public override string ToString()
        {
            return "O maior numero de Fibonachi menor que "
                + MenorQueX 
                + " é: "
                +SecondValor.ToString();
        }
    }
    
}
