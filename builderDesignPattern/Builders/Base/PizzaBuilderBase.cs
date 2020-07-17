namespace builderDesignPattern.Builders.Base
{
    using builderDesignPattern.Processors;
    using Domain;

    //using Processors;
    public abstract class PizzaBuilderBase
    {
        protected Pizza Pizza = null;
        protected readonly ICalculaValor CalculaValor;

        protected PizzaBuilderBase(ICalculaValor calculaValor)
        {
            CalculaValor = calculaValor;
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }

        protected void Init()
        {
            Pizza = new Pizza();
        }
    }
}
