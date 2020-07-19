namespace builderDesignPattern.Director
{
    using builderDesignPattern.Builders.Base;
    using builderDesignPattern.Domain;
    using builderDesignPattern.Domain.ValueObject;

    public class CardapioServices
    {
        public void PrepararPizzaSemBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.InsereIngredientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }

        public void PrepararPizzaComBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize, Borda borda)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.PreparaBorda(borda);
            pizzaBuilder.InsereIngredientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }
    }
}