# Sistamec

Es un sistema para un taller mecánico, con le fin de optimizar las diferentes tareas generadas a diario en una sola herramienta

# Autores:

Carlos Morales Sandí
Felipe Urena
Ismael Gonzalez

# Prerequisitos de instalación

Se recomienda tener el backup de la base de datos listo para ser cargado en SQL 2014

1. Ingresar al siguiente link https://github.com/carlosmorales94/Sistamec1/tree/master
2. Navegar hasta el folder DB Scripts.
3. Descargar el backup de la base de datos TallerHernandez.bak

Es importante tener en cuenta que el IIS tiene que estar instalado con la version del framework con la cual el proyecto fue desarrollado, en esta caso sera .NET Framework 4.5.2.

1. Se debe crear un pool para la aplicación, en la aplicación pool escoja la version del framework .NET Framework 4.5.2.
2. Luego se debe agregar el código descargado del repositorio de GitHub en la rama master con el Release V0.7.
3. Luego regresar al IIS y refrescar el DefaultWebSite, ah’ debe aparecer la carpeta con el proyecto.
4. Botón derecho sobre dicha carpeta y "convertir en aplicación", en la nueva ventana selecciona el application pool anteriormente creado.
5. Dar clic en probar configuración... y ACEPTAR

# Instalacion

Para realizar la instalacion de sistamec, se debe contar con el sistema operativo Windows en versiones 7 en adelante en las computadoras donde se va utilizar la herramienta, adicionalmente, se debe contar con un motor de base de datos SQL server 2014, asi como la configuracion de el IIS:

1: Instalar el IIS y los modulos de ASP.NET
2: Configurar los ajustes de ASP.NET
3: Configurar los ajustes del DataSource
4: Configurar el Application Security

Se debe clonar el repositorio de github para obtener los archivos de la aplicación.
Cabe mencionar que la herramienta va tener la base de datos en un cluster donde se alojara para conectarse localmente en la Red.

# Despliegue

Validando las instalaciones del software requerido para instalar nuestra aplicacion correctamente, se debe realizar el pase a produccion colocando la ultima version, la misma seria la oficial de nuestro proyecto, instalada en el IIS de cada maquina donde se va ejecutar la aplicacion, adicionalmente instalando la base de datos por medio de un restore, esta base de datos contara con las tabla y ciertos parametros configurados que debera llevar para que nuestra herramienta funcione de la mejor manera. 
