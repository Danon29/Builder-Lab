using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab11
{
    public class SaladBuilder1 : IBuilder
    {
        private Salad salad = new Salad();

        public SaladBuilder1()
        {
            this.Clean();
        }

        public void Clean()
        {
            this.salad = new Salad();
        }

        public void CutFirstIngridient()
        {
            this.salad.Add("Cucumber");
        }

        public void CutSecondIngridient()
        {
            this.salad.Add("Tomato");
        }

        public void CutThirdIngridient()
        {
            this.salad.Add("Onion");
        }

        public Salad EatSalad()
        {
            Salad food = this.salad;

            this.Clean();

            return food;
        }

    }
}
