using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nome, CPF,matrícula, data de nascimento, sexo, salário. 

namespace Prova_3Bimestre
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }

        public int Matricula { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public double Salario { get; set; }

        public Funcionario(string nome, int cpf, int matricula,DateTime dataNascimento,string sexo,double salario) 
        {
            Nome = nome;
            Cpf = cpf;  
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Salario = salario;

        }    
    }
}
