using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items.Weapons
{
    public class AutoPistol2 : ModItem
    {
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-1, 0);
		}
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("broken 10mm sub-machine gun");
			Tooltip.SetDefault("A damaged automatic sidearm.");
		}
        public override void SetDefaults()
		{
			item.damage = 3;
			item.ranged = true;
			item.width = 36;
			item.height = 20;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7;
			item.value = 50000;
			item.rare = 3;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 4;
			item.useAmmo = AmmoID.Bullet;
			
		}
    }
}
