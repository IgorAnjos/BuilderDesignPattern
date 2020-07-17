namespace builderDesignPattern.Builders.Base
{
    using Domain;
    using Domain.ValueObject;

    public interface IPizzaBuilder
    {
        void PreparaBorda(Borda borda);

        void PreparaMassa(PizzaSize pizzaSize);

        void InsereIngredientes();

        void DefineValor();

        void TempoForno();

        Pizza GetPizza();
    }
}