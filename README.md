# User Management API

Esta es una **API RESTful** desarrollada en **.NET Core** y **C#** para realizar operaciones CRUD sobre usuarios. Es un proyecto diseñado para principiantes, pero siguiendo buenas prácticas y estándares profesionales.

## Características

- CRUD completo para usuarios (Crear, Leer, Actualizar, Eliminar).
- Documentación interactiva con Swagger.
- Uso de Entity Framework Core para interactuar con la base de datos.
- Configuración fácil para entornos locales.

---

## Requisitos

- [.NET 6](https://dotnet.microsoft.com/download) o superior instalado.
- SQL Server o cualquier base de datos compatible con Entity Framework.
- Herramienta para probar APIs como [Postman](https://www.postman.com/) o Swagger.

---

## Configuración del proyecto

### 1. Clonar el repositorio
Clona el repositorio en tu máquina local:
```bash
git clone https://github.com/XZanderU/UserManagementAPI.git
cd UserManagementAPI

2. Configurar la base de datos
Actualiza el archivo appsettings.json con la cadena de conexión a tu base de datos.
Ejecuta las migraciones para generar las tablas:
dotnet ef database update
3. Ejecutar la aplicación
Inicia el servidor con:
dotnet run
La API estará disponible en http://localhost:5187.

Endpoints
Método	Ruta	Descripción
GET	/api/users	Obtener todos los usuarios
GET	/api/users/{id}	Obtener un usuario por ID
POST	/api/users	Crear un nuevo usuario
PUT	/api/users/{id}	Actualizar un usuario por ID
DELETE	/api/users/{id}	Eliminar un usuario por ID
Pruebas
Puedes probar la API utilizando herramientas como Postman o Swagger.

Swagger está disponible en: http://localhost:5187/swagger.
Mejoras futuras
Implementar autenticación y autorización con JWT.
Agregar validaciones avanzadas a los modelos.
Crear pruebas automatizadas.
Contribuciones
¡Las contribuciones son bienvenidas! Por favor, abre un issue o envía un pull request.

Creado por Tu Nombre John Alexander Urrea Garcia

### **Archivo `.gitignore`**

El archivo `.gitignore` es necesario para evitar subir archivos sensibles o innecesarios al repositorio. Aquí tienes un ejemplo para un proyecto .NET:

