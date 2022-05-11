using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class Boots : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Combat Boots");
            Tooltip.SetDefault("A common pair of boots used in the military.");
        } 

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 16;
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ComPlating") && head.type == mod.ItemType("Helmet");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "10% more ranged damage.";
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DirtBlock, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}