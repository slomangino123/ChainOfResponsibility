public class Result
{
    public FoodType? FoodType { get; set; }

    public static Result Fail => new Result { FoodType = null};
    public static Result Success(FoodType type) => new Result { FoodType = type };
}
