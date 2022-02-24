using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab11
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void JustCucumbers()
        {
            this.builder.CutFirstIngridient();
        }

        public void FullSalad()
        {
            this.builder.CutFirstIngridient();
            this.builder.CutSecondIngridient();
            this.builder.CutThirdIngridient();
        }
    }
}
