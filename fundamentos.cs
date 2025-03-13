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
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


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
            Console.WriteLine("Estoy saludando desde el espacio 2");
        }
    }
}
class Variables()
{
    public void variables()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("VARIABLES");
        int x; //declaracion
        x =12; // inicializacion
        int y = 78; // declaracion e inicializacion
        int suma= x + y;
        int edad= 50;
        int peso=20;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(suma);
        Console.WriteLine("tu edad es: "+edad);
        Console.WriteLine("tu peso es de: "+peso);

        Console.WriteLine("La suma de  x E y es: "+suma);
        
        Console.WriteLine("Booleanos");
        bool comparar = edad==peso;
        Console.WriteLine("el booleano es: "+comparar);
        Console.WriteLine("Chars");
        char simbolo ='#';
        Console.WriteLine("el char es : "+simbolo);
        Console.WriteLine("String");
        string animal = "gato";
        Console.WriteLine("el string es: "+animal);

        Console.WriteLine("-------------------------");
    }
}
class Constantes()
{
    public void constantes()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("CONSTANTES");
        const double Gravedad= 9.8; // const=paarametro de constante y double para numeros decimales limitados
        Console.WriteLine("la gravedad es de: "+Gravedad);
        Console.WriteLine("-------------------------");
    
    }
}
class TypeCasting()
{
    public void typeCasting()
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("TypeCasting");
        double gravedad=9.8;
        int Entero = Convert.ToInt32(gravedad); // el metodo convert.ToInt32 redondea doubles a enteros
        string EsUnString=Convert.ToString(gravedad);// si bien en la consola seguira apareciendo "9.8" sera en formato string
        string Falso="false";
        bool Mifalso= Convert.ToBoolean(Falso);



        Console.WriteLine("la gravedad redondeada es de: "+Entero);
        Console.WriteLine("esto esta en foramto string: "+EsUnString);
        Console.WriteLine(EsUnString.GetType());// para corroborar mediante consola que la declaracion"EsUnString" estae n formato string
        Console.WriteLine("esto esta pasado a formato booleano: "+Mifalso);
        Console.WriteLine("-------------------------");
    }
}



//tambien podriamos, para seguir practicando el contexto de ejecucion de c#, intentar crer dos saludos desde un mismo namespace
class programaSaludo
{
    static void Main(string[] arg)
    {
        primerSpace.Saludo1 obj1= new primerSpace.Saludo1();
        segundoSpace.Saludo2 obj2=new segundoSpace.Saludo2();
        Variables variablesInstancia = new Variables();
        Constantes ConstantesInstancia = new Constantes();
        TypeCasting TypeCasting = new TypeCasting();
        

        obj1.Saludo();
        obj2.Saludo();
        SumarNumeros(); 
        variablesInstancia.variables();
        ConstantesInstancia.constantes();
        TypeCasting.typeCasting();
        
        
        
    
        
    }
    static void SumarNumeros()
    {
     try{
        Console.Write("ingrese el primer numero: ");
        String? input1 = Console.ReadLine();
        if (string.IsNullOrEmpty(input1))
        {
            Console.WriteLine("entrada no valida");
            return;
        }
        int num1 =int.Parse(input1);
       

        Console.Write("ingrese el segundo numero: ");
        string? input2 = Console.ReadLine();
        if(string.IsNullOrEmpty(input2))
        {
            Console.WriteLine("entrada no valida");
            return;
        }
        int num2 =int.Parse(input2);
       

        int resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es {resultado}");

        
     }
     catch (FormatException)
     {
        Console.WriteLine("ingrese un numero valido");
     }
    }
    
}

/* si bien dentro del contexto de ejecucion de c# solo podemos tener un punto de entrada, el main estatico, podemos sobrecargar la clase donde se encuentra con otros main estaticos que si bien , NO son el punto de inicio nos sirven para poder ejecutar diferentes tipos de actividades
Para eso aparte dle codigo voy aa proporcionar un sistema de suma en un main estatico diferente en el codigo que ya utilizamos arriba  para demostarlo
*/
//======================================================================================================//
/*
una vez que entendemos el metodo de ejecucion vamos a VARIABLES.
dentro de las variables no vamos a ir a sus tipos sino que vamos a ir a su procedimientos para entenderlas mejor
A la hora de crear una variable, al ser c# un progrma con un tipado fuerte primero debemos declarar el tipo de dato para poder utilizarlo.
el tipado hace que a un entero podamos declararlo para posteriormente inicializarlo o ambas al mismo tiempo

CONSTANTES
Las constantes nos sirven para declarar o inicializar datos que no querramos que cambien su valor

TypeCasting
estos metodos los utilizamos para convertir valores a distintos tipos de datos ejemplo: de numeros decimales a enteros, string, double a string o incluso bolleanos
*/




