using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Solaris.NPCs.Boss
{
     [AutoloadBossHead]
    public class Boss1 : ModNPC
    {
        public override void SetStaticDefaults() 
        {
			DisplayName.SetDefault("The One");
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.aiStyle = 86;
            animationType = NPCID.AngryNimbus; 
            npc.lifeMax = 100000;
            npc.damage = 400;
            npc.defense = 20;
            npc.knockBackResist = 0f;
            npc.width = 44;
            npc.height = 29;
            npc.value = Item.buyPrice(0, 10, 0, 0);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = false;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.NPCHit1; 
            npc.DeathSound = SoundID.NPCDeath1;
            npc.buffImmune[24] = true;
            npc.netAlways = true;
        }
        public void AutoloadBossHead(ref string headTexture, ref string bossHeadTexture)
        {
            bossHeadTexture = "Gunmod/NPCs/Boss/Boss1_head";
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.GreaterHealingPotion;
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Gunpowder"));
        }
    }
}