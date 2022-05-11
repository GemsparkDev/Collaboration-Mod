using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ComPlating : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Combat plating");
            Tooltip.SetDefault("A common armor suit used in the military.");
        } 

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.defense = 4;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return legs.type == mod.ItemType("Boots") && head.type == mod.ItemType("Helmet");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% more ranged damage.";            
            player.rangedDamage *= 1.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 35);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}