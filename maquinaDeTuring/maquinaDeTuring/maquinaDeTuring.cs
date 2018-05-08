﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaDeTuring
{
    class maquinaDeTuring
    {
        //Variables 
        private string[] estadosMaquina;
        private string[] simboloEntrada;
        private string[] simboloCinta;
        private string estadoInicial;
        private string blanco;
        private string[] estadoFinal;
        private Dictionary<string, string> trancisiones;
        private string estadoActualMaquina;

        //Constructor
        public maquinaDeTuring(string[] iEstado, string[] iSimboloEntrada, string[] iSimboloCinta, string iEstadoInicial, string iBlanco, string[] iEstadoFinal) {
            estadosMaquina = iEstado;
            simboloEntrada = iSimboloEntrada;
            simboloCinta = iSimboloCinta;
            estadoInicial = iEstadoInicial;
            blanco = iBlanco;
            estadoFinal = iEstadoFinal;
        }

        //Agregar transiciones
        public void agregarTransicion(string iLlave, string iValor) {
            trancisiones.Add(iLlave, iValor);
        }

        //Obtener 
        public string obtenerTransicion(string iLlave) {
            string salida;
            trancisiones.TryGetValue(iLlave, out salida);
            return salida;
        }

        //Consultar
        public bool consultaTransicion(string iLlave) {
            return trancisiones.ContainsKey(iLlave);
        }

        //Verificar si estado es Final()
        public bool esEstadoFinal() {
            return estadoFinal.Contains(estadoActualMaquina);
        }

        //Obtener estado actual
        public string obtenerEstadoActual() {
            return estadoActualMaquina;
        }

        //Verificar que los simbolos de entrada pertenezcan a la maquina 
        public bool verificarSimbolosEntrada( string iCadena) {
            for (int i = 0; i < iCadena.Length; i++)
            {
                if (simboloEntrada.Contains(iCadena[i].ToString()))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            return true;
        }


    }
}
