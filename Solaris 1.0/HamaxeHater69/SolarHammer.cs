using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class SolarHammer : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 110;
			item.melee = true;
			item.width = 46;
			item.height = 44;
			item.tileBoost = 4;
			item.useTime = 30;
			item.useAnimation = 20;
			item.hammer = 100;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 100;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Hammer");
			Tooltip.SetDefault("");
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 8);
			recipe.AddIngredient(ItemID.LunarBar, 6);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
