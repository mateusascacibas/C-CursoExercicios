using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Enumeracao
{
    class MenuExerciciosEnumeracao
    {
        
            public static void MenuEnumeracaoExercicios()
            {
                while (Globais.op != 5)
                {
                Menus.MenuSessao09Enumeracao.MenuEnumeracão();
                    Globais.op = Convert.ToInt32(Console.ReadLine());
                    if (Globais.op == 1)
                    {
                        Enumeracao.MenuEnumeracao();
                    }
                    else if (Globais.op == 2)
                    {
                        Limpar.LimparTela();
                        break;
                    }
                    
                    else
                    {
                        Linha.Linha_Delimitadora();
                        Console.WriteLine("Digite um valor valido.");

                    }

                    Limpar.LimparTela();
                }
            }
        }
    }
