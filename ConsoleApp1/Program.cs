
using ConsoleApp1;

// Clase static Console -- WriteLine method (parametros)
Console.WriteLine("Hello, World!");
//Console.ReadLine();

// if (true)
if (1 > 2)
{
    // Clase static Console -- WriteLine method (parametros)
    Console.WriteLine("This is true.");
}
else
{

}

// típo de dato string
// nombre de la variable: ternario
// operador ternario
// condicion ? valorSiVerdadero : valorSiFalso
string ternario = 1 > 2 ? "True" : "False";


if (1 > 3)
{

}else if (1 > 4)
{
    Console.WriteLine("Else if");
}
else
{

}

// for loop
// variable de control: i
// inicializacion: int i = 0
// condicion: i < 10
// incremento: i++ +1
for (int i = 0; i < 10; i++)
{
    // Clase static Console -- WriteLine method (parametros)
    Console.WriteLine(i);
}

// crear una lista de strings

// List<T> -> clase generica
// T -> tipo de dato generico
// string -> tipo de dato especifico
// list -> nombre de la variable
// new -> palabra reservada para crear una instancia
// List<string>() -> constructor de la clase List<T>
List<string> list = new List<string>();

// agregar elementos a la lista
list.Add("Item 1");
list.Add("Item 2");
list.Add("Item 3");


// recorrer la lista con foreach
// foreach -> palabra reservada para recorrer colecciones
// string item -> variable de control
// in list -> coleccion a recorrer
foreach (string item in list)
{
    Console.WriteLine(item);
}


// tipos de datos.
string miCadena = "Hola Mundo";
int longitud = 1;
long longitudLarga = 10000000000;
float numeroDecimal = 10.5f;
decimal numeroDecimal2 = 20.5m;
bool esVerdadero = true;
char caracter = 'A';
var numeroInferido = "sasd";
var numeroInferid2 = 10;

byte[] bytes = new byte[10];

List<int> list2 = new List<int>();

// Crear una instancia de la clase Animal

// Instanciacion 
// Objecto MiAnimal
// Animal -> Tipo de dato
// miAnimal -> Nombre del objecto
// new -> palabra reservada para crear una instancia
// Animal() -> Constructor de la clase Animal
Animal miAnimal = new Animal();

// Asignar valores a las propiedades del objeto miAnimal

miAnimal.Nombre = "Firulais";
miAnimal.Especie = "Perro";
miAnimal.Edad = 5;

// viajar entre clases con control + clic 

// Llamar al metodo HacerSonido del objeto miAnimal

miAnimal.HacerSonido();

// Llamar al metodo ObtenerInformacion del objeto miAnimal

string informacion = miAnimal.ObtenerInformacion();

Console.WriteLine(informacion);