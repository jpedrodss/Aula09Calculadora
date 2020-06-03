namespace Aula09Calculadora
{
    public class Calculadora
    {

        public double[] num = new double[4];

        public double Soma(){
            return num[0] + num[1];
        }
        public double Subtracao(){
            return num[0]- num[1];
        }
        public double Divisao(){
            return num[0] / num[1];
        }
        public double Multiplicacao(){
            return num[0] * num[1];
        }
    }
}