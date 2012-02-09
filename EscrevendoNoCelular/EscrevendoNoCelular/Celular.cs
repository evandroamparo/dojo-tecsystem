using System;
using System.Collections;
using System.Collections.Generic;

namespace EscrevendoNoCelular
{
   public class Celular
   {
      private List<string> letras = new List<string> { "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
      private string teclas = "";
      private string _mensagem;
      private int indiceTeclaAnterior = 0;

      public void SetMensagem(string s)
      {
         _mensagem = s;
      }

      public string GetTeclas()
      {
         for (int i = 0; i < _mensagem.Length; i++)
         {
            if (_mensagem[i] == ' ')
            {
               teclas += '0';
            }
            else
            {
               var tecla = letras.Find(l => l.Contains(_mensagem[i].ToString()));
               var indiceTecla = letras.IndexOf(tecla) + 2;
               var indiceLetra = tecla.IndexOf(_mensagem[i]) + 1;

               if (indiceTecla == indiceTeclaAnterior)
               {
                  teclas += '_';
               }
               indiceTeclaAnterior = indiceTecla;

               for (int j = 0; j < indiceLetra; j++)
               {
                  teclas += indiceTecla.ToString();
               }
            }
         }
         return teclas;
      }
   }
}