using System;
namespace View{
    public class FuncionarioView {
        //requere infos do funcionario    
        public static void addFuncionario(){
            int id = Controllers.FuncionarioController.returnFunc().Count+1;
            Console.WriteLine("Digite o Nome");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            String cpf = Console.ReadLine();
            //adiciona funcionario na lista
            Controllers.FuncionarioController.addFuncionario(id, nome, cpf);
        }
        //retorna funcionarios para a main
        public static void returnFunc(){
             foreach (Models.Funcionario funcionario in Controllers.FuncionarioController.returnFunc())
            {
                Console.WriteLine(funcionario);
            }
        }               
    }
}