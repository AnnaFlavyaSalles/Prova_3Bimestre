using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3Bimestre
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }
        public Administrativo(string nome, int cpf, int matricula, DateTime dataNascimento, string sexo, double salario, string funcao) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            Funcao = funcao;
        }

    
    }
}
