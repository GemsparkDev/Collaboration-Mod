using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Rifle8 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MPK-6 Blaster");
			Tooltip.SetDefault("A Hi-tek blaster cannon. Has a 75% chance not to consume ammo");
		}
        public override void SetDefaults()
		{
			item.damage = 375;
			item.ranged = true;
			item.width = 58;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 20;
			item.useAmmo = AmmoID.Bullet;
		}
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Gunpowder"), 1);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.LunarBar, 15);
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