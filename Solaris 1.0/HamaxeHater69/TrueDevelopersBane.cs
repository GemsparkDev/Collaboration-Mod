using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class TrueDevelopersBane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TrueDevelopersBane"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Dedicated to all of the dumbasses who make this mod possible.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 120;
			item.height = 120;
			item.shoot = 137;
			item.shootSpeed = 5f;
			item.useTime = 30;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 30;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1000);
			recipe.AddIngredient(ItemID.LunarBar, 100);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(ItemID.RocketLauncher, 1);
			recipe.AddIngredient(null, "DevelopersBane", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void HoldItem(Player player)
		{   player.statDefense /= 3;
		}
	}
}