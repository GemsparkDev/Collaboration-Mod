using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Bow1 : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Compound bow");
			Tooltip.SetDefault("A bow with a high arrow speed.");
		}
        public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 56;
			item.height = 24;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 30f;
			item.useAmmo = AmmoID.Arrow;
		}
        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

    		recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.PlatinumBar, 15);
			recipe.AddTile(TileID.Anvils);
    		recipe.SetResult(this);
   			recipe.AddRecipe();
        }
    }
}