using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaDeTuring
{
    class maquina
    {
        Dictionary<string, string> palindromosDiccionarioEstados = new Dictionary<string, string>();
        Dictionary<string, string> copiaPatronesDiccionarioEstados = new Dictionary<string, string>();
        Dictionary<string, string> multiplicacionDiccionarioEstados = new Dictionary<string, string>();
        Dictionary<string, string> sumaDiccionarioEstados = new Dictionary<string, string>();
        Dictionary<string, string> restaDiccionarioEstados = new Dictionary<string, string>();


        //diccionarios
        //diccionario suma
        public void agregarDiccionarios() {
            palindromosDiccionarioEstados.Add("q0,1","1,1,R");
            palindromosDiccionarioEstados.Add("q0,+", "+,1,R");
            palindromosDiccionarioEstados.Add("q1,1", "1,1,R");
            palindromosDiccionarioEstados.Add("q1,+", "B,B,L");
            palindromosDiccionarioEstados.Add("q2,1", "1,B,R");

        }
    }
}
