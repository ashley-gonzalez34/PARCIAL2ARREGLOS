using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL2ARREGLOS.ClaSes
{
    interface InterfacePromedios
    {
        /// <summary>
        /// aparecera el promedio de  una columna que se este llamando
        /// </summary>
        /// <param name="matri"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        int promedios_cada_parcial(string[,] matrices, int columna_parcial);




        /// <summary>
        /// aparece el promedio de un parcial  y una seccion 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int Promedio_secciones(string[,] matrices, int columna_parcial, string secciones);


        /// <summary>
        /// saldra el promedio general de los alumnos clasificandolos por seccion .
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedio_general_secciones(string[,] matrices, int columna_parcial, string secciones);



        /// <summary>
        /// se manda la matriz principal y aparecera una matriz con los alumnos clasificados
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificacion_Alumnos(string[,] matrices, string secciones);


        /// <summary>
        /// aparecera  una matriz de las 2 columnas de nombre y la suma de las otras columnas del parcial 1,2 y 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string[,] suma_general_por_alumno(string[,] matrices);
    }
}
