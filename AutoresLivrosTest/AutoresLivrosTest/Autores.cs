using System;
using System.Linq;

namespace AutoresLivrosTest
{
   public class Autores
   {
      public string getNomeFormatado(string Nome)
      {
         string primeironome = null, sobrenome = null;
         String[]  nomes = Nome.Split(' ');

         if (nomes.Length == 1)
         {
            return Nome.ToUpper();
         }

         //if (nomes.Count() == 2)
         //{
         //   sobrenome = (nomes[1]).ToUpper();
         //   primeironome = nomes[0];
         //}

         if (nomes[nomes.Count() - 1] == "Junior")
         {
            sobrenome = nomes[nomes.Count() - 2].ToUpper() + " ";
         }
         else
         {
            sobrenome = nomes[nomes.Length - 1];
            for (int i = 0; i < nomes.Length - 2; i++)
            {
               primeironome = primeironome + nomes[i];
            }
            return sobrenome + ", " + primeironome;
         }
         sobrenome = sobrenome + nomes[nomes.Count() - 1].ToUpper();
         return sobrenome + ", " +nomes[0];
      }

   }
}