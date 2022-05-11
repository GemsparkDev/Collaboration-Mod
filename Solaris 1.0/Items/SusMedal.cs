using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items
{
	public class SusMedal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Medallion");
			Tooltip.SetDefault("A suspicious medallion. Tastes like...    cats?");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13;
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.value = 10000;
			item.rare = 2;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = false;
		}
		public override bool CanUseItem(Player player)
		{             
			return !NPC.AnyNPCs(mod.NPCType("Boss1"));
		}         
		public override bool UseItem(Player player)         
		{             
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Boss1"));             
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);             
			return true;         
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
