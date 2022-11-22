namespace Semana2.exercicio5
{
    internal class Motor
    {
        double cilindrda;
        Carro carroInstalado;

        public Motor(double cilindrda)
        {
            this.cilindrda = cilindrda;
        }

        public double Cilindrada { get { return cilindrda; } private set { } }

        public Carro CarroInstalado { get { return carroInstalado; } set { carroInstalado = value; } }
    }
}
