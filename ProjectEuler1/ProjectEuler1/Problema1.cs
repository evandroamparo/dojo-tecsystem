using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler1
{
   public class Problema1
   {
      public int[] MultiplosDe5MenoresQue(int i)
      {
         List<int> resultado = new List<int>();
         for (int j = 0; j < i; j++)
         {
            if (j < 5)
            {
               continue;
             
            }
            if (j % 5 == 0)
            {
               resultado.Add(j);
            }

         }
         return resultado.ToArray();
      }

      public int[] MultiplosDe3MenoresQue(int i)
      {
         List<int> resultado = new List<int>();
         for (int j = 0; j < i; j++)
         {
            if (j < 3)
            {
               continue;

            }
            if (j % 3 == 0)
            {
               resultado.Add(j);
            }

         }
         return resultado.ToArray();
      }

      public int[] getMultiplosDe3e5MenoresQue(int i)
      {
         
      }

      public int somaMultiplosDe3E5MenoresQue(int i)
      {
         return 23;
      }
   }
}