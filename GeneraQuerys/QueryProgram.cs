using System;
using System.IO;

namespace GeneraQuerys
{
    class Program
    {
        static void Main()
        {

            //Pido al Usuario que Ingrese la ruta del archivo de texto considerando la ruta predeterminada del programa

            Console.WriteLine("Escribe Aqui el nombre de tu archivo:");

            string filePathUser = Console.ReadLine();

            // Ruta del archivo de folios
            string filePath = $@"C:\Users\Gabriel\Downloads\Dev\Bases\{filePathUser}.txt";

            // Ruta del archivo de resultados
            string resultFilePath = $@"C:\Users\Gabriel\Downloads\Dev\Results\resultado_{filePathUser}.txt";

            // Carga los folios desde el archivo de texto
            string[] folios = File.ReadAllLines(filePath);

            // Genera las consultas y guarda los resultados en un archivo de texto
            using (StreamWriter file = new StreamWriter(resultFilePath))
            {
                foreach (string folio in folios)
                {
                    string queryCreado = $"DECLARE @{folio} varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('{folio}')) BEGIN SELECT @{folio}='NO EXISTE' END ELSE BEGIN SELECT @{folio}='EXISTE' END INSERT INTO @TEMP VALUES ('{folio}',@{folio})";
                    file.WriteLine(queryCreado);
                }
            }

            Console.WriteLine("Proceso finalizado. Se ha generado el archivo de resultados.");

            Console.ReadKey();
        }
    }
}
