using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Placeables
{
    public class BarricadeBlock : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Barricade Block");
			Tooltip.SetDefault("A small iron defense unit with built-in camoflauge.");
		}
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BarricadeBlock");
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}