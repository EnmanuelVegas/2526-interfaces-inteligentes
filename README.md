# Enmanuel Vegas Acosta (alu0101281698@ull.edu.es)

## Demostración y descripción del trabajo realizado en la tarea 'Introducción a Unity'

### Funcionamiento
![demostracion](./demo.gif)

### Descripción
Para esta primera práctica se ha interactuado de manera básica con el motor de videojuegos Unity.
He agregado figuras básicas 3D (plataformas, esfera, terreno), así como 
trabajado con recursos de los Assets de Unity, de donde hemos obtenido el Starter
Pack en tercera persona y un recurso extra de un zombie. Se le ha añadido una etiqueta (Tags)
personalizada a todos ellos.

Finalmente, se ha desarollado un script que se encarga de encontrar a todos estos
elementos e imprime por consola el nombre de la etiqueta asignada y la posición del objeto.

Para ello, se han encapsulado todos estos objetos en un contenedor vacío, y desde el script
hemos accedido a la propiedad Transform de dicho contenedor para conocer los atributos de los hijos que nos interesan.
