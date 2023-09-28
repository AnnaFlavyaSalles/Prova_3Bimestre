using System;

namespace Prova_3Bimestre;
class Prova
{
	static void Main(string[] args)
	{
        Console.Write("Digite o nome do funcionário: ");
		string nome = Console.ReadLine();
       
        Console.Write("Digite o CPF do funcionário: ");
		int cpf = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Digite a matrcula do funcionário: ");
        int matricula = Convert.ToInt32(Console.ReadLine());
       
        Console.Write("Digite a data de nascimento do funcionário: ");
        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
      
        Console.Write("Digite o sexo do funcionário: ");
        string sexo = Console.ReadLine();

        Console.Write("Digite o  CRM (registro no conselho) do funcionário: ");
        string crm = Console.ReadLine();

        Console.Write("Digite o tempo de hora extra do funcionário: ");
        double horaExtra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a especialidade do funcionário: ");
        string especialidade = Console.ReadLine();

        Console.Write("Digite a função do funcionário: ");
        string funcao = Console.ReadLine();

        Console.Write("Digite o salário do funcionário: ");
        double salario = Convert.ToDouble(Console.ReadLine());


        Funcionario f = new Funcionario(nome,cpf,matricula,dataNascimento,sexo,salario);
       
        Medico m = new Medico(nome, cpf, matricula, dataNascimento, sexo, salario, crm ,horaExtra,especialidade);

        Administrativo a = new Administrativo(nome, cpf, matricula, dataNascimento, sexo, salario,funcao);
       


        while (true) 
		{
            Console.WriteLine("Qual tipo de funcionário você deseja cadastrar? 1-Cadastrar Médico e 2- Funcionário Administrativo");
            int escolha = Convert.ToInt32(Console.ReadLine());
            double salarioTotal = 0;
           
            if(escolha == 1)
            {
                Console.WriteLine($"O salário do médico é de {(salario + 0.22).ToString("0.00")}");

            }

            else if (escolha == 2) 
            {
                Console.WriteLine($"O salário do funcionário administrativo é de {((salario + 250.00) + 0.17).ToString("0.00")}");
            }

        }
	}
}