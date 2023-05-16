public class FoodWorker : ChainWorker
{
    public FoodWorker(
        FruitIdentifier fruit,
        VegetableIdentifier vegetable,
        MeatIdentifier meat,
        PoultryIdentifier poultry,
        DessertIdentifier dessert,
        Terminator terminator)
        : base(fruit,
               vegetable,
               meat,
               poultry,
               dessert,
               terminator)
    {
    }
}
