using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquinaDeTuring
{
    public partial class Form1 : Form
    {
        string cadena;
        int cabezalMT = 0;
        int contadorPasos = 0;
        string[] transicionAuxSplit;
        //Definiciones de Maquinas
        // public maquinaDeTuring(string[] iEstado, string[] iSimboloEntrada, string[] iSimboloCinta, string iEstadoInicial, string iBlanco, string[] iEstadoFinal)
        maquinaDeTuring sumaUnaria = new maquinaDeTuring(new string[] { "q0", "q1", "q2", "q3" }, new string[] { "1", "+" }, new string[] { "1", "+", "B" }, "q0", "B", new string[] { "q3" });
        maquinaDeTuring copiaPatrones = new maquinaDeTuring(new string[] { "q0", "q1", "q2", "q3","q4", "q5", "q6", "q7", "q8", "q9", "q10", "q11" }, new string[] { "a", "b","c" }, new string[] { "a", "b", "c","x","B" }, "q0", "B", new string[] { "q7" });

        maquinaDeTuring palindromos = new maquinaDeTuring(new string[] { "q0", "q1", "q2", "q3", "q4", "q5", "q6", "q7" }, new string[] { "a", "b","c" }, new string[] { "a", "b", "c","B" }, "q0", "B", new string[] {"q0", "q2","q5","q7" });

        maquinaDeTuring multiplicacion = new maquinaDeTuring(new string[] { "q0", "q1", "q2", "q3", "q4", "q5", "q6", }, new string[] { "1", "*" }, new string[] { "1", "*", "=","B" }, "q0", "B", new string[] { "q6" });
        public Form1()
        {
            InitializeComponent();
            inicializarBotones();
            inicializarMaquinasTuring();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void volverVariablesACero() {
            cabezalMT = 0;
            contadorPasos = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Programar
            avanzar();
        }

        private void btnAvanzarAutomatico_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void inicializarBotones() {
            cbxSeleccionMT.DropDownStyle = ComboBoxStyle.DropDownList;
            lblIndicadorEstadoContador.Text = "";
            btnAvanzarAutomatico.Enabled = false;
            btnAvanzarPasoAPaso.Enabled = false;
        }

        private void inicializarMaquinasTuring() {
            //COPIAR PATRONES
            copiaPatrones.agregarTransicion("q0,a", "q1,B,R");
            copiaPatrones.agregarTransicion("q0,b", "q3,B,R");
            copiaPatrones.agregarTransicion("q0,c", "q5,B,R");
            copiaPatrones.agregarTransicion("q0,x", "q7,B,R");

            copiaPatrones.agregarTransicion("q1,a", "q1,a,R");
            copiaPatrones.agregarTransicion("q1,b", "q1,b,R");
            copiaPatrones.agregarTransicion("q1,c", "q1,c,R");
            copiaPatrones.agregarTransicion("q1,x", "q1,x,R");
            copiaPatrones.agregarTransicion("q1,B", "q2,a,L");

            copiaPatrones.agregarTransicion("q2,a", "q2,a,L");
            copiaPatrones.agregarTransicion("q2,b", "q2,b,L");
            copiaPatrones.agregarTransicion("q2,c", "q2,c,L");
            copiaPatrones.agregarTransicion("q2,x", "q2,x,L");
            copiaPatrones.agregarTransicion("q2,B", "q0,a,R");

            copiaPatrones.agregarTransicion("q3,a", "q3,a,R");
            copiaPatrones.agregarTransicion("q3,b", "q3,b,R");
            copiaPatrones.agregarTransicion("q3,c", "q3,c,R");
            copiaPatrones.agregarTransicion("q3,x", "q3,x,R");
            copiaPatrones.agregarTransicion("q3,B", "q4,b,L");

            copiaPatrones.agregarTransicion("q4,a", "q4,a,L");
            copiaPatrones.agregarTransicion("q4,b", "q4,b,L");
            copiaPatrones.agregarTransicion("q4,c", "q4,c,L");
            copiaPatrones.agregarTransicion("q4,x", "q4,x,L");
            copiaPatrones.agregarTransicion("q4,B", "q0,b,R");

            copiaPatrones.agregarTransicion("q5,a", "q5,a,R");
            copiaPatrones.agregarTransicion("q5,b", "q5,b,R");
            copiaPatrones.agregarTransicion("q5,c", "q5,c,R");
            copiaPatrones.agregarTransicion("q5,x", "q5,x,R");
            copiaPatrones.agregarTransicion("q5,B", "q6,c,L");

            copiaPatrones.agregarTransicion("q6,a", "q6,a,L");
            copiaPatrones.agregarTransicion("q6,b", "q6,b,L");
            copiaPatrones.agregarTransicion("q6,c", "q6,c,L");
            copiaPatrones.agregarTransicion("q6,x", "q6,x,L");
            copiaPatrones.agregarTransicion("q6,B", "q0,c,R");

            copiaPatrones.agregarTransicion("q7,a", "q8,B,L");
            copiaPatrones.agregarTransicion("q7,b", "q10,B,L");
            copiaPatrones.agregarTransicion("q7,c", "q11,B,L");

            copiaPatrones.agregarTransicion("q8,B", "q9,a,R");

            copiaPatrones.agregarTransicion("q9,B", "q7,B,R");

            copiaPatrones.agregarTransicion("q10,B", "q9,b,R");

            copiaPatrones.agregarTransicion("q11,B", "q9,c,R");

            //PALINDROMOS
            palindromos.agregarTransicion("q0,a", "q1,B,R");
            palindromos.agregarTransicion("q0,b", "q4,B,R");
            palindromos.agregarTransicion("q0,c", "q6,B,R");

            palindromos.agregarTransicion("q1,a", "q1,a,R");
            palindromos.agregarTransicion("q1,b", "q1,b,R");
            palindromos.agregarTransicion("q1,c", "q1,c,R");
            palindromos.agregarTransicion("q1,B", "q2,B,L");

            palindromos.agregarTransicion("q2,a", "q3,B,L");

            palindromos.agregarTransicion("q3,a", "q3,a,L");
            palindromos.agregarTransicion("q3,b", "q3,b,L");
            palindromos.agregarTransicion("q3,c", "q3,c,L");
            palindromos.agregarTransicion("q3,B", "q0,B,R");

            palindromos.agregarTransicion("q4,a", "q4,a,R");
            palindromos.agregarTransicion("q4,b", "q4,b,R");
            palindromos.agregarTransicion("q4,c", "q4,c,R");
            palindromos.agregarTransicion("q4,B", "q5,B,L");

            palindromos.agregarTransicion("q5,b", "q3,B,L");

            palindromos.agregarTransicion("q6,a", "q6,a,R");
            palindromos.agregarTransicion("q6,b", "q6,b,R");
            palindromos.agregarTransicion("q6,c", "q6,c,R");
            palindromos.agregarTransicion("q6,B", "q7,B,L");

            palindromos.agregarTransicion("q7,c", "q3,B,L");


            //SUMA UNARIA
            sumaUnaria.agregarTransicion("q0,1", "q0,1,R");
            sumaUnaria.agregarTransicion("q0,+", "q1,1,R");
            sumaUnaria.agregarTransicion("q1,1", "q1,1,R");
            sumaUnaria.agregarTransicion("q1,B", "q2,B,L");
            sumaUnaria.agregarTransicion("q2,1", "q3,B,R");

            //Multiplicacion Unaria
            multiplicacion.agregarTransicion("q0,1", "q1,B,R");
            multiplicacion.agregarTransicion("q0,*", "q6,*,R");

            multiplicacion.agregarTransicion("q1,1", "q1,1,R");
            multiplicacion.agregarTransicion("q1,*", "q2,*,R");

            multiplicacion.agregarTransicion("q2,1", "q3,B,R");
            multiplicacion.agregarTransicion("q2,=", "q5,=,L");

            multiplicacion.agregarTransicion("q3,1", "q3,1,R");
            multiplicacion.agregarTransicion("q3,=", "q3,=,R");
            multiplicacion.agregarTransicion("q3,B", "q4,1,L");

            multiplicacion.agregarTransicion("q4,1", "q4,1,L");
            multiplicacion.agregarTransicion("q4,=", "q4,=,L");
            multiplicacion.agregarTransicion("q4,B", "q2,1,R");

            multiplicacion.agregarTransicion("q5,1", "q5,1,L");
            multiplicacion.agregarTransicion("q5,*", "q5,*,L");
            multiplicacion.agregarTransicion("q5,B", "q0,1,R");
        }

        private void errorDeCadenaSimbolos() {
            MessageBox.Show("Hemos detectado que la cadena ingresada no comple con los simbolos de entrada o no esta ingresada correctamente");
        }

        private void agregarACinta() {
            cabezalMT = 0;
            contadorPasos = 0;
            dgvCintaMT.Columns.Clear();
            dgvCintaMT.Rows.Clear();
            dgvCintaMT.Refresh();
            for (int i = 0; i < cadena.Length; i++)
            {
                dgvCintaMT.Columns.Add(i.ToString(), i.ToString());
                dgvCintaMT[i, 0].Value = cadena[i];
            }
            dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.Yellow;
            dgvCintaMT.ReadOnly = true; //   
                   
        }

        private int dirreccion(string iDir) {
            if (iDir == "R")
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private void avanzar() {
            string seleccionMt = cbxSeleccionMT.Text;
            string simboloAux = "";
            string transicionAux = "";

            switch (seleccionMt)
            {
                case "Palindromos (a, b, c)":
                    simboloAux = dgvCintaMT[cabezalMT, 0].Value.ToString();
                    if (palindromos.siguienteEstado(simboloAux))
                    {
                        lblIndicadorEstadoContador.Text = "Estado: " + palindromos.obtenerEstadoActual() + " Contador Pasos: " + contadorPasos.ToString();
                        transicionAuxSplit = palindromos.obtenerTransicionActual().Split(',');
                        dgvCintaMT[cabezalMT, 0].Value = transicionAuxSplit[1];
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.White;
                        cabezalMT = cabezalMT + dirreccion(transicionAuxSplit[2]);
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.Yellow;
                        contadorPasos++;
                    }
                    else
                    {
                        if (palindromos.esEstadoFinal())
                        {
                            lblIndicadorEstadoContador.Text = "Cadena aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                        else
                        {
                            lblIndicadorEstadoContador.Text = "Cadena no aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                    }
                    break;

                case "Copiar Patrones (a, b, c)":
                    simboloAux = dgvCintaMT[cabezalMT, 0].Value.ToString();
                    if (copiaPatrones.siguienteEstado(simboloAux))
                    {
                        lblIndicadorEstadoContador.Text = "Estado: " + copiaPatrones.obtenerEstadoActual() + " Contador Pasos: " + contadorPasos.ToString();
                        transicionAuxSplit = copiaPatrones.obtenerTransicionActual().Split(',');
                        dgvCintaMT[cabezalMT, 0].Value = transicionAuxSplit[1];
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.White;
                        cabezalMT = cabezalMT + dirreccion(transicionAuxSplit[2]);
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.Yellow;
                        contadorPasos++;
                    }
                    else
                    {
                        if (copiaPatrones.esEstadoFinal())
                        {
                            lblIndicadorEstadoContador.Text = "Cadena aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                        else
                        {
                            lblIndicadorEstadoContador.Text = "Cadena no aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                    }
                    break;

                case "Multiplicaciones Codigo Unario":
                    simboloAux = dgvCintaMT[cabezalMT, 0].Value.ToString();
                    if (multiplicacion.siguienteEstado(simboloAux))
                    {
                        lblIndicadorEstadoContador.Text = "Estado: " + multiplicacion.obtenerEstadoActual() + " Contador Pasos: " + contadorPasos.ToString();
                        transicionAuxSplit = multiplicacion.obtenerTransicionActual().Split(',');
                        dgvCintaMT[cabezalMT, 0].Value = transicionAuxSplit[1];
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.White;
                        cabezalMT = cabezalMT + dirreccion(transicionAuxSplit[2]);
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.Yellow;
                        contadorPasos++;
                    }
                    else
                    {
                        if (multiplicacion.esEstadoFinal())
                        {
                            lblIndicadorEstadoContador.Text = "Cadena aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                        else
                        {
                            lblIndicadorEstadoContador.Text = "Cadena no aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                    }
                    break;

                case "Suma Codigo Unario":
                    simboloAux = dgvCintaMT[cabezalMT, 0].Value.ToString();
                    if (sumaUnaria.siguienteEstado(simboloAux))
                    {
                        lblIndicadorEstadoContador.Text = "Estado: " + sumaUnaria.obtenerEstadoActual() + " Contador Pasos: " + contadorPasos.ToString();
                        transicionAuxSplit = sumaUnaria.obtenerTransicionActual().Split(',');
                        dgvCintaMT[cabezalMT, 0].Value = transicionAuxSplit[1];
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.White;
                        cabezalMT = cabezalMT + dirreccion(transicionAuxSplit[2]);
                        dgvCintaMT.Rows[0].Cells[cabezalMT].Style.BackColor = Color.Yellow;
                        contadorPasos++;
                    }
                    else
                    {
                        if (sumaUnaria.esEstadoFinal())
                        {
                            lblIndicadorEstadoContador.Text = "Cadena aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }else
                        {
                            lblIndicadorEstadoContador.Text = "Cadena no aceptada, se realizo en: " + contadorPasos.ToString() + " pasos.";
                            btnAvanzarAutomatico.Enabled = false;
                            btnAvanzarPasoAPaso.Enabled = false;
                            timer1.Enabled = false;
                        }
                    }
                    
                    break;

                case "Resta Codigo Unario":
                    timer1.Enabled = false;
                    break;
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            volverVariablesACero();
            lblIndicadorEstadoContador.Text = "Estado: q0 Contador Pasos: 0";
            if (txtCadena.Text != "")
            {
                string seleccionMT = cbxSeleccionMT.Text;
                cadena = txtCadena.Text;
                //Palindromos(a, b, c)
                //Copiar Patrones (a, b, c)
                //Multiplicaciones Codigo Unario
                //Suma Codigo Unario
                //Resta Codigo Unario

                if (seleccionMT != "")
                {
                    switch (seleccionMT)
                    {
                        case "Palindromos (a, b, c)":
                            if (palindromos.verificarSimbolosEntrada(cadena))
                            {
                                cadena = txtCadena.Text + "BBBB";
                                palindromos.volverAEstadoCero();
                                btnAvanzarAutomatico.Enabled = true;
                                btnAvanzarPasoAPaso.Enabled = true;
                                agregarACinta();
                            }
                            else
                            {
                                errorDeCadenaSimbolos();
                            }
                            break;

                        case "Copiar Patrones (a, b, c)":
                            if (copiaPatrones.verificarSimbolosEntrada(cadena))
                            {
                                cadena = txtCadena.Text + "xBBBBBBBB";
                                copiaPatrones.volverAEstadoCero();
                                btnAvanzarAutomatico.Enabled = true;
                                btnAvanzarPasoAPaso.Enabled = true;
                                agregarACinta();
                            }
                            else
                            {
                                errorDeCadenaSimbolos();
                            }

                            break;

                        case "Multiplicaciones Codigo Unario":
                            if (multiplicacion.verificarSimbolosEntrada(cadena))
                            {
                                cadena = txtCadena.Text + "=BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB";
                                multiplicacion.volverAEstadoCero();
                                btnAvanzarAutomatico.Enabled = true;
                                btnAvanzarPasoAPaso.Enabled = true;
                                agregarACinta();
                            }
                            else
                            {
                                errorDeCadenaSimbolos();
                            }
                            break;

                        case "Suma Codigo Unario":
                            if (sumaUnaria.verificarSimbolosEntrada(cadena)&& IngresoBienSuma())
                            {
                                cadena = txtCadena.Text + "BBBBBBBB";
                                sumaUnaria.volverAEstadoCero();
                                btnAvanzarAutomatico.Enabled = true;
                                btnAvanzarPasoAPaso.Enabled = true;
                                agregarACinta();
                            }
                            else
                            {
                                errorDeCadenaSimbolos();
                            }
                            
                            break;

                        case "Resta Codigo Unario":
                            break;
                    }
                }
                else {
                    inicializarBotones();
                    MessageBox.Show("Hemos detectado que no ha seleccionado la Maquina de Turing deseada");
                }
            }
            else {
                inicializarBotones();
                MessageBox.Show("Hemos detectado que ha ingresado una cadena vacia, porfavor ingrese una cadena");
            }
        }

        //Comprobar que la suma venga de modo 1xxx-xxx1
        private bool IngresoBienSuma() {
            if ((cadena[0]=='1')&&(cadena[cadena.Length-1]=='1')&&(cadena.Contains("+")))
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void btnAvanzarPasoAPaso_Click(object sender, EventArgs e)
        {
            avanzar();
        }
    }
}
