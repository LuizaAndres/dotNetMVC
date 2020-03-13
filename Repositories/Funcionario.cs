using System.Collections.Generic;
namespace Repositories{
    public class RepositoryFuncionario{
        private static List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();
        //metodo que retorna a lista funcionarios pro control
        public static List<Models.Funcionario> returnFunc(){
            return funcionarios;
        }
        //metodo que adiciona funcionario na lista
        public static void addFuncionario(Models.Funcionario funcionario){
            funcionarios.Add(funcionario);
        }
    }
}