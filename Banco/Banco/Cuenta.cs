using System;
using System.Collections.Generic;
using System.Text;
/* 
 Cree una clase Cuenta que almacena el saldo actual y proporciona los métodos getBalance para obtener el 
 saldo  y deposit para depositar fondos, withdraw para reitrar fondos y toString para devolver por pantalla
 el  saldo actual, además de al menos un constructor.
     */

namespace banco
{
    public class Cuenta
    {
        public int saldoActual { get; set; }

        //Obtiene el saldo
        public int getBalance()
        {
            throw new Exception("No implementado");
        }
        //Deposita fondos
        public int deposit(int ingresar)
        {
            throw new Exception("No implementado");
        }

        //Retira fondos
        public int withDraw(int retirar)
        {
            throw new Exception("No implementado");
        }

        //Devuelve por pantalla el saldo actual
        public override string ToString()
        {
            throw new Exception("No implementado");
        }       
    }
}
