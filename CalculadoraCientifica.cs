namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        char[] separadores = {' ', ',', '.', ':'};
        string texto;

        public double Media(){
            return (num[0] + num [5]) / num.Length;
        }
    }
}