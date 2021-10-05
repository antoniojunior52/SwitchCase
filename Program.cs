using System;

namespace SwitchCase
{
    class Program 
    {
        static void Main(string[] args)
        {
           {
            int m = 0;
        
            
            
            Console.WriteLine (" Digite o número correspondente ao mês");
            
            
            Console.WriteLine(" Janeiro    (1)");
         
            Console.WriteLine(" Fevereiro  (2)");
           
            Console.WriteLine(" Março      (3)");
            
            Console.WriteLine(" Abril      (4)");
           
            Console.WriteLine("  Maio      (5)  ");
            
            Console.WriteLine(" Junho       (6) ");
          
            Console.WriteLine("  Julho      (7)  ");
            
            Console.WriteLine(" Agosto      (8)  ");
          
            Console.WriteLine(" Setembro   (9)  ");
          
            Console.WriteLine(" Outubro    (10)  ");

            Console.WriteLine(" Novembro   (11)  ");
            
            Console.WriteLine(" Dezembro   (12)  ");
            Console.WriteLine("_________");
            Console.WriteLine("");
            Console.WriteLine("Digite o número do mês correspondência:");
            m = Convert.ToInt32(Console.ReadLine());
           }
              switch (m)
              {
                 case 1:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 2:
               Console.WriteLine("O MÊS DIGITADO POSSUI 28 OU 29  SE FOR ANO BISSEXTO");
               break;

               case 3:
               Console.WriteLine("O MÊS DIGIATDO POSSUI 31 DIAS");
               break;

               case 4:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 5:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 6:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 7:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 8:
               Console.Writeline("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 9:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 10:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS");
               break;

               case 11:
               Console.WriteLine("O MÊS DIGITADO POSSUI 30 DIAS");
               break;

               case 12:
               Console.WriteLine("O MÊS DIGITADO POSSUI 31 DIAS, O QUE VOCÊ VAI ME DAR DE NATAL?? ");
               break;

               default:
               Console.WriteLine("SE VOCÊ ACHA QUE TEMOS MAIS DE 12 MESES POR FAVOR PROCURE UM PSIQUIATRA");
               break;
              }
           
              
           

            

        }
    }
}