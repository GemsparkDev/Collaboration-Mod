using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle2 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 1);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("AR 15");
			Tooltip.SetDefault("A Heavy duty rifle. Has a 25% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 56;
			item.height = 24;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

    		recipe = new ModRecipe(mod);
    		recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(this);
   			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .25f;
		}
    }
}