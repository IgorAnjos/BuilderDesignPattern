namespace builderDesignPattern.Builders.Base
{
    using Processors;
    using Domain;

    public abstract class PizzaBuilderBase
    {
        protected Pizza Pizza = null;
        protected readonly ICalculaValor CalculaValor;

        protected PizzaBuilderBase(ICalculaValor calculaValor)
        {
            CalculaValor = calculaValor;
        }

        public virtual void DefineValor()
        {
            CalculaValor.DefineValor(Pizza);
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