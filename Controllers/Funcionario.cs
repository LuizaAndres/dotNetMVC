
using System.Collections.Generic;
using Models;
using Repositories;


namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class FuncionarioController{
        private static List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();
//adiciona funcionario no model        
        public static void addFuncionario(int id, string nome, string cpf){
            new Models.Funcionario(id, nome, cpf);
        }
//retorna funcionario pro view
        public static List<Funcionario> returnFunc(){
            return RepositoryFuncionario.returnFunc();
        }
    }
}