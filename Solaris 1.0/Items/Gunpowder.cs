using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.Items
{
	public class Gunpowder : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gunpowder");
			Tooltip.SetDefault("A highly volitile substance used in gun-crafting.");
		}
		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 10000;
			item.rare = 2;
		}
	}
}
