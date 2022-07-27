using System;

namespace T10_Ejerciocio3
{
    class Password
    {
        private int longitud;


        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        private string contraseña;

        public string getContraseña()
        {
            return contraseña;
        }


        public Password()
        {
            longitud = 8;
            contraseña = generaPass(longitud);

        }

        public Password(int _longitud)
        {
            this.longitud = _longitud;
            this.contraseña = generaPass(_longitud);
        }

        public string generaPass(int _longitud)
        {
            string charsPass = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();
            char[] pass = new char[_longitud];
            for (int i = 0; i < _longitud; i++)
            {
                pass[i] = charsPass[random.Next(0, charsPass.Length)];
            }
            //Convierto en el return el array en string.
            return new string(pass); //Sería como decir string x = new string(pass)
        }

        public bool esFuerte(string _contraseña)
        {
            //Convierto en un array Char la contraseña en string
            char[] passAChar = _contraseña.ToCharArray();
            int counter = 0, counter1 = 0, counter2 = 0;
            bool esFuerte = false;
            for (int i = 0; i < passAChar.Length; i++)
            {

                if (char.IsUpper(passAChar[i]))
                {
                    counter++;
                }
                if (char.IsLower(passAChar[i]))
                {
                    counter1++;
                }
                if (char.IsDigit(passAChar[i]))
                {
                    counter2++;
                }
            }
            if (counter > 2 && counter1 > 1 && counter2 > 5)
            {
                esFuerte = true;
            }
            return esFuerte;
        }
    }
}