using System;
using System.Collections.Generic;

namespace desafio56
{
    class Program
    {
        static void Main(string[] args)
        {
            List<usuario> cadastro = new List<usuario>();
            string continuar = "S";
            int escolha = 0;
            int consult = 0;
            string consultno = "S";
            string buscar;
            int consultRA = 0;
            string mesmo = "sim";
            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("*****CADASTRO DE ALUNOS******");
                Console.WriteLine("Digite 1 = para incluir\n  2 para excluir\n digite 3 para consultar");
                escolha = Convert.ToInt32(Console.ReadLine());
                mesmo = "S";

                if (escolha == 1)
                {
                    while (mesmo.ToUpper() == "S")
                    {
                        var item = new usuario();

                        Console.Write("informe o nome: ");
                        item.nome = Console.ReadLine();

                        Console.Write("informe o RA: ");
                        item.RA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("informe data de nascimento: ");
                        item.datansc = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("informe seu RG: ");
                        item.rg = Console.ReadLine();

                        Console.Write("informe seu CPF: ");
                        item.cpf = Console.ReadLine();

                        Console.Write("informe seu sexo (M/F): ");
                        item.sexo = Console.ReadLine();

                        Console.Write("informe seu email: ");
                        item.email = Console.ReadLine();

                        cadastro.Add(item);

                        Console.Write("deseja incluir outro aluno (S/N)? ");
                        mesmo = Console.ReadLine();




                    }
                }

                else if (escolha == 2)
                {
                    var excluir = new usuario();
                    Console.WriteLine("Qual nome deseja encontrar e excluir: ");
                    buscar = Console.ReadLine();
                    foreach (var item in cadastro)
                    {
                        if (buscar == item.nome)
                        {
                            excluir = item;
                        }
                    }
                    cadastro.Remove(excluir);
                }
                else if (escolha == 3)
                {
                    var consulta = new usuario();
                    Console.WriteLine("Deseja consultar [1] - nome [[ [2] - RA : ");
                    consult = Convert.ToInt32(Console.ReadLine());
                    if (consult == 1)
                    {
                        Console.WriteLine("Consulta via nome: ");
                        Console.WriteLine("digite o nome: ");
                        consultno = Console.ReadLine();
                        foreach (var item in cadastro)
                        {
                            if (consultno == item.nome)
                            {
                                
                                Console.WriteLine("Nome: " + item.nome);
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Data de nascimento: " + item.datansc);
                                Console.WriteLine("RG: " + item.rg);
                                Console.WriteLine("CPF: " + item.cpf);
                                Console.WriteLine("SEXO: " + item.sexo);
                                Console.WriteLine("EMAIL: " + item.email);

                            }

                        }

                    }

                    else if (consult == 2)
                    {
                        var cosultme = new usuario();
                        Console.WriteLine("Consulta via RA: ");
                        Console.WriteLine("digite o RA: ");
                        consult = Convert.ToInt32(Console.ReadLine());

                        foreach (var item in cadastro)
                        {
                            if (consult == item.RA)
                            {
                                
                                Console.WriteLine("Nome: " + item.nome);
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Data de nascimento: " + item.datansc);
                                Console.WriteLine("RG: " + item.rg);
                                Console.WriteLine("CPF: " + item.cpf);
                                Console.WriteLine("SEXO: " + item.sexo);
                                Console.WriteLine("EMAIL: " + item.email);

                            }
                        }
                    }
                }

            }
        }

    }
}

