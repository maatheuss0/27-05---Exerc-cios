using System;

namespace Jogador.Class
{
    public class JOGADORDEFESA : Futebol
    {
        public string Aposentar()
        {
            if (idade < 40)
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