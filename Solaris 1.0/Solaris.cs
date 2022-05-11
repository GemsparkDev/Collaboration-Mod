using Terraria.ModLoader;
using Terraria.ID;

namespace Solaris
{
	public class Solaris : Mod
	{
		public override void AddRecipes() {
			// Here is an example of a recipe.
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrystalBlock, 1);
			recipe.SetResult(ItemID.Fake_newchest1, 1);
			recipe.AddRecipe();
			// Here is an example of a recipe.
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.SetResult(ItemID.Fake_newchest2, 1);
			recipe.AddRecipe();
			// Here is an example of a recipe.
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddIngredient(ItemID.FragmentNebula, 8);
			recipe.SetResult(ItemID.IronPickaxe, 1);
			recipe.AddRecipe();
			// Here is an example of a recipe.
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.AddIngredient(ItemID.FragmentStardust, 8);
			recipe.SetResult(ItemID.IronPickaxe, 1);
			recipe.AddRecipe();
		}
	}
}