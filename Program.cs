using System;
using View;

namespace dotNetMVC
{
    public class Program
    {
        public static void Main(){
//adiciona funcionarios na view
            FuncionarioView.addFuncionario(1,"Jacks", "1321");
            FuncionarioView.addFuncionario(2,"João", "1231");
            FuncionarioView.addFuncionario(3,"José", "13215");
            
//retorna os cadastros            
           FuncionarioView.returnFunc();
        }
    }
    
}
