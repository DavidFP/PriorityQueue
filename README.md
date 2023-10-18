# Cola de Urgencias usando un Priority Queue en C#

Este es un ejemplo de una aplicación de consola en C# que simula una cola de urgencias de un hospital. La aplicación utiliza una PriorityQueue (cola de prioridad) para gestionar pacientes según su gravedad. La cola se basa en la biblioteca de C# para simplificar la gestión de pacientes en función de su prioridad.

## Descripción

La aplicación proporciona las siguientes funcionalidades:

1. **Mostar estado actual:** Muestra la lista de pacientes en la cola de urgencias junto con sus prioridades.

2. **Introducir Paciente:** Permite al usuario ingresar un nuevo paciente con un nombre y una prioridad del 1 al 10, donde 1 representa una gravedad muy alta y 10 una gravedad leve.

3. **Siguiente Paciente por Pantalla:** Muestra el siguiente paciente en la cola y resalta su importancia en la consola.

4. **Pasar Turno:** Elimina al paciente más prioritario de la cola y lo resalta en la consola.

5. **Limpiar Cola:** Elimina todos los pacientes de la cola.

6. **Salir:** Finaliza la aplicación.

## Uso

1. Ejecute la aplicación.
2. Seleccione una de las opciones del menú ingresando el número correspondiente.
3. Siga las instrucciones en pantalla para realizar las operaciones deseadas.

## Ejemplo

Un ejemplo de uso de la aplicación podría ser:

1. Introducir Paciente:
   - Nombre del Paciente: Juan
   - Prioridad (1-10): 3

2. Introducir Paciente:
   - Nombre del Paciente: María
   - Prioridad (1-10): 7

3. Siguiente Paciente por Pantalla:
   - Se mostrará un mensaje resaltado indicando el siguiente paciente, en este caso, Juan.

4. Pasar Turno:
   - Se eliminará a Juan de la cola y se mostrará un mensaje resaltado.

5. Mostar estado actual:
   - Mostrará el estado actual de la cola, que ahora solo contiene a María.

6. Repita los pasos anteriores para continuar gestionando pacientes en la cola de urgencias.

## Notas

- La cola de prioridad se implementa utilizando la clase `PriorityQueue<string, int>` de la biblioteca `System.Collections.Generic`. Esta clase se utiliza para mantener a los pacientes ordenados según su prioridad.

- Los pacientes se muestran en la consola con colores para resaltar su importancia.

- La aplicación continúa ejecutándose hasta que el usuario elige salir (opción 99).

Este código proporciona una base simple para gestionar una cola de urgencias en un hospital y se puede personalizar y ampliar según las necesidades del usuario.