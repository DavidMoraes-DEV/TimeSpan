using System;

namespace _TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O TimeSpan representa uma duração e é um tipo valor(struct)
             
             AGENDA:
            Representação interna
            instanciação: construtores, fields, métodos From, Parse*/

            TimeSpan t1 = new TimeSpan(0, 1, 30); /*Essa função do TimeSpan irá contar a duração de 0horas 1minuto e 30 segundo (Foi utilizado o construtor de 3 argumento porém existem outros*/
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); /*Quantidade de Ticks que tem essa duração*/

            Console.WriteLine();
            TimeSpan t2 = new TimeSpan(); /*CONSTRUTOR do TimeSpan padrão(vazio)*/
            Console.WriteLine(t2);

            Console.WriteLine();
            TimeSpan t3 = new TimeSpan(900000000L); /*CONSTRUTOR do TimeSpan por quantidade de Ticks*/
            Console.WriteLine("CONSTRUTOR do TimeSpan por quantidade de Ticks: " + t3);

            Console.WriteLine();
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); /*CONSTRUTOR do TimeSpan por quantidade de Dias, horas, minutos, segundos*/
            Console.WriteLine("CONSTRUTOR do TimeSpan por quantidade de Dias, horas, minutos, segundos: " + t4);

            Console.WriteLine();
            TimeSpan t5 = new TimeSpan(2, 20, 30, 45, 321); /*CONSTRUTOR do TimeSpan por quantidade de Dias, horas, minutos, segundo e milisegundos*/
            Console.WriteLine("CONSTRUTOR do TimeSpan por quantidade de Dias, horas, minutos, segundo e milisegundos: " + t5);
            
            /*MÉTODOS FROM*/
            
            Console.WriteLine();
            TimeSpan t6 = TimeSpan.FromDays(1.5); /*From é um conjunto de métodos que podemos utilizar para definir um TimeSpan, nesse exemplo utilizamos o From de Dias e definimos sua duração como 1.5(equivalente a um dia e meio de duração*/
            Console.WriteLine("TimeSpan.FromDays: " + t6);

            Console.WriteLine();
            TimeSpan t7 = TimeSpan.FromHours(1.5); /*Definimos pelo método FromHours a duração do TimeSpan de 1.5 (equivalente a uma hora e meia)*/
            Console.WriteLine("TimeSpan.FromHours: " + t7);

            Console.WriteLine();
            TimeSpan t8 = TimeSpan.FromMinutes(1.5); /*Define a duração equivalente por minuto 1.5(equivalente a 1 minuto e meio)*/
            Console.WriteLine("TimeSpan.FromMinutes: " + t8);

            Console.WriteLine();
            TimeSpan t9 = TimeSpan.FromSeconds(1.5); /*Define a duração equivalente por segundo 1.5(equivalente a 1 segundo e meio)*/
            Console.WriteLine("TimeSpan.FromSeconds: " + t9);

            Console.WriteLine();
            TimeSpan t10 = TimeSpan.FromTicks(90000000); /*Define a duração equivalente por ticks 900000(equivalente a 90.000.000 milhões ticks)*/
            Console.WriteLine("TimeSpan.FromTicks: " + t10);
        }
    }
}
