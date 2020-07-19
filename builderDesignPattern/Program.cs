using System;

namespace builderDesignPattern
{
    using Director;
    using Domain;
    using Domain.ValueObject;
    using Builders;
    using Builders.Base;
    using Processors;

    /*
       Builder 

        Intenção

            - "Separar a construção de um obejto complexo de sua representação de modo que
                o processo de construção possa criar diferentes representações".

        Vantagens do padrão Builder

        - O padrão builder permite ao desenvolvedor esconder detalhes de como os objetos são criados
        - O padrão Builder permite ao desenvolvedor um grande variedade de representações internas do objeto a ser construído
        - Cada Builder é independente de outros e do restante da aplicação
            - provê modularidade
            - simplifica a adição no novos Builders
        - Provê grande controle sobre a criação de objetos complexos
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            var _calValor = new CalculaValor();

            IPizzaBuilder pizzaQuenteBuilder = new PizzaQuente(_calValor);
            IPizzaBuilder pizzaModaCasaBuilder = new PizzaModaCasa(_calValor);

            var cardapioService = new CardapioServices();

            #region Pizza 1 - Pizza Quente com Borda

            cardapioService.PrepararPizzaComBorda(pizzaQuenteBuilder, PizzaSize.Grande,
                new Borda
                {
                    BordaType = BordaType.Cheddar,
                    BordaSize = BordaSize.Grossa
                });

            var pizzaQuenteComBorda = pizzaQuenteBuilder.GetPizza();

            #endregion

            #region Pizza 2 - Pizza Quente sem Borda

            cardapioService.PrepararPizzaSemBorda(pizzaQuenteBuilder, PizzaSize.Normal);

            var pizzaQuenteSemBorda = pizzaQuenteBuilder.GetPizza();

            #endregion

            #region Pizza 3 - Pizza Moda da Casa com Borda

            cardapioService.PrepararPizzaComBorda(pizzaModaCasaBuilder, PizzaSize.Familia,
                new Borda
                {
                    BordaType = BordaType.Catupiry,
                    BordaSize = BordaSize.Fina
                });
            var pizzaModaCasaComBorda = pizzaModaCasaBuilder.GetPizza();

            #endregion

            View("Primeiro pedido", pizzaQuenteComBorda);
            View("Segundo pedido", pizzaQuenteSemBorda);
            View("Terceiro pedido", pizzaModaCasaComBorda);
        }

        public static void View(string msg, Pizza pizza)
        {
            Console.WriteLine($"{pizza.Sabor} | {pizza.Valor:C} | {pizza.TempoFornoMin} min | {pizza.PizzaSize.ToString()}");
        }
    }
}
