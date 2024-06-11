using exercise1_manage_recipe;
using System.Text.Json;

public class RecipeManager
{
    private const string FilePath = "recipes.json";
    public void AddRecipe(Recipe recipe)
    {
        List<Recipe> recipes = new List<Recipe>();
        recipes.Add(recipe);
        SaveData(recipes);
    }
    public void EditRecipe(string title, Recipe recipe) { }
    public List<Recipe> ListRecipes { get { return new List<Recipe>(); } }
    public void AddCategory(string category) { }
    public void EditCategory(string category) { }

    private void SaveData(List<Recipe> recipes)
    {
        var jsonString = JsonSerializer.Serialize(recipes);
        File.WriteAllText(FilePath, jsonString);
    }
    private List<Recipe> LoadData()
    {
        if (!File.Exists(FilePath)) return new List<Recipe> { };
        var jsonString = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<Recipe>>(jsonString);
    }

}

