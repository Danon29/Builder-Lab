using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab11
{
    public class SaladBuilder2 : IBuilder
    {
        private Salad salad = new Salad();

        public SaladBuilder2()
        {
            this.Clean();
        }

        public void Clean()
        {
            this.salad = new Salad();
        }

        public void CutFirstIngridient()
        {
            this.salad.Add("Carrot");
        }

        public void CutSecondIngridient()
        {
            this.salad.Add("Potato");
        }

        public void CutThirdIngridient()
        {
            this.salad.Add("Сabbage");
        }

        public Salad EatSalad()
        {
            Salad food = this.salad;

            this.Clean();

            return food;
        }

    }
}
