using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2ARREGLOS.ClaSes
{
    class ClsArreglos
    {
        

        public string[,] Dimensiones(string[] arreglo, int numerodelosdatos)  //su parametro es tipo string que es una cadena
        {
            
            string[,] arreglodosdimensiones = new string[arreglo.Length - 1, numerodelosdatos];
            int contador = 0;
            foreach (string fila in arreglo)
            {
                if (contador > 0)// la vaiable que se crea es de dos dimensiones
                {
                                                                     // en este caso el menos uno es para que no agarre el encabezado y las columnas son 6 por todas
                
                    string[] datos = fila.Split(',');//en mi caso para que me agarra los datos del archivo la funcion de split lo coloque con el signo de la "coma"

                    arreglodosdimensiones[contador - 1, 0] = datos[0]; //Correlativo
                    arreglodosdimensiones[contador - 1, 1] = datos[1]; //Nombre de los alumnos
                    arreglodosdimensiones[contador - 1, 2] = datos[2]; //Parcial1
                    arreglodosdimensiones[contador - 1, 3] = datos[3]; //Parcial2
                    arreglodosdimensiones[contador - 1, 4] = datos[4]; //ExamenFinal
                    arreglodosdimensiones[contador - 1, 5] = datos[5]; //Seccion

                  // int suma = Convert.ToInt32(datos[2]) + Convert.ToInt32(datos[3]) + Convert.ToInt32(datos[4]);
                   // int promedios = suma / 3;

                 //   arreglodosdimensiones[contador - 1, 6] = Convert.ToString(promedios);
                }
                contador++;


            }
            return arreglodosdimensiones;
        }




        public ClsArreglos()
        {

        }

        /// <summary>
        ///  Burbuja
        ///  intercambiar cada pareja consecutiva
        /// </summary>
        /// <returns></return

        public int[] MetodoBurbuja(string[,] matrices, int columna)//este metodo de burbuja crea un nuevo arreglo
        {


            int[] arreglo = new int[matrices.GetLength(0) - 1];
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                arreglo[i] = Convert.ToInt32(matrices[i, columna]);
            }


            int[] ArregloTemporal = arreglo;
            int datosTemporal;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = i + 1; j < arreglo.GetLength(0); j++)//lo que hace es ordenar el arreglo nuevo
                {

                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;

        }



        public string[] MetodoBurbujaCadena(string[,] matrices, int dato)//las filas cuentan con el -1 para que agarre bien los datos
        {
            string[] arreglo = new string[matrices.GetLength(0) - 1];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = matrices[i, dato];
            }

            string[] ArregloTemporal = arreglo;
            string datosTemporal;

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {

                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0) // en esta parte lo que hace es que ya con los datos ordenados se comparan 
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }
    }
}
