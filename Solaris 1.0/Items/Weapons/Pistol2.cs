using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Pistol2 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-3, 1);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert eagle");
			Tooltip.SetDefault("An upgraded version of the glock 11. Has a 25% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 76;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 6;
			item.value = 50000;
			item.rare = 2;
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 10;
			item.useAmmo = AmmoID.Bullet;
			
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Pistol"), 1);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Pistol"), 1);
			recipe.AddIngredient(ItemID.PlatinumBar, 15);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
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
