using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class Nerfgun : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-4, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Derf Gun");
			Tooltip.SetDefault("A Derf gun.");
		}
        public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 56;
			item.height = 24;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10;
			item.useAmmo = mod.ItemType("NerfDart"); 
			item.shoot = mod.ProjectileType("NerfDartProj");

		}
    }
}