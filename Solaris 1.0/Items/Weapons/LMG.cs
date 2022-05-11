using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class LMG : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("LMG");
			Tooltip.SetDefault("A heavy duty rifle with a high fire rate. Has a 33% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 62;
			item.height = 24;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 8;
			item.shootSpeed = 20;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

    		recipe = new ModRecipe(mod);
    		recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(this);
   			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .33f;
		}
    }
}