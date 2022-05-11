using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{

	public class SolarDrill : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 50;
			item.melee = true;
			item.width = 54;
			item.height = 30;
			item.shoot = 432;
			item.shootSpeed = 15f;
			item.useTime = 15;
			item.useAnimation = 25;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 225;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Drill");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 12);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
