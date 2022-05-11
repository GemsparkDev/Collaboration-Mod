using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class SolarAxe : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 100;
			item.melee = true;
			item.width = 56;
			item.height = 56;
			item.tileBoost = 4;
			item.useTime = 25;
			item.useAnimation = 20;
			item.axe = 135;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Axe");
			Tooltip.SetDefault("");
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 6);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
