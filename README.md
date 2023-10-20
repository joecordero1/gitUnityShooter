# Aplicación de Principios y Arquitecturas de Sistemas Hipermedia

Por: Joe Cordero

Link del video en Loom: https://www.loom.com/share/8c9b0f1722de41559392f48e07294e14?sid=23cecc97-22de-4185-874a-7f25452d35a6

Este proyecto de Unity es un juego de disparos en el que el jugador puede destruir objetos, como cubos y esferas, utilizando un láser. Además, se ha implementado un sistema de contadores que rastrea la cantidad de cubos y esferas destruidos. A continuación la explicación de cómo se ha programado.

## Contadores de Elementos Destruidos

Para llevar un seguimiento de la cantidad de cubos y esferas destruidos en el juego, se ha implementado un sistema de contadores en el script `RayCastShoot.cs`. Aquí hay una descripción de cómo funciona:

- Se han declarado dos variables `countCubes` y `countSpheres` para llevar un registro de los elementos destruidos de cada tipo.

- En el método `Fire()`, después de destruir un objeto impactado, se verifica si es un cubo o una esfera. Dependiendo del tipo, se actualiza el contador respectivo.

- El valor del contador se muestra en pantalla utilizando el componente TextMeshPro (`TMP_Text`) para que el jugador pueda ver la cantidad de cubos y esferas destruidos en tiempo real.

## Sistema de Destrucción de Objetos

El script `Shooted.cs` y `SphereShooted.cs` son responsables de manejar la lógica de destrucción de cubos y esferas respectivamente. Aquí está cómo funciona:

- Se define un valor de escala (`scaleFactor`) que se usa para reducir la escala del objeto con cada impacto, lo que simula la destrucción gradual.

- El contador `currentImpacts` registra cuántos impactos ha recibido el objeto. Cuando alcanza un valor máximo (`maxImpacts`), el objeto se destruye.

- Antes de destruir el objeto, se llama a la función `ReduceScale()` para reducir su tamaño gradualmente con cada impacto.

## Funcionamiento del Láser

El script `RaycastGun.cs` maneja el comportamiento del láser en el juego:

- El láser se dispara desde la posición del `laserOrigin` en la dirección en la que el jugador está mirando.

- Si el láser colisiona con un objeto en el rango del arma (`gunRange`), se muestra una línea láser que indica el punto de colisión.

- El láser se desactiva después de un breve período (`laserDuration`) para dar la sensación de un disparo láser.

## Generación de Objetos

El script `Generador.cs` se encarga de generar cubos y esferas en ubicaciones aleatorias del escenario. Se establece un límite de objetos generados.
