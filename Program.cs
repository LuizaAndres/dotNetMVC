using System;
using View;
namespace dotNetMVC
{
    public class Program
    {
        public static void Main(){
            int op =0;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine(
                    "1 - Adicionar funcionario\n"+
                    "2 - Ver lista de funcionarios\n"+
                    "0 - Sair \n"
                );
                try {
                    op = Convert.ToInt32(Console.ReadLine());
                } catch {
                Console.WriteLine ("Digite um número");
                op = 99;
                }
                switch (op)
                {
                    case 1:{
                        Console.WriteLine("Adicionar funcionario");
                        View.FuncionarioView.addFuncionario();
                        break;
                    }
                    case 2:{
                        Console.WriteLine("Lista de funcionarios");
                        FuncionarioView.returnFunc();
                        Console.WriteLine("\n");
                        break;
                    }
                    case 0:{
                        Console.WriteLine("\nTchau\n ");
                        break;
                    }
                    default:{
                        Console.WriteLine("\nNÚMERO INVÁLIDO\n ");
                        break;
                    }
                }
            }while(op!=0);  
        }
    }
}