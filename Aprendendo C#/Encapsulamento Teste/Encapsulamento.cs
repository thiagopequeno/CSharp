using System;

class Encapsulamento
{
    int numero;  
    // Construtor em C#
    // public aula08(int valorInicial){
    //     this.numero=valorInicial;
    // }

     public int GetNumero()
    {
        return numero;
    }

    public void SetNumero(int novoNumero){
        this.numero=novoNumero;   
    }
}

class testeEncapsulamento{

    static void Main()
    {
        Encapsulamento exemplo = new Encapsulamento();
       //construindo objeto numero com valor INICIAL, FICAR ATENDO POIS NAO PEDI PARAMETROS aula08 exemplo = new aula08(10);
        
        int v1, v2, soma;
        string nome;
        exemplo.SetNumero(10);
        v1 = exemplo.GetNumero();
        Console.WriteLine(v1);
        
    }
}