﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
     class ControlCalculadora
    {
        // criando um objeto calculadora na mémoria
        ModelCalculadora calculadora = new ModelCalculadora();

        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora();
        }// fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número");
            this.calculadora.GetSetNum3 = Convert.ToDouble(Console.ReadLine());
        }// fim do coletar

        public int Menu()
        {
            Console.WriteLine("-----Menu-----"                            +
                              "\n0.  Sair"                                + 
                              "\n1.  Somar"                               +
                              "\n2.  Subtrair"                            +
                              "\n3.  Dividir"                             +
                              "\n4.  Multiplicar"                         +
                              "\n5.  Potência"                            +
                              "\n6.  Raiz"                                +
                              "\n7.  Tabuada"                             +
                              "\n8.  Conversão de binário para decimal"   +
                              "\n9.  Conversão de decimal para binário"   +
                              "\n10. Hexadecimal para decimal "           +
                              "\n11. Decimal para Hexadecimal"            +
                              "\n12. Bhaskara"                            +
                              "\n13. BinarioHexadecimal"                  +
                              "\n14. Dobro é Triplo"                      +
                              "\n15. Retorno de porcentagem do salário: " +
                              "\n16. Par ou Impar:"                       +
                              "\n17. Soma de inteiros"                    +
                              "\n18. Tabuada sua escolha"                 +
                              "\n19. Sequencia"                           +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }// fim do método menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {


                opcao = Menu();
                Console.Clear();//limpa tela 
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Imposivel dividir por zero!: ");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Dividir());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;
                    case 13:
                        Console.WriteLine("Informe um valor em binário");
                        string binario = Console.ReadLine();
                        Console.WriteLine(this.calculadora.ConverterBinarioHexadecimal(binario));
                        break;
                    case 14:
                        Console.WriteLine("Informe um valor: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.DobroTriplo());
                        break;
                    case 15:
                        Console.WriteLine("Informe seu salário");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nO seu salário final é: " + this.calculadora.Retorno());
                        break;
                    case 16:
                        Console.WriteLine("Informe um valor: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n" + this.calculadora.ParouInpar());
                        break;
                    case 17:                      
                        Console.WriteLine("\nA soma dos inteiros de 1 a 100 é: " + this.calculadora.SomaInteiro());
                        break;
                    case 18:
                        Console.WriteLine("Informe um valor: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe outro valor: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n" + this.calculadora.TabuadaEscolha(num1,num2));
                        break;
                    case 19:
                        Console.WriteLine("Informe um valor: ");
                        int numI = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe outro valor: ");
                        int numF = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n" + this.calculadora.Sequencia(numI, numF));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não e valida: ");
                        break;
                }// fim do swith
            } while (opcao != 0); // fim do while 
        }// fim operação









    }//Fim da classe
}// fim do projeto
