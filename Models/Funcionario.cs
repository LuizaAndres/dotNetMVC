using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models{
    public class Funcionario{
//funcao do c# que deixa fazer os sets e gets mais facil
        public int ID { get; set; }
        public string Nome {get; set; }
        public string Cpf {get; set; }
//contrutor de funcionario
        public Funcionario (int id, string nome, string cpf){
//nao usa this por causa do linhaa 3 
            ID=id;
            Nome=nome;
            Cpf=Cpf;
            RepositoryFuncionario.addFuncionario(this);
        }
//funcao que retorna a lista de funcionarios
        public static List<Funcionario> func(){
            return RepositoryFuncionario.returnFunc();
        }
        /*public override string toString(){
            returns $"{ID} - {Nome} - {Cpf}";
        }*/
    }
}