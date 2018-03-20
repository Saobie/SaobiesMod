using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{    
    public class Zero : ModNPC
    {
			int idleTimer = 0;
		
        public override void SetDefaults()
        {
            npc.width = 110;               //this is where you put the npc sprite width.     important
            npc.height = 110;              //this is where you put the npc sprite height.   important
            npc.damage = 999;
            npc.defense = 150;
            npc.lifeMax = 3150000;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = true;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 8;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(7, 50, 0, 0);
            npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.aiStyle = 64;
			aiType = NPCID.Firefly;
			animationType = NPCID.DungeonSpirit;
			
			idleTimer = 0;
			

        }
		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter -= 0.9f;
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int frame = (int)npc.frameCounter;
			npc.frame.Y = frame * frameHeight;
			
			npc.spriteDirection = npc.direction;
		}
		
		public override void AI()
		{
			
			if(Main.rand.Next(700) == 0)
			{
				Main.PlaySound(29, npc.position, Main.rand.Next(81, 84));
				
			}
		}
		
		
		
	}
}
        