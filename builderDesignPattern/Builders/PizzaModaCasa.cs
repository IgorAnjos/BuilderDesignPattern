namespace builderDesignPattern.Builders
{
    using Base;
    using Domain;
    using Domain.ValueObject;
    using Processors;

    public sealed class PizzaModaCasa : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaModaCasa(ICalculaValor calculaValor) : base(calculaValor) { }

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
            this.Pizza.Sabor = "Moda da Casa";
            this.Pizza.IngredientesType = IngredientesType.Alho |
                                          IngredientesType.Bacon |
                                          IngredientesType.Jaba |
                                          IngredientesType.Ovo |
                                          IngredientesType.Salame |
                                          IngredientesType.Mussarela |
                                          IngredientesType.Azeitona |
                                          IngredientesType.Cebola |
                                          IngredientesType.Tomate |
                                          IngredientesType.Provolone|
                                          IngredientesType.Ervilha |
                                          IngredientesType.Majericao;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 28;
        }
    }
}