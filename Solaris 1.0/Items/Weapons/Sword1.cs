using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Sword1 : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Combat knife");
			Tooltip.SetDefault("A small combat knife.");
		}
        public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 12;
			item.height = 12;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}
    }
}