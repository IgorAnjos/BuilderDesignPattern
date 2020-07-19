using System;
using System.Linq;

namespace builderDesignPattern.Processors
{
    using Domain;
    using Domain.ValueObject;
    
    public class CalculaValor : ICalculaValor
    {
        public void DefineValor(Pizza pizza)
        {
            var totalIngrediente = Enum.GetValues(typeof(IngredientesType)).Cast<Enum>().Count(pizza.IngredientesType.HasFlag);

            /*
             *  Expressão apra calculo do valor total da pizza
             *
             *  (Total de Ingradientes x R$ 1,70) + ( o tamanho da pizza x R$ 10,00) + (se for doce mais R$ 10,00) +
             *  (Se a borda for de chocolate é o tamanho da borda x R$ 5,00 e se for salgada x R$ 2,00)             
             */
            var valorIngredientes = totalIngrediente * 1.70;
            var valorTamanho = (int)pizza.PizzaSize * 10;
            var valorTipo = pizza.PizzaType == PizzaType.Doce ? 10 : 0;

            var valorBorda = 0;

            if (pizza.Borda != null)
            {
                valorBorda = pizza.Borda.BordaType == BordaType.Chocolate
                    ? (5 * (int)pizza.Borda.BordaSize)
                    : (2 * (int)pizza.Borda.BordaSize);
            }

            pizza.Valor = valorIngredientes + valorTamanho + valorTipo + valorBorda;
        }
    }
}