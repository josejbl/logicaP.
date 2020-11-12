using System;

namespace Estruturas_condicionais
{
    class Program
    {
        static void Main(string[] args)
        { 
          
             float nota1, nota2, nota3, media; 
            string nomeCompleto;
            string nomedaEscola;
            float numeroDaturma;

            Console.Write("Digite o numero da turma do Aluno");
            numeroDaturma = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o  nome da Escola");
            nomedaEscola = Console.ReadLine();

            Console.WriteLine("Digite o nome do aluno ");
            nomeCompleto =Console.ReadLine();




            Console.Write("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());

            media = (nota1+nota2+nota3)/3;

            if(media>5){
                Console.WriteLine("O Aluno "+nomeCompleto+" da escola "+nomedaEscola+" da turma "+numeroDaturma+" está aprovado com a media de "+media);
            }else{
                Console.WriteLine("O Aluno "+nomeCompleto+"da escola"+nomedaEscola+"da turma"+numeroDaturma+"está reprovado com a media de não desista"+media);


            }       
            
        }
    }
}
