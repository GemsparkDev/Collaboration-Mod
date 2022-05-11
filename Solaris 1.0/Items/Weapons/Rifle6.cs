using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle6 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 1);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Famas .223");
			Tooltip.SetDefault("A semi-automatic burst rifle. Has a 75% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 65;
			item.ranged = true;
			item.width = 62;
			item.height = 24;
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
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}
    }
}