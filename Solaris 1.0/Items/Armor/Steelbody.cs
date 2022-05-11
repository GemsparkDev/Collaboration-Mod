using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class Steelbody : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel plating");
            Tooltip.SetDefault("A strong armor suit used in the military.");
        } 

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return legs.type == mod.ItemType("Steellegs") && head.type == mod.ItemType("Steelhead");
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
            recipe.AddIngredient(ItemID.SilverBar, 35);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.TungstenBar, 35);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}