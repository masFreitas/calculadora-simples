using System;

namespace calculadora_objeto
{
    public class Calculadora
    {
        // Somar (método)
        public int Somar (int n1, int n2)
        {
            return n1 + n2;
        }

        // Subtrair (método)
        public int Subtrair (int n1, int n2)
        {
            return n1 - n2;
        }
        // Multiplicar (método)
        public int Multiplicar (int n1, int n2)
        {
            return n1 * n2;
        }
        // Dividir (método)
        public int Dividir (int n1, int n2)
        {
            if (n2 == 0)
            {
                n2 = 1;
                Console.WriteLine("Erro: Não é permitido pela matemática a divisão por 0. Por segurança, eu dividi por 1.");
            }
            return n1 / n2;
        }
    }
}