using System;

class Aula08{
    static void Main(){
        // Pegando um valor inteiro do console, no console recebemos String e no codigo abaixo
        // transformamos em variavel do tipo INT
        // int teste=int.Parse((Console.ReadLine()));
        // Console.WriteLine(teste);

        int v1,v2,soma;

        string nome;

        Console.Write("Digite o primeiro nome: ");
            nome=Console.ReadLine();
            Console.WriteLine("Nome digitado: {0}",nome);
            Console.Write("Digite o primeiro valor: ");
            v1=int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            // MEIOS DE CONVERTER PARA INT O QUE VEM DO CONSOLE EM STRING 
            // INT.PARSE(CODIGO DENTRO)
            // Convert.ToInt32(codigo Dentro)
            v2=Convert.ToInt32((Console.ReadLine()));
            soma=v1+v2;
            Console.WriteLine("A soma de {0} e {1} é igual a {2}",v1,v2,soma);

    }
}