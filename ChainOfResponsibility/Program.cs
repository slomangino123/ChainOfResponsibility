using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");


var services = new ServiceCollection();

services.AddTransient<VegetableIdentifier>();
services.AddTransient<MeatIdentifier>();
services.AddTransient<FruitIdentifier>();
services.AddTransient<DessertIdentifier>();
services.AddTransient<PoultryIdentifier>();
services.AddTransient<Terminator>();

services.AddScoped<FoodWorker>();

var sp = services.BuildServiceProvider();

var foodWorker = sp.GetRequiredService<FoodWorker>();

await foodWorker.DoWork(new ChainContext { Dish = "Orange" });
await foodWorker.DoWork(new ChainContext { Dish = "Orange Creamsicle Icecream" });
await foodWorker.DoWork(new ChainContext { Dish = "Steak" });
await foodWorker.DoWork(new ChainContext { Dish = "Chicken" });
await foodWorker.DoWork(new ChainContext { Dish = "Chicken Pot Pie" });
