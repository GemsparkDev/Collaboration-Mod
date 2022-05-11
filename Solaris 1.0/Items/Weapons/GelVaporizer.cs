using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Solaris.Items.Weapons
{
    public class GelVaporizer : ModItem
    {
        public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 0);
        }
     public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Vaporizer");
			Tooltip.SetDefault("Vaporizes gel to make a laser.");
		}
        public override void SetDefaults()
        {
            item.damage = 100;
            item.noMelee = true;
            item.noUseGraphic = false;
            item.ranged = true;
            item.channel = true;
            item.rare = 5;
            item.width = 20;
            item.height = 20;
            item.useTime = 2;
            item.autoReuse = true;
            item.UseSound = SoundID.Item13;
            item.useStyle = 5;
            item.shootSpeed = 4f;
            item.useAnimation = 7;
            item.useAmmo = AmmoID.Gel;
            item.shoot = 440;
            item.value = Item.sellPrice(0, 5, 0, 0);
        }
         public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 100);
			recipe.AddIngredient(ItemID.LunarBar, 30);
            recipe.AddIngredient(ItemID.LaserMachinegun, 1);
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