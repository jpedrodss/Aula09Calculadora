namespace Aula09Calculadora
{
    public class Calculadora
    {

        public double[] num = new double[4];

        public double Somar(){
            return num[0] + num[1];
        }
        public double Subtrair(){
            return num[0] - num[1];
        }
        public double Dividir(){
            return num[0] / num[1];
        }
        public double Multiplicar(){
            return num[0] * num[1];
        }
    }
}