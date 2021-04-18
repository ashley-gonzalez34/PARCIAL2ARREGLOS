using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL2ARREGLOS.ClaSes
{
    class ClsArchivos
    {
        internal string abrirarchivo;

        public string abrirarchvio { get; private set; }
        public string[] columna { get; private set; }
        public ClsArchivos() //aca se  creo un constructor y es donde permite abrir el archivoo
        {
            this.Cargar();
        }
        private string Cargar()
        {
            OpenFileDialog ar = new OpenFileDialog();
            ar.Title = "Seleccione su Archivo Plano!";
            ar.InitialDirectory = @"C /Users/usuario/Desktop/archivoplano/ARCHIVO PLANO MODIFICADO.csv";
            ar.Filter = "Archivos CSV|*.csv";
            if (ar.ShowDialog() == DialogResult.OK)
            {
                this.abrirarchvio = ar.FileName;
            }
            return abrirarchvio;
        }
        public string[] traerarchivo()// aca se obtendran las filas del archivo que se cargo
        {
            string[] filas = File.ReadAllLines(abrirarchvio);//fila va hacer igual todas las lineas que estan en la ruta
            this.columna = filas;
            return filas;
            //en esta parte termina retornando las filas

        }
    }
}
