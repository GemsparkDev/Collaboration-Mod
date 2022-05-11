using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class Helmet : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Combat Helmet");
            Tooltip.SetDefault("A common helmet used in the military.");
        } 

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.value = 10000;
            item.rare = 2;
            item.defense = 3;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ComPlating") && legs.type == mod.ItemType("Boots");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "15% more ranged damage.";
            player.rangedDamage *= 1.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DirtBlock, 5);
            recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}