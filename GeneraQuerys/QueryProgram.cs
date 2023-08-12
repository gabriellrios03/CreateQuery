using System;
using System.IO;
using System.Diagnostics;

namespace GeneraQuerys
{
    class Program
    {
        static void Main()
        {
            // Ruta de la carpeta que contiene los archivos de folios
            string folderPath = @"C:\Users\azamarripag\OneDrive - H3 Consulting S.de R.L.de C.V\Documentos\BaseDocumetno\BaseTxt";

            // Obtener la lista de archivos en la carpeta
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            if (files.Length == 0)
            {
                Console.WriteLine("No se encontraron archivos de folios en la carpeta especificada.");
                Console.ReadKey();
                return;
            }

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string resultFilePath = Path.Combine(@"C:\Users\azamarripag\OneDrive - H3 Consulting S.de R.L.de C.V\Documentos\BaseDocumetno\Resultados", $"resultado_{fileName}.sql");

                // Carga los folios desde el archivo de texto
                string[] folios = File.ReadAllLines(filePath);

                // Genera las consultas y guarda los resultados en un archivo .sql
                using (StreamWriter file = new StreamWriter(resultFilePath))
                {
                    file.WriteLine("Use XposStore");
                    file.WriteLine("DECLARE @TEMP AS  TABLE (IT_FOL varchar (100), MSG varchar(10))");
                    {
                        
                    }
                    foreach (string folio in folios)
                    {
                        string queryCreado = $"DECLARE @{folio} varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('{folio}')) BEGIN SELECT @{folio}='NO EXISTE' END ELSE BEGIN SELECT @{folio}='EXISTE' END INSERT INTO @TEMP VALUES ('{folio}',@{folio})";
                        file.WriteLine(queryCreado);
                    }
                    file.WriteLine("SELECT * FROM @TEMP");                
                }

                Console.WriteLine($"Se ha generado el archivo de resultados para el archivo '{fileName}.txt'.");
            }

            Console.WriteLine("Proceso finalizado. Se han generado los archivos de resultados en formato .sql.");
            Console.ReadKey();

            // Abrir la carpeta de resultados
            string resultsFolderPath = @"C:\Users\azamarripag\OneDrive - H3 Consulting S.de R.L.de C.V\Documentos\BaseDocumetno\Resultados";
            Process.Start("explorer.exe", resultsFolderPath);
        }
    }
}
