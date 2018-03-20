using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
    public class LuckySpirit : ModNPC
    {
			int idleTimer = 0;
		
        public override void SetDefaults()
        {
            npc.width = 42;               //this is where you put the npc sprite width.     important
            npc.height = 30;              //this is where you put the npc sprite height.   important
            npc.damage = 0;
            npc.defense = 35;
			npc.alpha = 150;
            npc.lifeMax = 100;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = true;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 4;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 50, 0, 0);
            npc.HitSound = SoundID.NPCHit5;
			npc.DeathSound = SoundID.NPCHit5;
			npc.aiStyle = 24;
			npc.rarity = 400;
			aiType = NPCID.Bird;
			animationType = NPCID.Bird;
			
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
				Main.PlaySound(16, npc.position, Main.rand.Next(81, 84));
				
			}
		}
		
		
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LuckyGrabbag"));
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.Overworld.Chance * 0.003f;
		}
	}
}
        