namespace builderDesignPattern.Builders
{
    using Base;
    using builderDesignPattern.Domain.ValueObject;
    using builderDesignPattern.Processors;
    using Domain;

    public class PizzaQuente : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaQuente(ICalculaValor calculaValor) : base(calculaValor) { }

        public void PreparaBorda(Borda borda)
        {
            this.Pizza.Borda = borda;
        }

        public void PreparaMassa(PizzaSize pizzaSize)
        {
            this.Init();

            this.Pizza.PizzaType = PizzaType.Salgada;
            this.Pizza.PizzaSize = pizzaSize;
        }

        public void InsereIngredientes()
        {
            this.Pizza.Sabor = "Quente";
            this.Pizza.IngredientesType = IngredientesType.Ovo |
                                          IngredientesType.Mussarela |
                                          IngredientesType.Provolone |
                                          IngredientesType.Jaba |
                                          IngredientesType.Majericao |
                                          IngredientesType.Cheddar |
                                          IngredientesType.Bacon |
                                          IngredientesType.Azeitona;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 20;
        }
    }
}