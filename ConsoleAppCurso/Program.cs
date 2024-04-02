using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ds = 0;
            int Adm = 0;
            int Edf = 0;
            int Meca = 0;
            double total = 0;
            string resp;
            Console.WriteLine("Deseja começar? (S/N)");
            resp = Console.ReadLine().ToUpper();
            while (resp == "S")
            {
                Console.WriteLine("Qual curso o aluno deseja se matricular? [Ds -Desenv. , Adm-Administração, Edf-Edificações, Meca - Mecatrônica]");
                string curso = Console.ReadLine().ToUpper();
                switch (curso)

                {
                    if case "Ds":
                        if (Ds <= 5)
                        {
                            Ds++;
                            Console.WriteLine("Qual é o nome do aluno?:");
                            Console.WriteLine("Matrícula em Desenvolvimento de Sistemas concluída com sucesso!:");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível realizar a matrícula:");

                        }
                        break;
                    case "Adm":
                        {
                            if (Adm <= 5)
                            {
                                Adm++;
                                Console.WriteLine("Qual é o nome do aluno?:");
                                Console.WriteLine("Matrícula em Administração concluída com sucesso!:");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível realizar a matrícula:");

                            }
                            break;
                    case "Meca":
                                {
                                    if (Meca <= 5)
                                    {
                                        Meca++;
                                        Console.WriteLine("Qual é o nome do aluno?:");
                                        Console.WriteLine("Matrícula em Mecatrônica concluída com sucesso!:");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não foi possível realizar a matrícula:");

                                    }
                                    break;
                        case "Edf":
                                        {
                                            if (Edf <= 5)
                                            {
                                                Edf++;
                                                Console.WriteLine("Qual é o nome do aluno?:");
                                                Console.WriteLine("Matrícula em Administração concluída com sucesso!:");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Não foi possível realizar a matrícula:");

                                            }
                                            break;



                                            Console.WriteLine("Vagas Restantes: " +)
                            " Desenv.: " + (5 - contD) +
                            " Administração:" + (5 - contA) +
                            " Meacatrônica:" + (5 - contM) +
                            " Edificações:" + (5 - contE));
                                            Console.WriteLine("Deseja fazer mais alguma matrícula?: (S/N)");
                                            resp = Console.ReadLine().ToUpper().Substring(0, 1);
                                            Console.Clear();
                                        }
                                        Console.WriteLine("Alunos matriculados:" +
                                                    " Desenv.: " + contD +
                                                    " Administração:" + contA +
                                                    " Meacatrônica:" + contM +
                                                    " Edificações:" + contE +
                                                    "Total e matrículas " + (contD + contA + contM + contE));
                                        Console.ReadKey();



                                }
                        }
                    }
