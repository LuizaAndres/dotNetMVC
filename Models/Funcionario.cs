using System.Collections.Generic;
using Repositories;

namespace Models{
    public class Funcionario{
        // {get; set; } funcao do c# que deixa fazer os sets e gets mais facil, dispensa o uso do this
        private int ID { get; set; }
        public string Nome {get; set; }
        public string Cpf {get; set; }
        //contrutor de funcionario
        public Funcionario (int id, string nome, string cpf){
            ID=id;
            Nome=nome;
            Cpf=cpf;
            RepositoryFuncionario.addFuncionario(this);
        }
        //funcao que retorna a lista de funcionarios
        public static List<Funcionario> returnFunc(){
            return RepositoryFuncionario.returnFunc();
        }
        public override string ToString(){
            return $"{ID} - {Nome} - {Cpf}";
        }
    }
}