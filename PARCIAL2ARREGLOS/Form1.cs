using PARCIAL2ARREGLOS.ClaSes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL2ARREGLOS
{
    public partial class Form1 : Form
    {

        private string seccion;
        public string[,] matrices;
        ClsArreglos arreglo = new ClsArreglos();
        ClsPromedios promedios = new ClsPromedios();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivos ar= new ClsArchivos();
            this.listBoxContenido.Text = ar.abrirarchivo;

            string[] filas = ar.traerarchivo();
            int contador = 0;
            textBoxClasificar.Text = "Listo, el archivo se cargo en este momento!!!";


            foreach (string lineas in filas)
            {

                if (contador > 0)
                {
                    this.listBoxContenido.Items.Add(lineas);


                }
                contador++;

            }

            this.matrices = arreglo.Dimensiones(filas, 6); //aca se recorreran las 6 filas del archivo plano


        }

        private void buttonNombre_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio.Items.Clear();
            string[] datos = arreglo.MetodoBurbujaCadena(this.matrices, 1);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxPromedio.Items.Add(datos[i]);
            }
        }

        private void buttonPrimerParcial_Click(object sender, EventArgs e)
        {
            this.listBoxResultado.Items.Clear();
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxResultado.Items.Add(datos[i]);
               

            }
           
        }

        private void buttonSegundoParcial_Click(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxResultado.Items.Add(datos[i]);
                
            }
           
        }

        private void buttonTercerParcial_Click(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxResultado.Items.Add(datos[i]);
                
            }
           
        }

        private void buttonNombrePromedios_Click(object sender, EventArgs e)
        {
            this.listBoxResultado.Items.Clear();

            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                this.listBoxResultado.Items.Add(matrices[i, 1] + " - " + matrices[i, 5]);
            }
        }

        private void buttonPromedio1_Click(object sender, EventArgs e)
        {
            int datos = promedios.promedios_cada_parcial(this.matrices, 2);
            this.listBoxPromedio.Items.Add("Promedio 1: " + datos);
        }

        private void buttonPromedio2_Click(object sender, EventArgs e)
        {
            int datos = promedios.promedios_cada_parcial(this.matrices, 3);
            this.listBoxPromedio.Items.Add("Promedio 2 : " + datos);
        }

        private void buttonPromedio3_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio.Items.Clear();
            int datos = promedios.promedios_cada_parcial(this.matrices, 4);
            this.listBoxPromedio.Items.Add("Promedio 3: " + datos);
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio.Items.Clear();
            string[,] datos = promedios.suma_general_por_alumno(this.matrices);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listBoxPromedio.Items.Add(datos[i, 0] + "- Suma de todo es: " + datos[i, 1]);
            }
        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            this.comboBoxpromedio.Items.Clear();
            string seccion = comboBoxpromedio.Text;

            
            int datos = promedios.promedio_general_secciones(matrices, 5, seccion);
            listBoxPromedio.Items.Add(datos);
        }

        private void buttonp1_Click(object sender, EventArgs e)
        {
            this.comboBoxpromedio.Items.Clear();
            string seccion = comboBoxpromedio.Text;
            int datos = promedios.promedio_general_secciones(matrices, 2, seccion);
            listBoxPromedio.Items.Add(datos);

        }

        private void buttonp2_Click(object sender, EventArgs e)
        {
            this.comboBoxpromedio.Items.Clear();
          
            string seccion = comboBoxpromedio.Text;

            int datos = promedios.promedio_general_secciones(matrices, 3, seccion);
            listBoxPromedio.Items.Add(datos); ;
        }

        private void buttonp3_Click(object sender, EventArgs e)
        {
            this.comboBoxpromedio.Items.Clear();
            string seccion = comboBoxpromedio.Text;

            int datos = promedios.promedio_general_secciones(matrices, 4, seccion);
            listBoxPromedio.Items.Add(datos);
        }

        private void buttonClasificacion_Click(object sender, EventArgs e)
        {

            string seccion = comboBoxpromedio.Text;
            string[,] datos = promedios.Clasificacion_Alumnos(matrices, seccion);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                listBoxPromedio.Items.Add(datos[i, 0] + "; " + datos[i, 1] + "; " + datos[i, 2] + "; " + datos[i, 3] + "; " + datos[i, 4] + "; " + datos[i, 5] + "; ");
            }
        }

     

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            listBoxPromedio.Items.Clear();
          
           

        }
    }
}
