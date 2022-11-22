namespace Semana2.exercicio5
{
    internal class Carro
    {
        string placa;
        string modelo;
        Motor motor;

        public Carro(string placa, string modelo, Motor motor)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.motor = motor;
        }

        public string Placa { get { return placa; } private set { } }
        public string Modelo { get { return modelo; } private set { } }

        public Motor Motor
        {
            get { return motor; }
            set
            {
                if (value != null)
                {
                    motor = value;
                }
            }
        }

        public void AlterarMotor(Motor motor)
        {
            if (motor.CarroInstalado == null)
            {
                Motor = motor;
                motor.CarroInstalado = this;
            }
        }

        public string VelocidadeMaxima()
        {
            if (Motor.Cilindrada < 1.0)
            {
                return "140 Km/h";
            }
            else if (Motor.Cilindrada < 1.6)
            {
                return "160 Km/h";
            }
            else if (Motor.Cilindrada < 1.8)
            {
                return "200 Km/h";
            }
            else if (Motor.Cilindrada > 2.0)
            {
                return "220 Km/h";
            }
            else
            {
                return "";
            }


        }
    }
}
