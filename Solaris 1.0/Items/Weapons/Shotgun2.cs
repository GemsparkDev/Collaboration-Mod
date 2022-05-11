using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Shotgun2 : ModItem
    {
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sawed off shotty");
			Tooltip.SetDefault("A double barreled shotgun with a slow fire rate. Dedicated to Rex Almen for the first user submission.");
		}
        public override void SetDefaults()
        {
            item.damage = 120;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 8;
            item.value = 100000;
            item.rare = 3;
            item.UseSound = SoundID.Item11; 
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 15f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }

        public static Vector2[] randomSpread(float speedX, float speedY, int angle, int num)
        {
            var posArray = new Vector2[num];
            float spread = (float)(angle * 0.0174532925);
            float baseSpeed = (float)System.Math.Sqrt(speedX * speedX + speedY * speedY);
            double baseAngle = System.Math.Atan2(speedX, speedY);
            double randomAngle;
            for (int i = 0; i < num; ++i)
            {
                randomAngle = baseAngle + (Main.rand.NextFloat() - 0.5f) * spread;
                posArray[i] = new Vector2(baseSpeed * (float)System.Math.Sin(randomAngle), baseSpeed * (float)System.Math.Cos(randomAngle));
            }
            return (Vector2[])posArray;
        }

         public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2[] speeds = randomSpread(speedX, speedY, 8, 6);
            for (int i = 0; i < 5; ++i)
            {
                Projectile.NewProjectile(position.X, position.Y, speeds[i].X,speeds[i].Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}