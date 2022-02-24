using System;
using System.Collections.Generic;
using System.Text;

namespace ProgLab11
{
    public class Salad
    {
        private List<object> ingredients = new List<object>();

        public void Add(string ingridient)
        {
            this.ingredients.Add(ingridient);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += this.ingredients[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}