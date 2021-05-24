using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDoTeste
{
    class EXEMPLO
    {
        //------------------------
        private int x;
        private string g;
        private int dinheiro;

        //------------------------
        public EXEMPLO(int x, string g,int dinheiro)
        {
            this.x = x;
            this.g = g;
            this.dinheiro = dinheiro;
        }
        public EXEMPLO(string g)
        {
            this.x = 999;
            this.g = g;
        }

        public EXEMPLO()
        {
            this.x = 999;
            this.g = "OLA";
        }

        //------------------------

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Dinheiro
        {
            get { return this.dinheiro; }
            set { this.dinheiro = value; }
        }

        public string G
        {
            get { return this.g; }
            set { this.g = value; }
        }

        public void levantar(int montante)
        {
            if(this.dinheiro >= montante)
            {
                this.dinheiro = this.dinheiro - montante;
            }
            else
            {
                Console.Write("Nao é possivel");
            }
        }
    }
}
