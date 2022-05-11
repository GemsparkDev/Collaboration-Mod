using System;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Ammo
{
    public class NerfDart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Derf Dart");
			Tooltip.SetDefault("A Derf dart.");
        }
        public override void SetDefaults()
        {
            item.damage = 0;
            item.ranged = true; 
            item.width = 14;
            item.height = 32;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = 500;
            item.rare = 2;
            item.shoot = mod.ProjectileType("NerfDartProj");
            item.shootSpeed = 1f; //Added to the weapon's shoot speed
            item.ammo = mod.ItemType("NerfDart");
            item.value = Item.buyPrice(0, 0, 0, 1);
        }
    }
}
