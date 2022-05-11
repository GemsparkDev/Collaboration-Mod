using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle4 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunting Rifle");
			Tooltip.SetDefault("A large hunting rifle with a high damage.");
		}
        public override void SetDefaults()
		{
			item.damage = 110;
			item.ranged = true;
			item.width = 48;
			item.height = 12;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 2;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.TissueSample, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}