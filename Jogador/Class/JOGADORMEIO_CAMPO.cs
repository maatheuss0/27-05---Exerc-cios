using System;

namespace Jogador.Class
{
    public class JOGADORMEIO_CAMPO : Futebol
    {
        public string Aposentar()
        {
            if (idade < 38)
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