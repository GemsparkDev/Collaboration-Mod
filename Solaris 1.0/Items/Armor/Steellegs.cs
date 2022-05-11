using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class Steellegs : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Boots");
            Tooltip.SetDefault("A Strong pair of boots used in the military.");
        } 

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 16;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("Steelbody") && head.type == mod.ItemType("Steellegs");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% more ranged damage.";
            player.rangedDamage *= 1.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.SilverBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.TungstenBar, 15);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}