# Gestión de Biblioteca - UDB

Aplicación de escritorio desarrollada en C# con Windows Forms y .NET 8 para la gestión de una biblioteca universitaria.

Universidad Don Bosco | Desarrollo de Aplicaciones con Software Propietario | DAS901 G01T
Estudiante: David Antonio Leiva Martínez (LM160828)
Docente: Ing. Karens Medrano
Ciclo: 01 - 2026

---

## Funcionalidades

- Gestión de Libros: registrar, editar, eliminar y consultar libros
- Gestión de Usuarios: registrar, editar, eliminar y consultar usuarios
- Gestión de Préstamos: registrar préstamos y gestionar devoluciones
- Gráficos estadísticos: top 5 libros más prestados y usuarios más activos
- Validaciones: campos obligatorios, formato de correo, teléfono solo numérico

---

## Tecnologías

- Lenguaje: C# / .NET 8
- Framework UI: Windows Forms
- IDE: Visual Studio 2022
- Gráficos: ScottPlot.WinForms
- Control de versiones: Git / GitHub

---

## Instalación

### Requisitos previos

- Windows 10 o superior
- Visual Studio 2022 con carga de trabajo .NET Desktop
- .NET 8 SDK (incluido con Visual Studio 2022)
- Git para Windows

### Pasos

1. Clonar el repositorio:

```
git clone https://github.com/dleiva404/Desafio-1-DAS.git
```

2. Abrir Visual Studio 2022, seleccionar Archivo > Abrir > Proyecto/Solución y abrir el archivo GestionBiblioteca.sln dentro de la carpeta GestionBiblioteca.

3. Restaurar paquetes NuGet:

```
dotnet restore
```

4. Presionar F5 para ejecutar con depuración, o Ctrl+F5 para ejecutar sin depuración.

---

## Uso

### Pestaña Libros

- Agregar: completar Título, Autor, Año y Género, luego clic en Agregar.
- Editar: seleccionar una fila de la tabla, modificar los campos y clic en Editar.
- Eliminar: seleccionar una fila y clic en Eliminar. Se pedirá confirmación.

### Pestaña Usuarios

- Agregar: completar Nombre, Correo y Teléfono, luego clic en Agregar.
- Editar: seleccionar una fila, modificar los campos y clic en Editar.
- Eliminar: seleccionar una fila y clic en Eliminar. Se pedirá confirmación.

### Pestaña Préstamos

- Registrar: seleccionar un usuario y un libro disponible, elegir la fecha de devolución y clic en Registrar.
- Devolver: seleccionar un préstamo pendiente de la tabla y clic en Devolver. Se pedirá confirmación.

### Pestaña Gráficos

- Clic en Generar Gráficos para visualizar las estadísticas actualizadas.

---

## Despliegue

### Desde Visual Studio

1. Clic derecho sobre el proyecto en el Explorador de Soluciones y seleccionar Publicar.
2. Elegir Carpeta como destino.
3. Seleccionar modo Autocontenido para que no requiera .NET instalado en el equipo destino.
4. Clic en Publicar. El ejecutable quedará en: bin\Release\net8.0-windows\publish\

### Desde línea de comandos

```
dotnet publish -c Release -r win-x64 --self-contained true
```

---

## Estructura del Proyecto

```
GestionBiblioteca/
├── Models/
│   ├── Libro.cs
│   ├── Usuario.cs
│   └── Prestamo.cs
├── Services/
│   ├── LibroService.cs
│   ├── UsuarioService.cs
│   └── PrestamoService.cs
├── PrincipalForm.cs
├── PrincipalForm.Designer.cs
└── GestionBiblioteca.csproj
```

---

## Arquitectura

El proyecto aplica Programación Orientada a Objetos con separacion en capas:

- Models: clases de dominio (Libro, Usuario, Prestamo)
- Services: logica de negocio y operaciones CRUD
- Forms: interfaz de usuario y manejo de eventos

---

## Repositorio

https://github.com/dleiva404/Desafio-1-DAS
