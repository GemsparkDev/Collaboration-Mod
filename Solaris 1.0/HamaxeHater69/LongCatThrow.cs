using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class LongCatThrow : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 400;
			item.width = 18;
			item.height = 36;
			item.noUseGraphic = true;
			item.thrown = true;
			item.useTime = 30;
			item.shoot = mod.ProjectileType("LongCatThrowPro");
			item.shootSpeed = 15f;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Throw the long cat");
			Tooltip.SetDefault("");
		}

	}
}
