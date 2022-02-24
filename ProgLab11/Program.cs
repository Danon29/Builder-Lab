using System;

namespace ProgLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            var builder1 = new SaladBuilder1();
            var builder2 = new SaladBuilder2();
            director.Builder = builder1;


            Console.WriteLine("Just cucumbers");
            director.JustCucumbers();
            Console.WriteLine(builder1.EatSalad().ListParts());

            Console.WriteLine("Full Salad");
            director.FullSalad();
            Console.WriteLine(builder1.EatSalad().ListParts());

            Console.WriteLine("Custom ingridients");
            builder1.CutSecondIngridient();
            builder1.CutThirdIngridient();
            Console.WriteLine(builder1.EatSalad().ListParts());

            director.Builder = builder2;

            Console.WriteLine("Just carrots");
            director.JustCucumbers();
            Console.WriteLine(builder2.EatSalad().ListParts());

            Console.WriteLine("Full Salad");
            director.FullSalad();
            Console.WriteLine(builder2.EatSalad().ListParts());

            Console.WriteLine("Custom ingridients");
            builder2.CutSecondIngridient();
            builder2.CutFirstIngridient();
            Console.WriteLine(builder2.EatSalad().ListParts());
        }
    }
}
