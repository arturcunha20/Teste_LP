using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public abstract class A
    {
        int x;
        int y;

        public A(int x, int y)
        {
            this.x = x * y;
            this.y = y;
        }

        public abstract int Calc(int x, int y);

        /// <summary>
        /// Verifica se dois objetos "A" são iguais. 
        /// Isso acontece quando o atributo "y" de cada objeto é igual.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return false;
            }
            else
            {
                A a = (A)obj;
                if (y == a.y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
    public class Essential : A, IB
    {
        string s;

        public Essential(int x, int y) : base(x, y)
        {
            this.s = y.ToString().ToLower();
        }

        /// <summary>
        /// Junta todas as strings existentes em "y", após colocar o prefixo "x" em           
        /// cada uma delas
        /// Exemplo:
        /// PrefixaAll(2,{"Lisboa","Porto"}) == "2Lisboa2Porto"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>   
        public string PrefixaAll(int x, params string[] y)
        {
            string a = null;

            foreach (string aa in y)
            {
                a = a + x.ToString() + aa;
            }
            return a;
        }
        public override int Calc(int x, int y)
        {
            return x * y;
        }

        public bool Equal(A x, A y)
        {
            return x == y;
        }
    }

    interface IB
    {
        /// <summary>
        /// Junta todas as strings existentes em "y", após colocar o prefixo "x" em 
        /// cada uma delas
        /// Exemplo:
        /// PrefixaAll(2,{"Lisboa","Porto"}) == "2Lisboa2Porto"
        /// </summary>
        string PrefixaAll(int x, params string[] y);

        /// <summary>
        /// Verifica se os dois objetos parametros são iguais
        /// </summary>
        bool Equal(A x, A y);
    }
}
