namespace Exerciocio04
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double Calculo(double cotacao, double QtdCompra ){
            double calc = cotacao * QtdCompra;
            double calc1 = calc * IOF;            
            return calc + calc1;
        }
                
        

    }
}