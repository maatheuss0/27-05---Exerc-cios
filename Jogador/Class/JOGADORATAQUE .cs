using System;

namespace Jogador.Class
{
    public class JOGADORATAQUE : Futebol
    {
        public string Aposentar()
        {
            if (idade < 35)
            {
                return "Ainda está na idade permitida";
            }
            else 
            {
                return "Aposenta pae!";
            }
        }
    }
}