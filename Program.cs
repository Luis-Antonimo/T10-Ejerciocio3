using System;

namespace T10_Ejerciocio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba el tamaño de los passwords (mínimo recomendanle 8): ");
            int _longitud2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba cuántos passwords desea generar: ");
            int _numPasswords = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Declaro un array de objetos
            Password[] passwords = new Password[_numPasswords];
            //Declaro array de booleanos relacionados con la fortaleza de la contraseña
            bool[] passEsFuerte = new bool[_numPasswords];

            for (int i = 0; i < _numPasswords; i++)
            {
                //Primero inicializamos cada objeto del array de objetos y usando el segundo constructor
                passwords[i] = new Password(_longitud2);
                //Generamos el password
                Console.Write(passwords[i].generaPass(_longitud2)+" ");
                //Analizo el password a la vez que analizo si es fuerte.
                Console.WriteLine(passEsFuerte[i] = passwords[i].esFuerte(passwords[i].getContraseña()));                
            }
        }
    }
}