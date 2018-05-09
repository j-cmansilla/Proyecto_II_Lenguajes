using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            string queryGenerator = "";
            string[] lines = File.ReadAllLines("C:\\Users\\Jose Mansilla\\Documents\\2018\\Universidad\\Primer ciclo\\Bases de datos\\ProyectoBasesDeDatos\\ProyectoBasesDeDatos\\Inserts\\GruposEF.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] query = lines[i].Split(',');
                queryGenerator = queryGenerator + "INSERT INTO JUGADORES (IDJUGADOR,NOMBRE, APELLIDO, CAMISOLA, FK_SELECCION, FK_PUESTO, FK_CLUB) VALUES("+query[0]+",'"+query[1]+"','"+ query[2]+"',"+ query[3]+","+ query[4]+","+ query[5]+","+ query[6]+");"+System.Environment.NewLine;
                
            }
            string path = "C:\\Users\\Jose Mansilla\\Documents\\2018\\Universidad\\Primer ciclo\\Bases de datos\\ProyectoBasesDeDatos\\ProyectoBasesDeDatos\\Inserts\\InsertJugadoresChang.csv";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, queryGenerator);
            Console.WriteLine("Archivo generado exitosamente!");
            Console.ReadLine();
        }
    }
}
