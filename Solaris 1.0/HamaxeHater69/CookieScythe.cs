using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class CookieScythe : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 14;
			item.melee = true;
			item.width = 50;
			item.height = 40;
			item.shoot = 45;
			item.shootSpeed = 30f;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 2700;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Scythe");
			Tooltip.SetDefault("Dedicated to cookie, also a useful weapon.");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 15);
			recipe.AddIngredient(ItemID.Wood, 45);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
