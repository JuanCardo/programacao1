using System;
class Principal{
    static void Main(){
        float a=0,b=0,c=0; // Dados de Entrada
        double delta=0,x1,x2;
        while(a==0 || delta<0){ // Laço de Repetição
            Console.Write("Digite valor a: ");
            a=float.Parse(Console.ReadLine());           
            if(a==0) { // Estrutura de decisão - Valida valor do "a"
                Console.Write("Impossivel Calcular\n----------\n");
                continue; // volta para o começo do Loop
            }
            Console.Write("Digite valor b: ");
            b=float.Parse(Console.ReadLine()); // Converte tipo da variavel (string para float)
            Console.Write("Digite valor c: ");
            c=float.Parse(Console.ReadLine());
            delta=(Math.Pow(b,2) - (4*a*c)); // Calculo do Delta
            Console.Write("O Valor do delta é: {0}\n", Math.Round(delta,2)); // Arredonda numeros quebrados para 2 casas          
            if(delta<0) {  // Estrutura de decisão - Valida valor do "delta"
                Console.Write("Impossivel Calcular\n----------\n");
                continue;
            }
            else if(delta==0){ // Calculos das Raizes Reais
                x1=((-1*b) + Math.Sqrt(delta)) / (2*a);
                Console.Write("A raiz real é x1={0}",x1);
            }
            else{
                x1=((-1*b) + Math.Sqrt(delta)) / (2*a);
                x2=((-1*b) - Math.Sqrt(delta)) / (2*a);
                Console.Write("As raizes reais x1= {0} x2= {1}\n", Math.Round(x1,2), Math.Round(x2,2));
            }
        }       
    } 
}