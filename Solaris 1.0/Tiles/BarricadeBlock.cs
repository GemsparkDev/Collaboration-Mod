using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Solaris.Tiles
{
    public class BarricadeBlock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("BarricadeBlock");
            AddMapEntry(new Color(200, 200, 200));
        }
    }
}