using UnityEditor;
using UnityEngine;

public class EjerciciosPracticos : MonoBehaviour
{


    /*Bloque 1: variables + condiciones
     Ejercicio 1 — Contador

   Crear un programa que tenga una variable:

   int puntos = 0;

   Cada vez que se ejecute una determinada parte del código, los puntos deben aumentar en 1.

   Cuando los puntos lleguen a 10, mostrar:

   ¡Llegaste a 10 puntos!


    Resultado: Hice bien el contador, sin mirar nada, ya me esta empezando a quedar el concepto de float tiempo y el deltatime mas o menos. Le agregue por mi cuenta un booleano para que el contador parara en 10 y no siguiera eternamente, aunque no estuviera en la consigna.

   */

    int puntos = 0;
    float tiempo = 0;
    bool llegoadiez = false;
    int numero = 17;
    int vida = 10;
    bool jugando = false;
    int segundos = 0;
    int tiempoRestante = 10;
    bool llegoacero = false;
    bool llegoaocho = false;
    bool TerminoElArray = false;
    bool ProgramaTerminado = false;
    int[] numeros = new int[5];
    int[] arraysegundos = new int[5];
    int posicionArray = 0;
    int[] numerosPares = new int[5];
    int enemigosDerrotados = 0;
    float energiaEscudo = 100;
    bool escudoActivo = true;



    /* void Start()
     {
         //Debug.Log(tiempoRestante);
     } */


    /* void Update()
     {
         if (!llegoadiez)
         {
             tiempo += Time.deltaTime;

             if (tiempo >= 1)
             {
                 puntos++;
                 Debug.Log("Puntos: " + puntos);
                 tiempo = 0;


             }

             if (puntos == 10)
             {
                 llegoadiez= true;
                 Debug.Log("Llegaste a 10, felicitaciones");

             }


         }



     } */


    /*Ejercicio 2 — Número par

Tenés:

int numero = 17;

Mostrar:

El número es par

si es par, y:

El número es impar

si es impar.

Pista: pensá qué operador usamos para saber el resto de una división.


    Resultado: tuve que mirar en otros scripts para buscar la respuesta, no me salia la condicion para sacar el resto ( es x % 2 == 0 para sacar si es par)

*/

    /* void Update ()
     {


         if (numero % 2 == 0)
         {
             Debug.Log("El numero es par");
         }

         else
         {
             Debug.Log("El numero es impar");
         }



     }
    */


    /*Ejercicio 3 — Vida

Tenés:

int vida = 100;

Crear una condición que muestre:

"Vida alta" si es mayor o igual a 70.
"Vida media" si está entre 30 y 69.
"Vida baja" si es menor a 30.


    Resultado: hice casi todo bien. solo necisite ayuda para la condicion del if de vida media. al usar el operador && olvide que tenia que poner el nombre de la variable de los dos lados.

*/

    /*  void Update () 
      { 
      if (vida >= 70) 
          {
              Debug.Log("Vida Alta");

          }

      if (vida >= 30 && vida <= 69)
          {
              Debug.Log("Vida Media");
          }

      if(vida <30)
          {
              Debug.Log("Vida Baja");
          }

      }
    */

    /*Ejercicio 4 — Estado

Tenés:

bool jugando = true;

Si jugando es true, mostrar:

El juego está activo

Si es false:

El juego terminó

    Resultado: hecho sin problemas
*/


    /*  void Update()
      {
          if (jugando)
          {
              Debug.Log("el juego anda");

          }

          else
          {
              Debug.Log("el juego no anda");
          }
      }
    */


    /*BLOQUE 2 — Timers


Ejercicio 5 — Cronómetro

Crear un contador que empiece en 0 y aumente una vez por segundo:

Segundo: 1
Segundo: 2
Segundo: 3
...

No tiene duración máxima.

     Resultado: hecho sin problemas
*/



    /*voidUpdate()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 1)
        {
            segundos++;
            Debug.Log("Segundo: " + segundos);
            tiempo = 0;
        }


    }*/


    /*Ejercicio 6 — Cuenta regresiva

Crear una cuenta regresiva:

5
4
3
2
1
0

Cuando llegue a 0:

¡Tiempo terminado!

El timer debe detenerse.


    Resultado: resuelto casi sin problemas. experimente probando poniendo la condicion if tiempo == 1 en vez de >=. El codigo funciona con >= para darle un changui de margen a la variable tiempo. No se usa == para comparar el tiempo que paso.
*/


    /*  voidUpdate()
      {
          if (!llegoacero)
          {


              tiempo += Time.deltaTime;
              if (tiempo >= 1)
              {
                  tiempoRestante--;
                  Debug.Log(tiempoRestante);
                  tiempo = 0;

              }

              if (tiempoRestante == 0)
              {

                  llegoacero = true;
                  Debug.Log("Tiempo Terminado");
              }

          }
      } */

    /*Ejercicio 7 — Advertencia

Crear una cuenta regresiva desde 10.

Mostrar:

Tiempo restante: 10
Tiempo restante: 9
...

Cuando queden 5 segundos:

¡Quedan 5 segundos!

Cuando llegue a 0:

¡Tiempo terminado!

    resultado: resuelto casi sin problemas. aclaracion: hay demasiados mensajes en consola que dicen "tiempo restante: 5". Solucion: No crear un if aparte. Poner esa misma condicion como un segundo if dentro del if de (tiempo >=1). De esta forma me aseguro de que el mensaje se muestre una sola vez.
*/


    /* void Update()
     {
         if (!llegoacero)
         {


             tiempo += Time.deltaTime;
             if (tiempo >= 1)
             {
                 tiempoRestante--;
                 Debug.Log("Tiempo Restante: " + tiempoRestante);
                 tiempo = 0;

                 if (tiempoRestante == 5)
                 {
                     Debug.Log("Quedan 5 segundos");
                 } //Condicion reubicada.

             }

            if (tiempoRestante == 5)
             {
                 Debug.Log("Quedan 5 segundos");
             }  Condicion puesta por primera vez por mi.



             if (tiempoRestante == 0)
             {

                 llegoacero = true;
                 Debug.Log("Tiempo Terminado");
             }

         }


     } */

    /*Ejercicio 8 — Timer mediante método

Hacé un timer de 8 segundos, pero esta vez la lógica del timer no puede estar directamente dentro de Update().

Update() debe encargarse de llamar a un método.
    resultado: resuelto sin problemas.
*/

    /*   voidUpdate()
       {
           LogicaTimer();

       }



       void LogicaTimer()
       {
           if (!llegoaocho)
           {


               tiempo += Time.deltaTime;
               if (tiempo >= 1)
               {
                   segundos++;
                   Debug.Log("Segundo: " + segundos);
                   tiempo = 0;
               }

               if (segundos == 8)
               {
                   llegoaocho = true;
                   Debug.Log("Time Out");
               }
           }

       } */



    /*BLOQUE 3 — Arrays
Ejercicio 9 — Guardar números

Crear:

int[] numeros = new int[5];

Guardar manualmente:

10
20
30
40
50

Después recorrer el array y mostrar todos los valores utilizando un for.

    Resultado: resuelto con ayuda. Lo que hice estaba bien, pero no consegui hacer que el array solo se lea una sola vez. La solucion era muy simple: poner el codigo en el metodo start en vez del update. 
    RECORDA: Update para cosas que quieras que se vean ejecuten constantemente y Start para cosas que quieras que se vean ejecuten una sola vez.
*/


    /* void Start()
     {

         numeros[0] = 10;
         numeros[1] = 20;
         numeros[2] = 30;
         numeros[3] = 40;
         numeros[4] = 50;

         for (int i = 0; i < numeros.Length; i++) 
         {

             Debug.Log("Numero: " + i);
         }





     } */


    /*Ejercicio 10 — Array de segundos

Crear un array de 5 posiciones.

Hacer un contador que avance cada segundo.

Cada vez que el contador llegue a un número par, guardar ese número en el array.

El resultado debería terminar siendo:

2
4
6
8
10

Después mostrar los valores del array utilizando un for.
    resultado: no me salio, use ayuda para resolverlo
*/


    /* Primer version
    void Start()
    {

    }



    void Update()
    {
        tiempo += Time.deltaTime;
        if ( tiempo >= 1 ) 
        {
            segundos++;
            Debug.Log(segundos);
            tiempo = 0;

            if (segundos % 2  == 0 )
            {
                Debug.Log("Segundo: " + segundos + " Numero Par ");
                guardarNumeroPar();
                mostrarNumeroPar();
            }    
        }

    }


    void guardarNumeroPar() 
    {
        arraysegundos[posicionArray] = segundos;
        posicionArray++;


    }


    void mostrarNumeroPar() 
    {

        for (int i = 0; i < arraysegundos.Length; i++)
        {
            Debug.Log("Par: " + arraysegundos[i]);

        }
    }
    */


    /* void Update()
     {
         // Si ya llenamos el array, no hacemos nada más
         if (!TerminoElArray)

         // El motor del tiempo corre cuadro a cuadro
         tiempo += Time.deltaTime;

         // Cada vez que pasa 1 segundo real
         if (tiempo >= 1)
         {

              segundos++;  // Avanzamos el contador de segundos
              tiempo = 0; // Reiniciamos el cronómetro

             // ¿El segundo actual es un número par?
             if (segundos % 2 == 0)
             {
                 // Guardamos el segundo en la posición actual del array
                 numerosPares[posicionArray] = segundos;

                 // Avanzamos al siguiente espacio del estante para la próxima vez
                 posicionArray++;

                 // Si ya llenamos los 5 espacios (del índice 0 al 4, el siguiente es 5)
                 if (posicionArray >= numerosPares.Length)
                 {
                     TerminoElArray = true; // Echamos el candado

                     // Mostramos el resultado final usando un bucle 'for'
                     Debug.Log("--- CONTENIDO DEL ARRAY ---");
                     for (int i = 0; i < numerosPares.Length; i++)
                     {
                         Debug.Log(numerosPares[i]);
                     }
                 }
             }
         }
     }
    */


    /*Ejercicio 11 — Buscar valores

Usando el array del ejercicio anterior, recorrerlo con un while.

Mostrar únicamente los números mayores a 5.

Resultado:

6
8
10

    resultado: no me salio, use ayuda para resolverlo
*/

    /* void Start()
     {
         // 1. Array del ejercicio anterior con sus datos poblados
         int[] numerosPares = new int[] { 2, 4, 6, 8, 10 };

         // 2. Creamos la variable que servirá como índice/contador para el while
         int i = 0;

         // 3. El bucle while se repite mientras el índice sea menor al tamaño del array
         while (i < numerosPares.Length)
         {
             // 4. Condición: ¿El número en la posición actual es mayor a 5?
             if (numerosPares[i] > 5)
             {
                 Debug.Log(numerosPares[i]);
             }

             // 5. ¡MUY IMPORTANTE! Sumamos 1 al índice para pasar al siguiente elemento
             i++;
         }
     }

 */



    /*BLOQUE 4 — Unity

Ahora entramos en lo que probablemente tenga más peso en el parcial.

Ejercicio 12 — Movimiento X/Z

Crear un jugador que:

se mueva con WASD;
pueda moverse solamente en X y Z;
tenga una velocidad configurable desde el Inspector;
utilice Time.deltaTime.

No agregar salto, gravedad, sprint ni nada más.


    Ejercicio 13 — Cámara

Crear una cámara que siga al jugador.

La cámara debe:

mantener una altura fija;
seguir la posición X del jugador;
seguir la posición Z del jugador;
tener una vista Top Down.



Ejercicio 14 — NPC perseguidor

Crear un NPC que:

tenga un Rigidbody;
tenga una velocidad configurable;
tenga una distancia de persecución configurable;
persiga al jugador cuando esté a 10 metros o menos;
se detenga cuando esté a más de 10 metros;
se mueva únicamente en X/Z.

    resultados: ejericios hechos correctamente en otros scripts.

    Ejercicio 15 — Enemigos derrotados

Tenés un contador:

int enemigosDerrotados = 0;

Cada vez que se derrota un enemigo, aumenta en 1.

Cuando se hayan derrotado 5 enemigos, mostrar:




*/


    /* voidUpdate()
     {
         // Simulamos derrotar un enemigo al presionar la barra espaciadora
         if (Input.GetKeyDown(KeyCode.Space))
         {
             DerrotarEnemigo();
         }
     }

     // 2. Creamos un método propio para manejar la lógica cuando muere un enemigo
     void DerrotarEnemigo()
     {
         // Aumenta el contador en 1
         enemigosDerrotados++;
         Debug.Log("Enemigos derrotados: " + enemigosDerrotados);

         // 3. Condición: ¿Ya se derrotaron exactamente 5 enemigos?
         if (enemigosDerrotados == 5)
         {
             Debug.Log("¡Objetivo cumplido! Has derrotado a 5 enemigos.");
         }
     }
    */



    /*Ejercicio 16 — Registro de tiempos

Crear un programa que:

cuente de 1 a 10 segundos;
guarde en un array los segundos pares;
cuando termine, recorra el array;
muestre solamente los valores mayores a 5.

El resultado final debería ser:

6
8
10
*/



    /*  void Update()
      {
          if (!ProgramaTerminado)
          {
              tiempo += Time.deltaTime;  // El motor de tiempo acumula fracciones de segundo cuadro por cuadro

              if (tiempo >= 1)  // Cada vez que pasa 1 segundo real
              {
                  segundos++; // Avanzamos el segundo (1, 2, 3...)
                  tiempo = 0; // Reiniciamos el cronómetro


              }

              if (segundos % 2 == 0) // Condición 1: ¿Es un segundo par?
              {
                  numerosPares[posicionArray] = segundos; // Guardamos el número en el array
                  posicionArray++;                        // Pasamos al siguiente espacio
              }

              // Condición 2: ¿Ya llegamos al límite de 10 segundos?
              if (segundos >= 10)
              {
                  ProgramaTerminado = true; // Cerramos el candado para congelar el Update

                  // Recorremos el array final con un bucle for
                  for (int i = 0; i < numerosPares.Length; i++)
                  {
                      // Condición 3: Mostrar solamente los valores mayores a 5
                      if (numerosPares[i] > 5)
                      {
                          Debug.Log(numerosPares[i]); // Imprime: 6, luego 8, luego 10
                      }
                  }
              }
          }
    */


    /*El Escudo de Energía
Conceptos a repasar: float, bool, if, Update(), Time.deltaTime.
• Objetivo: Crea un script donde un personaje tenga un escudo de energía dinámico.
• Instrucciones:
1. Declara una variable float llamada energiaEscudo que empiece en 100.0f.
2. Declara una variable bool llamada escudoActivo que empiece en true.
3. En el método Update(), si el escudo está activo (true), debes reducir la energía constantemente a un ritmo de 5.0f unidades por segundo real usando Time.deltaTime.
4. Añade una condición if: si la energía llega a 0 o menos, el escudo debe apagarse (escudoActivo = false) y debes mostrar un mensaje en consola que diga "¡Escudo desactivado!".

*/


    void Update()
    {
        if (escudoActivo)
        {
            energiaEscudo -= 5f * Time.deltaTime;
          

            if (energiaEscudo <= 0)
            {
                escudoActivo=false;
                energiaEscudo = 0;
                Debug.Log("Energia Agotada");
            }
           








        }







    }


}





