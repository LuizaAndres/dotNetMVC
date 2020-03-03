using System;
using Models;
using Controllers;

namespace view{
    public class FuncionarioView {
        public static void Funcionario(){
            FuncionarioController.addFuncionario(1,"Jacks", "1321");
            FuncionarioController.addFuncionario(2,"João", "1231");
            FuncionarioController.addFuncionario(1,"José", "13215");
            foreach (Funcionario Funcionario in Models.Funcionario.func())
            {
                Console.WriteLine(Funcionario);
            }
        }
    }
}