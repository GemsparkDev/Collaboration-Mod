using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.NPCs
{
    public class Catmech : ModNPC
    {
        public override void SetStaticDefaults() 
        {
			DisplayName.SetDefault("Cat Mech");
            Main.npcFrameCount[npc.type] = 5;
        }
        public override void SetDefaults()
        {
            npc.aiStyle = 3;
            animationType = NPCID.Frankenstein; 
            npc.lifeMax = 100;
            npc.damage = 10;
            npc.defense = 5;
            npc.knockBackResist = 0f;
            npc.width = 30;
            npc.height = 46;
            npc.value = Item.buyPrice(0, 10, 0, 0);
            npc.npcSlots = 1f;
            npc.lavaImmune = true;
            npc.noGravity = false;
            npc.noTileCollide = false;
            npc.HitSound = SoundID.NPCHit1; 
            npc.DeathSound = SoundID.NPCDeath1;
            npc.netAlways = true;
        }
    }
}