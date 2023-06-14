##Generador de SQL Query Masivo
En este repositorio se ecuentra un programa elabordo en .Net 6.0 el cual Ejecuta la creacion en un archivo de texto llamado `Resultado.txt` la creacion de querys con un listado de varibales segun un listado almacenado en un archivo `Folios.txt`

####Ejemplo📝

Se tiene el Query:

    DECLARE @50007131 varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('50007131')) BEGIN                 
	SELECT @50007131='NO EXISTE' END ELSE BEGIN SELECT @50007131='EXISTE' END INSERT INTO @TEMP VALUES ('50007131',@50007131)
En el cual se solicita crear por cada departamento el cual tiene un ID correspondiente segun un listado.

Ejemplo de listado:


    50007272
    50007222
    50007141
    50006506

Salida del programa:


    DECLARE @50007272 varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('50007272')) BEGIN SELECT @50007272='NO EXISTE' END ELSE BEGIN SELECT @50007272='EXISTE' END INSERT INTO @TEMP VALUES ('50007272',@50007272)
    DECLARE @50007222 varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('50007222')) BEGIN SELECT @50007222='NO EXISTE' END ELSE BEGIN SELECT @50007222='EXISTE' END INSERT INTO @TEMP VALUES ('50007222',@50007222)
    DECLARE @50007141 varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('50007141')) BEGIN SELECT @50007141='NO EXISTE' END ELSE BEGIN SELECT @50007141='EXISTE' END INSERT INTO @TEMP VALUES ('50007141',@50007141)
    DECLARE @50006506 varchar(10) IF NOT EXISTS (SELECT * FROM CO_PRM WHERE IT_FOL IN ('50006506')) BEGIN SELECT @50006506='NO EXISTE' END ELSE BEGIN SELECT @50006506='EXISTE' END INSERT INTO @TEMP VALUES ('50006506',@50006506)
    

####Instalacion y Uso 🧰

**Requisitos:**
- DotNet Core (En el proyecto se Utiliza la Version 6.0) [Descargar](https://dotnet.microsoft.com/es-es/download "Descargar")
- Terminal Para su Ejecución (Puedes utilizar la Integrada en un IDE) Terminal de Gitbash [Descargar](https://git-scm.com/downloadshttp:// "Descargar")
- IDE (Para editar el Codigo) Recomiendo Visual Studio Community 2022 [Descargar](https://visualstudio.microsoft.comhttp:// "Descargar")

Instalacion
- Una vez instalados todos los requisitos, descarga el codigo fuente [(Click Aqui)](https://Linkpendiente.com "(Click Aqui)")
- Remplaza los Parametros de las Rutas con los tuyos:
`String filePath` contedra la ruta de tu archivo `.txt` el cual contiene el listado de los folios. si quieres asegurarte que la ruta sea correcta puedes copiar direcatmente de tu navegador.
` string resultFilePath` contendra el resultado de la operacion es decir tus querys.

###Proximas Actualizaciónes
Estamos ante la Primera Version de este programa, se plantea mejorar en un %100 este proyecto para que pueda generar cualquier query de forma masiva.

Para mantenerse al tanto de las actualizaciones puedes dejar tu follow y seria de ayuda si puedes apoar este repositorio con una estrella ⭐️

