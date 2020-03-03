using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;


namespace Controllers {
    //: é uma interface permite instanciacao de atributos
    public class FuncionarioController{
        public static List<Funcionario> funcionarios(){
            return FuncionarioController.funcionarios();
        }
        public static void addFuncionario(int id, string nome, string cpf){
            new Funcionario(id, nome, cpf);
        }
    }
}