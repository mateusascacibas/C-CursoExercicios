using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (Globais.op_cate != 0) {
                Linha.Linha_Delimitadora();
                Console.WriteLine("Curso C# - Exercicios");
                Linha.Linha_Delimitadora();
                Console.WriteLine("");
                MenuInicial.MenuDeInicio();
                Globais.op_cate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (Globais.op_cate)
                {
                    case 1:
                        Logica.MenuExerciciosLogica.MenuLogicaExercicios();
                        break;
                    case 2:
                        Classes.MenuExerciciosClasse.MenuClasseExercicios();                       
                        break;
                    case 3:
                        Construtor.MenuExerciciosConstrutor.MenuConstrutorExercicios();
                        break;
                    case 4:
                        VetorEListas.MenuExerciciosVetor.MenuVetorExercicios();
                        break;
                    case 5:
                        Enumeracao.MenuExerciciosEnumeracao.MenuEnumeracaoExercicios();
                        break;
                    case 0:
                        Limpar.LimparTela();
                        break;
                    default:
                        Linha.Linha_Delimitadora();
                        Console.WriteLine("Digite um valor valido.");
                        Limpar.LimparTela();
                        break;
                }
            }
        }
    }
}
