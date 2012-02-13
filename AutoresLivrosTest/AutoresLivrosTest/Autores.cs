using System;
using System.Globalization;
using System.Linq;

namespace AutoresLivrosTest
{
   public class Autores
   {
      public string getNomeFormatado(string Nome)
      {
         string primeironome = null, sobrenome = null;
         String[]  nomes = Nome.Split(' ');
         String [] preposicoes = new string[]{"de", "da", "das", "do", "dos"};
         String[] parentescos = new string[] { "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR"};

         if (nomes.Length == 1)
         {
            return Nome.ToUpper();
         }

         if (parentescos.Contains(nomes[nomes.Count() - 1].ToUpper()) && nomes.Length > 2)
         {
            sobrenome = nomes[nomes.Count() - 2].ToUpper() + " ";
         }
         else
         {
            sobrenome = nomes[nomes.Length - 1].ToUpper();
            for (int i = 0; i <= nomes.Length - 2; i++)
            {
               if (!preposicoes.Contains(nomes[i]))
               {
                  nomes[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomes[i]);
               }
               primeironome = primeironome + " " + nomes[i];
            }
            return sobrenome + "," + primeironome;
         }
         sobrenome = sobrenome + nomes[nomes.Count() - 1].ToUpper();
         return sobrenome + ", " +nomes[0];
      }

   }
}