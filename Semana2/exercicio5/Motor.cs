namespace Semana2.exercicio5
{
    internal class Motor
    {
        double cilindrada;
        Carro carroInstalado;

        public Motor(double cilindrada)
        {
            this.cilindrda = cilindrada;
        }

        public double Cilindrada { get { return cilindrada; } private set { } }

        public Carro CarroInstalado { get { return carroInstalado; } set { carroInstalado = value; } }
    }
}
