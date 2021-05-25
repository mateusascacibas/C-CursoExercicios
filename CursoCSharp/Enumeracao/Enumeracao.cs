using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Enumeracao
{
    class Enumeracao
    {
        public static void MenuEnumeracao()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Para sair digite 0 \n");
            Globais.op_ex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            switch (Globais.op_ex)
            {

                case 0:
                    break;
                case 1:
                    Exercicio01();
                    break;
                case 2:
                    Exercicio02();
                    break;
                case 3:
                    //Exercicio03();
                    break;
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");

                    Limpar.LimparTela();
                    MenuEnumeracao();
                    break;
            }


        }

        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            int contratos;
            
            int i = 0;
            string calcular;
            double calculado = 0;

            funcionario f1 = new funcionario();
            Console.WriteLine("Entre com o nome do Departamento: ");
            
            f1.departmentName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do funcionario: ");
            Console.WriteLine("Nome: ");
          
            f1.nome = Console.ReadLine();
            Console.WriteLine("Level: (Junior/Intermediario/Senior)");
            
            f1.lovel = Console.ReadLine();
            Console.WriteLine("Salario Base: ");
       
            f1.salario_base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos contratos possui?");
           
            contratos = Convert.ToInt32(Console.ReadLine());

            string[] datas = new string[contratos];
            double[] valor_hora = new double[contratos];
            double[] duracao = new double[contratos];

            while (i < contratos)
            {
                Console.WriteLine("Entre com o contrato " + (i + 1) + " º:");
                Console.WriteLine("Data: ");
            
                datas[i] = Console.ReadLine();
                Console.WriteLine("Valor por hora: ");
             
                valor_hora[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Duração: ");
               
                duracao[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Entre mês e ano para calcular: ");
          
            calcular = Console.ReadLine();
            i = 0;
            while(i < contratos)
            {
                if (datas[i].Contains(calcular))
                {
                    calculado += valor_hora[i] * duracao[i];
                }
                i++;
            }
            calculado += f1.salario_base;

            Console.WriteLine("Nome: " + f1.nome + "\nDepartamento: " + f1.departmentName + "\nGanho em " + calcular + ": R$ " + calculado);
        }

        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("Entre com os dados do cliente: ");

            Cliente cli = new Cliente();
            Console.WriteLine("Nome: ");
            cli.nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            cli.email = Console.ReadLine();
            Console.WriteLine("Data de aniversario: (DD/MM/YYYY) ");
            cli.date = Convert.ToDateTime(Console.ReadLine());

            Pedido ped = new Pedido();
            Console.WriteLine("Status: ");
            ped.status = Console.ReadLine();

            Itens item = new Itens();
            Console.WriteLine("Quantos itens tem seu pedido? ");
            item.quantidade = Convert.ToInt32(Console.ReadLine());
            int i = 0;
           

            Produto prod = new Produto();
            double[] preco = new double[item.quantidade];
            string[] nome = new string [item.quantidade];
            double[] preco_total = new double[item.quantidade];
            double final = 0;
            while (i < item.quantidade)
            {
                Console.WriteLine("Item " + (i+1) + ": ");
                Console.WriteLine("Nome do produto: ");
                prod.nome = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                prod.preco = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quantidade: ");
                prod.quant = Convert.ToInt32(Console.ReadLine());
                preco[i] = prod.preco;
                nome[i] = prod.nome;
                preco_total[i]  = prod.preco * prod.quant;
                final += preco_total[i];

                i++;
               
            }

            Console.WriteLine("Ordem: ");
            Console.WriteLine("Momento do pedido: " + ped.momento);
            Console.WriteLine("Status do pedido: " + ped.status);
            Console.WriteLine("Cliente: " + cli.nome + " " + cli.date + " " + cli.email);
            Console.WriteLine("Itens: ");

            int j = 0;
            while (j < item.quantidade)
            {
                Console.WriteLine(nome[j] + ", R$" + preco[j] + " Quantidade: " + prod.quant + " Subtotal: " + preco_total[j]);
                j++;
            }

            Console.WriteLine("Preço total: " + final);


        }
    }
}
