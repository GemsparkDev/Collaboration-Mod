using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle7 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 1);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AK54");
			Tooltip.SetDefault("A semi-automatic burst rifle. Has a 75% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 200;
			item.ranged = true;
			item.width = 58;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 8;
			item.shootSpeed = 16;
			item.useAmmo = AmmoID.Bullet;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}
    }
}