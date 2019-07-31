using AmazingAgendaConsoleApp.DomainModel;
using System;

namespace AmazingAgendaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crio uma variável do que aponta para TaskItem
            TaskItem myFirstTask;

            //Instancio a classe TaskItem e 
            //faço a variável apontar para ela
            myFirstTask = new TaskItem();

            //=========== Preencho "myFirstTask ===========
            myFirstTask.id = Guid.NewGuid(); //Gera um identificador aleatório
            myFirstTask.title = "Comprar Água";
            myFirstTask.description = "Comprar no Guanabara (está na promoção).";
            myFirstTask.dateTime = DateTime.Now;
            myFirstTask.done = false;
            //==============================================

            //=========== Imprimir "myFirstTask" ===========
            Console.WriteLine("Id: " + myFirstTask.id);
            Console.WriteLine("Title: " + myFirstTask.title);
            Console.WriteLine("Description: " + myFirstTask.description);
            //==============================================

            //Tarefa!!!!!!!!!!!!!
            //1) Pedir para o usuário digitar o título 
            //e trocar seu valor no "myFirstTask"

            //2) Pedir para o usuário digitar description
            //e trocar seu valor no "myFirstTask

            //Imprimir novamente os atributos de "myFirstTask"

            Console.ReadKey();

        }
    }
}
