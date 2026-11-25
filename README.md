# Tech Store SOAP

## 📌 Descripción

Tech Store SOAP es un proyecto desarrollado en C# utilizando ASP.NET Web Forms y servicios web SOAP. Su objetivo es demostrar cómo consumir e implementar servicios web mediante el protocolo SOAP, permitiendo la comunicación e intercambio de información entre diferentes aplicaciones.

El proyecto simula la administración de productos de una tienda de tecnología, utilizando operaciones CRUD (Create, Read, Update, Delete).

## 🚀 Características

- Consumo de servicios web SOAP mediante C#.
- Integración y comunicación entre aplicaciones mediante servicios web.
- Uso de WSDL para describir las operaciones disponibles y la estructura del servicio.
- Registro de nuevos productos.
- Consulta de información de productos.
- Actualización de productos existentes.
- Eliminación de productos.
- Conexión con una base de datos SQL Server.

## 🛠️ Tecnologías utilizadas

- **C#:** Lenguaje de programación principal.
- **ASP.NET Web Forms:** Desarrollo de la aplicación web.
- **SOAP:** Protocolo de comunicación entre aplicaciones.
- **WSDL:** Descripción de las operaciones y características del servicio web.
- **SQL Server:** Sistema de gestión de bases de datos.
- **Bootstrap:** Diseño y estilos de la interfaz.
- **HTML5 y CSS3:** Estructura y presentación.
- **JavaScript:** Funcionalidades del lado del cliente.

## 📋 Requisitos previos

Para ejecutar el proyecto es necesario contar con:

- Visual Studio.
- .NET WebForm compatible con el proyecto.
- SQL Server.
- SQL Server Management Studio (SSMS).

## ⚙️ Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/JoseDavid017.git
   ```

2. Abrir la solución del proyecto (`.sln`) en Visual Studio.

3. Configurar la cadena de conexión a SQL Server en el archivo `Web.config`.

4. Verificar que el servicio web SOAP esté disponible y que la referencia al servicio esté correctamente configurada.

5. Ejecutar el proyecto desde Visual Studio.

## 📁 Estructura del proyecto

```text
TechStore/
│
├── Web References/    # Protocolo de comunicación
├── AppData/           # Archivos mdf y ldf para la Base de datos
├── AppStart/          # Configuraciones de la aplicación
├── Content/           # Archivos CSS y estilos
├── Scripts/           # Archivos JavaScript
├── Default.aspx       # Página principal
├── Web.config         # Configuración del proyecto
└── README.md          # Documentación
```

## 👨‍💻 Autor

**Jose David Ariza López**

## 📄 Licencia

Este proyecto fue desarrollado con fines académicos y educativos.
