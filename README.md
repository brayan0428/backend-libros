# Descripción del Proyecto

### Tecnologias utilizadas

Para la construcción de esta aplicación se utilizo .Net 5, Entity Framework y Sql Server como base de datos

### Ejecución de la app

Para ejecutar la aplicación se deben instalar los paquetes que se encuentran referenciados en el archivo de _Libreria.csproj_ y se debe tener una base de datos creada en el motor de Sql Server. La base de datos tiene por nombre Libreria y cuenta con tres tablas, Autor, Editorial y Libro. Dentro del repositorio se encuentra un script para crear dicha base de datos. La cadena de conexión de la base de datos debe ser configurada en el archivo _appsettings.json_ en la llave que corresponde a LibreriaContext.

### Funcionamiento de la Aplicación

La API cuenta con 6 endpoints los cuales se describen a continuación:

- /api/Libro (GET): Devuelve el listado de los libros creados
- /api/Editorial (GET): Devuelve el listado de las editoriales creadas
- /api/Autor (GET): Devuelve el listado de los autores creados
- /api/Libro (POST): Permite crear un libro y recibe los siguientes parametros:
  - titulo (string)
  - anio (string)
  - genero (string)
  - numPaginas (number)
  - idEditorial (number)
  - idAutor (number)
- /api/Editorial (POST): Permite crear una Editorial y recibe los siguientes parametros:
  - nombre (string)
  - direccion (string)
  - telefono (string)
  - email (string)
  - maximoLibros (number)
- /api/Autor (POST): Permite crear un Autor y recibe los siguientes parametros:
  - nombre (string)
  - fechaNacimiento (date)
  - ciudad (string)
  - email (string)
