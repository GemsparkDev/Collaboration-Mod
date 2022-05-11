using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle3 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 1);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian AR 15");
			Tooltip.SetDefault("A reverse-engineered rifle. Has a 50% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 100;
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
			item.shoot = 12;
			item.shootSpeed = 10;
			item.useAmmo = AmmoID.Bullet;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Rifle2"), 1);
			recipe.AddIngredient(ItemID.BeetleHusk, 10);
			recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}
    }
}