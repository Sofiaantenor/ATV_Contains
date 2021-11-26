using System;

namespace ATV_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            // O CONTAINS(STRING) RETORNA UM VALOR QUE INDICA SE UMA SUBCADEIA ESPECIFICADA OCORRE NESTA CADEIA DE CARACTERES
            // O exemplo a seguir determina se a cadeia de caracteres digitada pelo usuário é uma subcadeia de caracteres da cadeia de caracteres fixa. Se for encontrado na cadeia de caracteres será TRUE (verdadeiro), caso não seja será FALSE (falso)
            
            string f1 = "Desenvolvendo um algoritmo para manipular uma string utilizando o método CONTAINS";
            string f2 = "um";
            Console.WriteLine(" ");
            Console.WriteLine("                                  MÉTODO CONTAINS                                      ");
            Console.WriteLine($"    {f1}");
            Console.Write(" Digite aqui algo para que verifiquemos se isso está contido ou não na frase a cima:  ");
            f2 = Console.ReadLine(); 
            bool teste = f1.Contains(f2);
            Console.WriteLine(" ");
            Console.WriteLine($"'{f2}' está contido em '{f1}':  {teste} ");
            Console.WriteLine(" ");

            
        }
    }
}
