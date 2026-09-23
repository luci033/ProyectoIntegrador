# Joyería ALBA - Sistema Integral de Gestión Comercial

Sistema de gestión comercial de escritorio desarrollado en **C# (.NET Framework)** con **Windows Forms** y una **Arquitectura en Capas (N-Tier)**, diseñado para administrar las operaciones diarias de una joyería: ventas, compras, inventario, clientes, proveedores, roles y reportería estadística gerencial.

---

## 🏛 Arquitectura del Proyecto

El proyecto está organizado en 4 capas desacopladas más scripts de persistencia:

* **`ProyectoIntegrador` (Capa de Presentación):** Interfaz gráfica de usuario en Windows Forms con un sistema de diseño visual corporativo propio (`EstiloUI.cs`), ventanas MDI organizadas por rol y modelos en memoria (`StockSimulado`, `EstadisticasSimuladas`, `ClientesSimulados`).
* **`CapaNegocio`:** Validador de reglas de negocio y puente entre la presentación y los datos.
* **`CapaDatos`:** Manejo de persistencia, conexión mediante ADO.NET y sentencias/procedimientos SQL hacia Microsoft SQL Server.
* **`CapaEntidades`:** Modelos de datos del dominio compartidos transversalmente (`Usuario`, `Rol`, etc.).
* **Scripts SQL:** `creacionBBDD-tablarol-tablausuario.sql` para el esquema inicial y seeding de la base de datos.

---

## 📋 Requisitos Previos

Para implementar y ejecutar este proyecto en tu equipo necesitás:

1. **Sistema Operativo:** Windows 10 o Windows 11 (64 bits).
2. **Visual Studio:** Visual Studio 2022 (Community o superior) con la carga de trabajo instalada:
   * **Desarrollo de escritorio de .NET** (incluye herramientas de .NET Framework 4.7.2 y el Diseñador de Windows Forms).
3. **Motor de Base de Datos:**
   * **Microsoft SQL Server** (SQL Server Express 2019/2022 o LocalDB).
   * **SQL Server Management Studio (SSMS)** o Azure Data Studio para administrar la base.
4. **Configuración Regional:**
   * La máquina debe tener configurado el símbolo de moneda en **`$`** (Pesos / Formato regional Español - Argentina o similar) para asegurar la compatibilidad con las validaciones numéricas de compras y ventas.

---

## 🚀 Guía de Instalación Paso a Paso

### Paso 1: Clonar o descargar el repositorio
Abrí una terminal (PowerShell o Git Bash) y cloná el proyecto:
```bash
git clone https://github.com/tu-usuario/ProyectoIntegrador.git
```
O descargá el archivo ZIP y descomprimilo en una carpeta local de tu preferencia (ej: `C:\Proyectos\ProyectoIntegrador`).

---

### Paso 2: Crear y poblar la Base de Datos
1. Abrí **SQL Server Management Studio (SSMS)** y conectate a tu servidor local (usualmente `.\SQLEXPRESS` o `localhost`).
2. Abrí el archivo [`creacionBBDD-tablarol-tablausuario.sql`](creacionBBDD-tablarol-tablausuario.sql) ubicado en la raíz del proyecto.
3. Ejecutá todo el script (`F5` o botón **Execute**).
4. El script creará automáticamente:
   * La base de datos `JoyeriaALBADB`.
   * Las tablas `Roles` y `Usuarios` con sus restricciones y claves foráneas.
   * Los 4 roles del sistema y 4 usuarios de prueba predeterminados.

---

### Paso 3: Configurar la Cadena de Conexión
1. Dirigite al archivo [`CapaDatos/Conexion.cs`](CapaDatos/Conexion.cs).
2. Modificá la variable `Cadena` para que apunte a tu instancia local de SQL Server:
   ```csharp
   public static string Cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=JoyeriaALBADB;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;";
   ```
   > **Nota:** Si tu instancia local no se llama `SQLEXPRESS`, reemplazalo por el nombre de tu servidor (por ejemplo `(localdb)\MSSQLLocalDB` o `localhost`).

---

### Paso 4: Abrir la Solución en Visual Studio
1. Abrí Visual Studio 2022.
2. Abrí el archivo de solución `ProyectoIntegrador.slnx` (o `Archivo > Abrir > Proyecto o solución...`).
3. Restaurá los paquetes NuGet:
   * Hacé clic derecho sobre la solución en el Explorador de Soluciones y seleccioná **Restaurar paquetes NuGet**.
   * Esto descargará las librerías necesarias (como `AForge` para la captura de fotos de perfil).

---

### Paso 5: Compilación y Ejecución
1. En el Explorador de Soluciones, hacé clic derecho sobre el proyecto **`ProyectoIntegrador`** y seleccioná **Establecer como proyecto de inicio**.
2. Verificá que la configuración esté en **`Debug`** y plataforma **`Any CPU`** (o `x86`/`x64`).
3. Compilá la solución completa presionando `Ctrl + Shift + B`.
4. Iniciá la aplicación presionando **`F5`** (o el botón verde *Iniciar*).

---

## 🔑 Credenciales de Acceso (Usuarios de Prueba)

Al iniciar la aplicación se abrirá la pantalla de **Login**. Podés acceder utilizando cualquiera de los siguientes usuarios cargados por el script SQL:

| Usuario | Contraseña | Rol Asignado | Módulos a los que accede |
| :--- | :--- | :--- | :--- |
| `admin` | `1234` | **Administrador** | Acceso total: Catálogo, Ventas, Clientes, Ajustes de Stock, Compras, Usuarios. |
| `gerente` | `1234` | **Gerente** | Acceso ejecutivo: Dashboard gerencial, KPIs, Informes estadísticos y Ventas. |
| `vendedor` | `1234` | **Vendedor** | Facturación: Registrar Venta, Historial de Ventas, Búsqueda y alta de Clientes. |
| `logistica` | `1234` | **Logística** | Operaciones: Ajuste de stock, Catálogo de productos, Proveedores y Compras. |

---

## 📦 Módulos Principales del Sistema

* **Punto de Venta y Facturación:** Carrito de compras de joyas, cálculo automático de subtotales, cobro multimétodo (Efectivo, Tarjeta, Transferencia), emisión de comprobante e historial de transacciones.
* **Clientes:** Administración integral, buscador modal rápido e incorporación de clientes al vuelo desde la pantalla de venta con validación de DNI único.
* **Control de Inventario y Joyas:** Catálogo de productos, categorías, imágenes y módulo de ajuste manual de stock por ingresos o mermas/egresos.
* **Compras y Proveedores:** Gestión de órdenes de compra, control de estado de recepción de mercadería y administración de proveedores.
* **Dashboard Gerencial:** Métricas en tiempo real (recaudación diaria, ticket promedio, alertas de stock mínimo), gráficos de tendencia y exportación de informes.

---

## 🛠 Solución de Problemas Frecuentes

* **Error al conectar con la base de datos:**
  Verificá que el servicio de SQL Server esté iniciado en el Administrador de Servicios de Windows (`services.msc`) y que el nombre de la instancia en [`CapaDatos/Conexion.cs`](CapaDatos/Conexion.cs) coincida con el tuyo.
* **Total en $0 al generar compras o ventas:**
  Si tu máquina tiene Windows en formato de moneda europea (`€`), cambiá la configuración regional en Windows (`intl.cpl`) a formato **Español (Argentina)** o establecé el símbolo de moneda en `$`.
* **Errores con componentes de diseño de formularios:**
  Asegurate de que la solución esté compilada con éxito antes de abrir los formularios en vista de Diseñador en Visual Studio.
