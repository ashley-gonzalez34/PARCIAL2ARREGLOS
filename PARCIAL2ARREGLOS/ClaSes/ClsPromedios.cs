using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2ARREGLOS.ClaSes
{
    class ClsPromedios : InterfacePromedios
    {
        public string[,] Clasificacion_Alumnos(string[,] matrices, string secciones)
        {
            int alumnosEnSeccion = 0;
            for (int i = 0; i < matrices.GetLength(0); i++) // el arreglo de dos dimensiones lo que hace es clasificar los alumnos
            {
                if (matrices[i, 5] == secciones)// aqui sale la matriz de la  seccion y la de columnaa
                {
                    alumnosEnSeccion++;
                }
            }
            string[,] datos = new string[alumnosEnSeccion, matrices.GetLength(1)];
            int NuevaMatriz = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)
                {
                    datos[NuevaMatriz, 0] = matrices[i, 0];
                    datos[NuevaMatriz, 1] = matrices[i, 1];
                    datos[NuevaMatriz, 2] = matrices[i, 2];
                    datos[NuevaMatriz, 3] = matrices[i, 3];
                    datos[NuevaMatriz, 4] = matrices[i, 4];
                    datos[NuevaMatriz, 5] = matrices[i, 5];
                   
                    NuevaMatriz++;
                }
            }
            return datos;
        }

        public int promedios_cada_parcial(string[,] matrices, int columna_parcial)
        {
            int acumulador = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                acumulador = acumulador + Convert.ToInt32(matrices[i, columna_parcial]);
            }

            int promedio = acumulador / matrices.GetLength(0);

            return promedio;
        }

        public int promedio_general_secciones(string[,] matrices, int columna_parcial, string secciones)
        {
            int suma = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)// la matriz fila es la i y la columna 5 es donde esta indicada la seccion del alumno del promedio general
                {
                    suma = suma + Convert.ToInt32(matrices[i, columna_parcial]);
                }
            }
            int promedio = suma / matrices.GetLength(0);
            return promedio;
        }

            public int Promedio_secciones(string[,] matrices, int columna_parcial, string secciones)
        {
            int suma = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            //lo que hace es crear un nuevo arreglo
            {
                if (matrices[i, 5] == secciones)
                {
                    suma = suma + Convert.ToInt32(matrices[i, columna_parcial]);
                }
            }
            int promedio = suma / matrices.GetLength(0);
            return promedio;
        }

        public string[,] suma_general_por_alumno(string[,] matrices)
        {
            string[,] datos = new string[matrices.GetLength(0), 2];
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                datos[i, 0] = matrices[i, 1];
                int suma = Convert.ToInt32(matrices[i, 2]) + Convert.ToInt32(matrices[i, 3]) + Convert.ToInt32(matrices[i, 4]);
                datos[i, 1] = Convert.ToString(suma);
            }
            return datos;
        }
    }
}
