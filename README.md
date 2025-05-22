# 🏥 Sistema de Gestión Hospitalaria (EPS "Salvando Vidas")

Este proyecto es una aplicación de escritorio desarrollada en C# como una actividad del componente práctico de mi formación universitaria. Fue diseñado para la **Entidad Promotora de Salud (EPS) "Salvando vidas", una entidad ficticia**. Su propósito es gestionar el registro de usuarios que requieren atención médica o exámenes de laboratorio en sus centros a nivel nacional, calculando los costos de copago de las consultas según el estrato socioeconómico del paciente.

El desarrollo de esta aplicación se centró en la implementación y manejo de **estructuras de datos lineales** (Pilas, Colas y Listas) utilizando colecciones genéricas de C# (`Stack<T>`, `Queue<T>`, `List<T>`).

---

## ✨ Características Principales

* **Autenticación de Acceso:** Incluye un formulario de inicio de sesión con una contraseña genérica para asegurar el acceso al sistema principal.
* **Gestión de Usuarios con Estructuras de Datos Lineales:**
    * Permite el registro de usuarios en **Pilas (`Stack<T>`)**, **Colas (`Queue<T>`)** y **Listas (`List<T>`)** seleccionando la estructura deseada.
    * Cumple con el comportamiento FIFO (Cola), LIFO (Pila) y adición al final (Lista).
    * Visualización de registros en DataGridViews específicos para cada estructura.
* **Cálculo de Copagos Dinámico:** Calcula el valor del copago de la consulta médica o examen de laboratorio basado en el estrato socioeconómico del paciente.
    * **Medicina General:** Tarifas específicas para estratos 1 a 6.
    * **Exámenes de Laboratorio:** Tarifas específicas para estratos 1 a 6.
* **Recolección Detallada de Datos:** Captura información del usuario como tipo y número de identificación, nombre completo, edad, estrato socioeconómico, tipo de atención (medicina general / laboratorio) y fecha de acceso.
* **Validación de Entrada:** Valida que solo se ingresen números en campos numéricos y letras en campos de nombre, y que la información requerida esté completa antes de registrar.
    * **Pila:** Suma de los valores de copagos.
    * **Cola:** Cantidad de registros.
    * **Lista:** Promedio de edades.
* **Funcionalidades de Eliminación:** Permite eliminar registros de cada estructura según su comportamiento (desapilar, desencolar, eliminar por identificación en lista).
* **Navegación Intuitiva:** Incluye un menú superior (`MenuStrip`) con opciones como "Iniciar sesión" (para habilitar el login) y "Acerca de" (para mostrar información del autor/curso).
  
---

## 🚀 Tecnologías Utilizadas

* **Lenguaje de Programación:** C#
* **Entorno de Desarrollo (IDE):** Visual Studio
* **Interfaz Gráfica de Usuario (GUI):** Windows Forms (WinForms) 
* **Estructuras de Datos:** Colecciones Genéricas de C# (`Stack<T>`, `Queue<T>`, `List<T>`)

---

## 🛠️ Cómo Ejecutar el Proyecto

Para poner en marcha este proyecto en tu entorno local, sigue estos pasos:

1.  **Clonar el Repositorio:**
    Abre tu terminal (Git Bash o Símbolo del Sistema) y ejecuta:
    ```bash
    git clone [https://github.com/JhonSAR/sistema-atencion-hospitalaria.git](https://github.com/JhonSAR/sistema-atencion-hospitalaria.git)
    ```
2.  **Abrir en Visual Studio:**
    * Navega a la carpeta clonada.
    * Abre el archivo de solución (`.sln`) del proyecto (ej. `Fase3NombreEstudiante.sln` o similar al nombre que le diste, como `Fase2JhonArdila.sln` del proyecto anterior) con Visual Studio.
3.  **Compilar y Ejecutar:**
    * Dentro de Visual Studio, asegúrate de que el proyecto esté seleccionado como "Startup Project".
    * Haz clic en el botón "Start" (Iniciar) o presiona `F5` para compilar y ejecutar la aplicación.
4.  **Acceso al Sistema:**
    * **El sistema cuenta con una pantalla de inicio de sesión. La contraseña genérica para ingresar es: `unad`**
    * Al inicio, la contraseña y el botón "Ingresar" estarán deshabilitados. Debes hacer clic en **"Iniciar sesión"** en el menú superior para habilitarlos.

---

## 📸 Capturas de Pantalla

* **Pantalla de Inicio de Sesión** 
![image](https://github.com/user-attachments/assets/9fc73c0f-0430-45e4-8ca0-fc0c3c285958)

* **Formulario de Registro de Datos**
![image](https://github.com/user-attachments/assets/1187fb2a-579c-42fc-872a-77729ea74e51)

* **Formulario de Registro de Datos**
![image](https://github.com/user-attachments/assets/c6af42a7-c6cd-47d0-b19d-f10830a12142)

---

## 📚 Aprendizajes y Conceptos Clave

Este proyecto me permitió consolidar conocimientos profundos en:

* **Estructuras de Datos Lineales:** Implementación y manejo de Pilas, Colas y Listas (`Stack<T>`, `Queue<T>`, `List<T>`) y comprensión de sus comportamientos (LIFO, FIFO).
* **Programación Orientada a Objetos (POO):** Aplicación de clases, objetos y métodos para organizar el código y representar entidades del dominio (como usuarios).
* **Diseño de Interfaces Gráficas (GUI):** Experiencia en la creación de aplicaciones de escritorio interactivas utilizando Windows Forms.
* **Manejo de Eventos:** Implementación de lógicas de respuesta a las interacciones del usuario (botones, selección de opciones, validación).
* **Lógica de Negocio y Estructuras Condicionales:** Desarrollo de algoritmos para cálculos complejos basados en reglas específicas (tarifas por estrato).
* **Validación de Datos:** Asegurar la integridad y coherencia de la información ingresada por el usuario.
  
---

## 📬 Contacto

Si tienes alguna pregunta o sugerencia sobre este proyecto, no dudes en contactarme:

* **Email:** jhonsebastianardilareyes55@gmail.com
* **LinkedIn:** [https://www.linkedin.com/in/jhonsardila](https://www.linkedin.com/in/jhonsardila)
* **GitHub:** [https://github.com/JhonSAR](https://github.com/JhonSAR)
