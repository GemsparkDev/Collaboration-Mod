using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class AutoPistol : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MP5K");
			Tooltip.SetDefault("A small automatic sidearm. Has a 25% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 36;
			item.height = 20;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7;
			item.value = 50000;
			item.rare = 3;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 8;
			item.useAmmo = AmmoID.Bullet;
			
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.CrimtaneBar, 30);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DemoniteBar, 30);
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
