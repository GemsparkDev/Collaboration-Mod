using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class NokiaHammer : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 130;
			item.melee = true;
			item.width = 99;
			item.height = 99;
			item.useTime = 20;
			item.useAnimation = 20;
			item.hammer = 1400;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 100;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nokia Hammer");
			Tooltip.SetDefault("Perfect for bashing in the skull of the four eyed.");
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 120);
			recipe.AddIngredient(ItemID.FragmentNebula, 120);
			recipe.AddIngredient(ItemID.FragmentSolar, 120);
			recipe.AddIngredient(ItemID.FragmentStardust, 120);
			recipe.AddIngredient(ItemID.LunarBar, 70);
			recipe.AddIngredient(ItemID.Glass, 300);
			recipe.AddIngredient(ItemID.Pwnhammer, 1);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
