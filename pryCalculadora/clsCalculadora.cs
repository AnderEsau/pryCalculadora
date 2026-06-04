namespace pryCalculadora
{
    internal class clsCalculadora
    {
        //Atributos de entrada
        private float numero1;
        private float numero2;
        //Atributo pero es de salida
        private float Resultado;

        //Uso de propiedades set y get
        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        //Funciones o métodos
        public float Sumar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }

        public float Restar()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;
        }

        public float Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }

        public float Dividir()
        {
            Resultado = Numero1 / Numero2;
            return Resultado;
        }
        //Leo hizo eso

        public float potencia;
        //Hice esto ander

        public float cuadratica;
        // Hice esto lary
    }
}
