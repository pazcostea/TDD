using System;
using System.Collections.Generic;
using System.Text;
/*
 Una célula muerta con exactamente 3 células vecinas vivas "nace" (al turno siguiente estará viva).

Una célula viva con 2 ó 3 células vecinas vivas sigue viva, en otro caso muere o permanece muerta
(por "soledad" o "superpoblación").
     */

namespace JuegoVida
{
    public class Juego
    {
        int nCelulas;
        public bool sigueViva(bool estadoActual, int numCelulas)
        {
            bool state = estadoActual;
            if ((!estadoActual && numCelulas == 3) || (estadoActual && (numCelulas <= 1 || numCelulas >= 4)))
            {
                state = !state;
            }
            return state;
        }
    }
}
