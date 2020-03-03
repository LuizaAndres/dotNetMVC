
using System.Collections.Generic;

//simular banco de dados
namespace Repositories{
    public class RepositoryFuncionario{
//lista tipo model.funcionarios que chama funcionario
        private static List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();
//metodo que retorna a lista funcionarios
        public static List<Models.Funcionario> returnFunc(){
            
            return funcionarios;
        }
//metodo que adiciona funcionario na lista
        public static void addFuncionario(Models.Funcionario funcionario){
            funcionarios.Add(funcionario);
        }
    }
}