using exercise1_manage_recipe;
using System.Text.Json;

Console.WriteLine("Hello, World!");

RecipeManager recipeManager = new RecipeManager();

recipeManager.AddRecipe(new Recipe { Title="Modified",  Instructions="new modified"});
recipeManager.AddRecipe(new Recipe { Title = "Modifieddasd", Instructions = "new moddasdasified" });

