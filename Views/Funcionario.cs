using System;
using Models;

namespace View{
    public class FuncionarioView {
        public static void addFuncionario(int id, String nome, string cpf){
        Controllers.FuncionarioController.addFuncionario(id, nome, cpf);
        }
        public static void returnFunc(){
             foreach (Models.Funcionario funcionario in Controllers.FuncionarioController.returnFunc())
            {
                Console.WriteLine(funcionario);
            }
        }               
    }
}