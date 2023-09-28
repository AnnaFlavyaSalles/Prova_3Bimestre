using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CRM(registro no conselho), valor de hora extra e especialidade

namespace Prova_3Bimestre
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico (string nome, int cpf, int matricula, DateTime dataNascimento, string sexo, double salario,string crm, double horaExtra, string especialidade):base(nome,cpf,matricula,dataNascimento,sexo,salario)
        {
            CRM = crm;
            HoraExtra = horaExtra;
            Especialidade = especialidade;
        }

    }
}
