using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class DevelopersBane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DevelopersBane"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Slices even the strongest of gods into 2 pieces, for a price of course.");
		}

		public override void SetDefaults() 
		{
			item.damage = 500;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.shoot = 45;
			item.shootSpeed = 15f;
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
			recipe.AddIngredient(ItemID.DirtBlock, 100);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void HoldItem(Player player)
		{   player.statDefense /= 2;
		}
	}
}