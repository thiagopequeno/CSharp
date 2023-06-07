using System;

class aula06{

static void Main(){
    // \t tabulacao como se fosse Tab para dar um espaçamento formatação de console
    int n1,n2,n3;
    n1=10;
    n2=10;
    n3=10;
    // talvez nao precise usar String.format da pra formatar assim
    // Console.WriteLine("\n n1= \t{0}\n n2=\t{1}\n n3=\t{2}",n1,n2,n3);

    double valorCompra=5.50;
    double valorVenda;
    double lucro=0.1;
    string produto="Pastel";

    valorVenda=valorCompra+(valorCompra*lucro);

    // o que é este 15 no indice 0 ?? este é o tamanho do espaço que vai ter entre o nome do atributo e o valor
    Console.WriteLine("Produto......:{0,15}",produto);

    // o que é este c nas chaves ?? é o tipo de formatação que vai ser aplicado no valor no caso moeda 
    Console.WriteLine("Val.Compra......:{0,15:c}",valorCompra);

    // o que é este p ?? é o tipo de formatação que vai ser aplicado no valor no caso porcentagem
    Console.WriteLine("Lucro......:{0,15:p}",lucro);

    Console.WriteLine("Val.venda......:{0,15:c}",valorVenda);

    // o que é este f2 ?? é o tipo de formatação que vai ser aplicado no valor  no caso numero com 2 casas decimais


    
    
    

}
}