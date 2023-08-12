<h1>Generador de SQL Query Masivo</h1>
En este repositorio se ecuentra un programa elabordo en .Net 6.0 el cual Ejecuta la creacion en un archivo de texto llamado `Resultado.txt` la creacion de querys con un listado de varibales segun un listado almacenado en un archivo `Folios.txt`

<h3>Ejemplo📝</h3>

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
    

<h4>Instalacion y Uso 🧰</h4>

**Requisitos:**
- DotNet Core (En el proyecto se Utiliza la Version 6.0) [Descargar](https://dotnet.microsoft.com/es-es/download "Descargar")
- Terminal Para su Ejecución (Puedes utilizar la Integrada en un IDE) Terminal de Gitbash [Descargar](https://git-scm.com/downloadshttp:// "Descargar")
- IDE (Para editar el Codigo) Recomiendo Visual Studio Community 2022 [Descargar](https://visualstudio.microsoft.comhttp:// "Descargar")

Instalacion
- Crea Tu carpeta de Recursos (bases y resultados) en el directorio de tu preferencia
  Formato Sugerido(Carpeta Principal con 2 Subcarpetas)
  C:/Ruta/CarpetaPrincipal/ -> CarpetaBase & CarpetaResults

- Crea Una Carpeta llamda Dev en tu Disco local (C: en lo general)
- Dentro de esa carpeta crea un proyecto de consola con dotnet llamda "generarQuery"
  `Dotnet new console -n generarQuery`
  Este comando creara una carpata con el mismo nombre del proyecto y un archivo llamado `Program.cs`
- Abre el arhcivo antes mecionado con ayuda de un IDE (Vscode, Notepad++, SublimeText3.....)
- Remplaza el codigo que contiene (Hello world!) por el codigo fuente
- Descarga el codigo fuente [(Click Aqui)](https://github.com/gabriellrios03/CreateQuery/tree/main/GeneraQuerys "(Click Aqui)")
- Remplaza los Parametros de las Rutas con los tuyos:
`String folderPath` contedra la ruta de tu archivo `.txt` el cual contiene el listado de los folios. si quieres asegurarte que la ruta sea correcta puedes copiar direcatmente de tu navegador.
`string resultFilePath` contendra el resultado de la operacion es decir tus querys.
`resultsFolderPath` Contendra la instruccion de abrir el folder de resultados, incluye la ruta nuevamente.


<h4>Ejecuccion Amigable 📱</h4>

**Componentes**

Los componentes son totalmente personalizables y librea a añadir funciones adicionales, los utilizados en este ejemplo se encuentran en el arhcivo [(Componentes)](https://github.com/gabriellrios03/CreateQuery/tree/main/Componentes "(Componentes)") de este reposirotrio

- Primer paso: En tu Carpeta Dev crea el siguiente arhivo .bat con ayuda de un IDE
```
@echo off
cd C:\Dev\generarQuery\
dotnet run
```
- Guardar archivo con el nombre que prefieras dentro de la carpeta Dev con extension `.bat`
- Click Derecho sobre el arhhivo .Bat generado -> Enviar a Escritorio (Como acceso Directo)
- Renombrar al gusto en escritorio Ej: `Generar Query`
- Click Derecho -> Propiedades -> Cambiar Icono -> Elegir Icono de la carpeta Componentes (Puedes elegir otro si gustas) 

<h3>Proximas Actualizaciónes</h3>
Estamos ante la Primera Version de este programa, se plantea mejorar en un 100% este proyecto para que pueda generar cualquier query de forma masiva.

Para mantenerse al tanto de las actualizaciones puedes dejar tu follow y seria de ayuda si puedes apoar este repositorio con una estrella ⭐️

