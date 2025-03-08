/* 
c# es un lenguaje de tipado fuerte, esto quiere decir que a la hora de trabajar con el vamos a tener que especificar el dato con el que queremos trabajar
======================================================================================================
en primer lugar mediante el "console" accedemos a la consola, le otorgamos una operacion que en este caso seria writeline para invocar una linea de tipo string y le otorgamos el contenido al string con el uso de las comillas

observacion: podemos ver como el Console seria una especie de clase al que le otorgamos un metodo mediante el punto(.),en otras palabras si tenemos que describirlo paso a paso su funcionamiento quedaria algo asi:
paso 1: invocamos console ,al mismo tiempo que lo posicionamos como una clase
paso 2: con el punto(.) estamos accediendo dentro de la clase y seleccionar un metodo
paso 3: seleccionamos como metodo "WriteLine"
PASO 4: otorgamos el string que deseamos que contenga la operacion


==============Console.WriteLine("Fundamentos con C#")========== 

*/

//este codigo no es ejecutable desde este archivo para ejecutarlo tendriamos que correr el codigo desde el archivo .csproj, esto se debe a que el elemento se esta ejecutando dentro de dicho proyecto. si quisieramos crear uno de forma independiente tendriamos que crear un nuevo fichero con su respectivo main.

/*======================================================================================================

using System;


    class Fundamentos
{
    static void Main (String[]args)
    {
        Console.WriteLine("Fundamentos de c#");
    }
}
*/

/*
vayamos por partes:
paso 1: mediante la operacion "using" indicamos que estamos importando desde "System" nuestras clases y operaciones tales como "Console"

paso 2: como sabemos c# sigue una linealidad POO , es decir orientada a objetos. esto nos obliga a enmarcar todo nuestro codigo dentro de una class que denominamos "Fundamentos"

paso 3: Analizamos la linea 
[static void Main (String[]args)]
el "main" nos indica desde donde se ejecuta el programa o su punto inicial de ejecucion, el "static" lo usamos para indicar que el metodo seleccionado es propio de la clase y que no corresponde a una estancia especifica, y por ultimo "string[]args" es un parametro que usamos para asignarle un argumento a el contenido del parametro para poder invocarlo desde el "console"
Luego tenemos la linea de codigo que ya vimos antes "Console.WriteLine("fundamentos de C#") en donde invocames de la lista de nombres de system al console para asignarle un metodo WriteLine y poder imprimir texto con su respectivo salto de linea;
*/

//===================================================================================================//

/*
en el anterior ejemplo vimos algo tan simple como la ejecucion de un string en un unico contexto de ejecucion, pero y si quisieramos proponer muchos metodos de contextos. 
Ahi entra "namespace"
*/

using System;

namespace primerSpace
{
    class Saludo1
    {
        public void Saludo()
        {
            Console.WriteLine("estoy saludando desde el espacio 1");
        }
    }
}

namespace segundoSpace
{
    class Saludo2
    {
        public void Saludo()
        {
            Console.WriteLine("estoy saludando desde el espacio 2");
        }
    }
}

class programaSaludo
{
    static void Main(){
        primerSpace.Saludo1 obj1= new primerSpace.Saludo1();
        segundoSpace.Saludo2 obj2= new segundoSpace.Saludo2();

        obj1.Saludo();
        obj2.Saludo();

    }
}

//nota crear sistema de cuentas en diferentes name spaces