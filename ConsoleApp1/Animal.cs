using System;
using System.Collections.Generic;
using System.Text;

//ConsoleApp1.Domain
//Console-app1.Domain
// snake_case NO USARLO
// CamelCase (ConsoleApp1)
namespace ConsoleApp1
{
    // Clase Animal
    // Modificador de acceso: public,
    // private,
    // protected,
    // internal,
    // protected internal,
    // private protected
    public class Animal
    {
        // Constructor por defecto
        // ctor
        public Animal() { }

        // Propiedad Nombre
        // Tipo de dato: string
        // Modificador de acceso: public
        // Nombre de la propiedad: Nombre
        // metodos accesores get y set
        public string Nombre { get; set; }
        //prop
        public string Especie { get; set; }
        public int Edad { get; set; }

        // Metodo HacerSonido
        // Modificador de acceso: public
        // Tipo de retorno: void -> no retorna nada
        // Nombre del metodo: HacerSonido
        // Parametros: ninguno
        public void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        // Metodo ObtenerInformacion
        // Modificador de acceso: public
        // Tipo de retorno: string -> retorna una cadena de texto
        public string ObtenerInformacion()
        {
            // Retorna la informacion del animal
            return $"Nombre: {Nombre}, Especie: {Especie}, Edad: {Edad}";
        }
    }
}
