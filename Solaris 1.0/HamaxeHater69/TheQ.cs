using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class TheQ : ModItem
	{

		public override void SetDefaults()
		{

			item.damage = 40;
			item.ranged = true;
			item.width = 80;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2f;
			item.UseSound = SoundID.Item34;
			item.value = 1253000;
			item.rare = 9;
			item.autoReuse = true;
			item.shoot = 85;
			item.shootSpeed = 7.5f;
			item.useAmmo = AmmoID.Gel;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Questionable Atom Burner");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flamethrower, 30);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
