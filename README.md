# 🛡️ Military Armament Comparator

¡Bienvenido al **Military Armament Comparator**! Esta es una aplicación web moderna y dinámica construida con **Blazor Web App (.NET 9)** diseñada para entusiastas de la tecnología militar que desean explorar, buscar y comparar especificaciones técnicas de vehículos blindados de todo el mundo.

---

## 🚀 Funcionalidades Principales

*   **🔍 Buscador Global**: Encuentra cualquier blindado instantáneamente desde la barra de navegación superior.
*   **📊 Comparador Avanzado**: Selecciona hasta 3 vehículos y compáralos cara a cara en una tabla técnica detallada (Velocidad, Blindaje, Motor, etc.).
*   **🌍 Explorador por Naciones**: Filtra y visualiza el arsenal blindado por países (España, EE.UU., Alemania, etc.) con sus respectivas banderas y descripciones.
*   **📋 Fichas Técnicas**: Modales interactivos que muestran especificaciones completas: desde dimensiones hasta capacidad de pasajeros e infantería.
*   **🛠️ Panel de Administración**: Gestión completa del catálogo (Añadir, Editar, Duplicar o Eliminar vehículos y naciones) protegida por contraseña.
*   **💎 Diseño Premium**: Interfaz fluida, modo oscuro elegante y micro-animaciones para una experiencia visual de alto nivel.

---

## 🛠️ Stack Tecnológico

*   **Framework**: [C# / Blazor Web App (Server-side)](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
*   **Persistencia**: [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) con **SQLite**.
*   **Estilo**: [Bootstrap 5](https://getbootstrap.com/) con iconos de [Bootstrap Icons](https://icons.getbootstrap.com/).
*   **Despliegue**: Listo para ser alojado en **Azure App Service**.

---

## ⚙️ Instalación y Ejecución Local

Si deseas ejecutar el proyecto en tu máquina local:

1.  **Clona el repositorio**:
    ```bash
    git clone https://github.com/tu-usuario/MilitaryComparator.git
    cd MilitaryComparator
    ```

2.  **Restaura las dependencias**:
    ```bash
    dotnet restore
    ```

3.  **Ejecuta la aplicación**:
    ```bash
    dotnet run
    ```
    *La base de datos se creará automáticamente en el primer inicio gracias al `DbInitializer`.*

---

## 🔐 Acceso de Administrador

Para gestionar el contenido de la web, puedes acceder a la sección `/admin`.
*   **Clave Maestra**: `Military2024` (Configurable en `AdminState.cs`).

---

## ☁️ Notas para Despliegue en Azure

Este proyecto utiliza **SQLite** como base de datos. Si lo subes a Azure App Service (Linux), asegúrate de:
1.  Habilitar el almacenamiento persistente añadiendo la variable de entorno:
    `WEBSITES_ENABLE_APP_SERVICE_STORAGE = true`
2.  Configurar el entorno en modo **Production** para que el sistema utilice el archivo `appsettings.Production.json`.

---


