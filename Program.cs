namespace aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                /*
                int num, tab;
                Console.WriteLine("Digite um numero para exibir a tabuada");
                num = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                while(i <= 10)
                {
                    tab = num * i;
                    Console.WriteLine(num + " x " + i + " = " + tab);
                    i++;
                }
                */

            int num, fat = 1, i;
            Console.WriteLine("Digite um número para calcular o fatorial:");
            num = Convert.ToInt32(Console.ReadLine());
            //inicialização
            i = 1; // i = num
            while (i <= num) //while (i >= 1)
            {
                fat = i * fat;
                i++; //incremento  i-- decremento
            }
            Console.WriteLine(num + "! = " + fat);
        }
    }
}
