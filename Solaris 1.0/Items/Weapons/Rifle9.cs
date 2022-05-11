using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle9 : ModItem
    {
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SSG 24");
			Tooltip.SetDefault("A sniper rifle with a high damage.");
		}
        public override void SetDefaults()
        {
            item.damage = 450;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 14;
            item.value = 100000;
            item.rare = 3;
            item.UseSound = SoundID.Item41; 
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 20f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}