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
        //Definiciones de Maquinas
        maquinaDeTuring sumaUnaria = new maquinaDeTuring(new string[] { "q0", "q1", "q2", "q3" }, new string[] { "1", "+" }, new string[] { "1", "+", "B" }, "q0", "B", new string[] { "q3" });
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Programar

        }

        private void btnAvanzarAutomatico_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void inicializarBotones() {
            lblIndicadorEstadoContador.Text = "";
            btnAvanzarAutomatico.Enabled = false;
            btnAvanzarPasoAPaso.Enabled = false;
        }

        private void inicializarMaquinasTuring() {
            //SUMA UNARIA
            sumaUnaria.agregarTransicion("q0,1", "q0,1,R");
            sumaUnaria.agregarTransicion("q0,+", "q1,1,R");
            sumaUnaria.agregarTransicion("q1,1", "q1,1,R");
            sumaUnaria.agregarTransicion("q1,B", "q2,B,L");
            sumaUnaria.agregarTransicion("q2,1", "q3,B,R");
        }

        private void errorDeCadenaSimbolos() {
            MessageBox.Show("Hemos detectado que la cadena ingresada no comple con los simbolos de entrada de la Maquina de Turing seleccionada");
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

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
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
                        case "Palindromos(a, b, c)":
                            break;

                        case "Copiar Patrones (a, b, c)":
                            break;

                        case "Multiplicaciones Codigo Unario":
                            break;

                        case "Suma Codigo Unario":
                            if (sumaUnaria.verificarSimbolosEntrada(cadena))
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
    }
}
