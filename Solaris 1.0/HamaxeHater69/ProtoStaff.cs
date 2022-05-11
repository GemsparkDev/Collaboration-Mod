using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.HamaxeHater69
{
	public class ProtoStaff : ModItem
	{

		public override void SetDefaults()
		{

			item.damage = 48;
			item.mana = 30;
			item.width = 44;
			item.height = 44;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 2.5f;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item44;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ProtoPro");
			item.summon = true;
			item.sentry = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Protogen Staff");
			Tooltip.SetDefault("Summons a protogen visor to shoot lasers at your foes, protogen body not included.");
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 SPos = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			position = SPos;
			for (int l = 0; l < Main.projectile.Length; l++)
			{
				Projectile proj = Main.projectile[l];
				if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
				{
					proj.active = false;
				}
			}
			return player.altFunctionUse != 2;
		}
	}
}
