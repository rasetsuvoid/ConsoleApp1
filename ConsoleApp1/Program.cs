// Clase static Console -- WriteLine method (parametros)
using ConsoleApp1;

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

string ternario = 1 > 2 ? "True" : "False";

if (1 > 3)
{

}else if (1 > 4)
{

}
else
{

}


for (int i = 0; i < 10; i++)
{
    // Clase static Console -- WriteLine method (parametros)
    Console.WriteLine(i);
}

List<string> list = new List<string>();

list.Add("Item 1");
list.Add("Item 2");


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

List<string> list2 = new List<string>();

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