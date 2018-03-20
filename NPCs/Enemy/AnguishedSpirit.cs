using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
    public class AnguishedSpirit : ModNPC
    {
			int idleTimer = 0;
		
        public override void SetDefaults()
        {
            npc.width = 24;               //this is where you put the npc sprite width.     important
            npc.height = 28;              //this is where you put the npc sprite height.   important
            npc.damage = 0;
            npc.defense = 0;
			npc.alpha = 200;
            npc.lifeMax = 100;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = true;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 3;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 50, 0, 0);
            npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.aiStyle = 64;
			npc.rarity = 399;
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
		
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), ItemID.CobaltBar, 3);
			
			if (Main.rand.Next(2) == 0)
				Item.NewItem(npc.getRect(), ItemID.WoodenCrate, 1);
			
			if (Main.rand.Next(20) == 0)
				Item.NewItem(npc.getRect(), ItemID.Arkhalis, 1);
			
			if (Main.rand.Next(3) == 0)
				Item.NewItem(npc.getRect(), ItemID.IronCrate, 1);
			
			if (Main.rand.Next(4) == 0)
				Item.NewItem(npc.getRect(), ItemID.GoldenCrate, 1);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), ItemID.PalladiumBar, 3);
			
			if (Main.rand.Next(7) == 0)
				Item.NewItem(npc.getRect(), ItemID.OrichalcumBar, 3);
			
			if (Main.rand.Next(7) == 0)
				Item.NewItem(npc.getRect(), ItemID.MythrilBar, 3);
			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), ItemID.AdamantiteBar, 3);
			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), ItemID.TitaniumBar, 3);
			
			if (Main.rand.Next(75) == 0)
				Item.NewItem(npc.getRect(), ItemID.FrozenKey, 1);
			
			if (Main.rand.Next(75) == 0)
				Item.NewItem(npc.getRect(), ItemID.HallowedKey, 1);
			
			if (Main.rand.Next(75) == 0)
				Item.NewItem(npc.getRect(), ItemID.JungleKey, 1);
			
			if (Main.rand.Next(75) == 0)
				Item.NewItem(npc.getRect(), ItemID.CorruptionKey, 1);
			
			if (Main.rand.Next(75) == 0)
				Item.NewItem(npc.getRect(), ItemID.CrimsonKey, 1);
			
			if (Main.rand.Next(2) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("PlexiciteBar"), 3);
			
			if (Main.rand.Next(2) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("FakeWings"), 1);
			
			if (Main.rand.Next(25) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("LindunGem"), 1);
			
			if (Main.rand.Next(13) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("Goldscale"), 1);
			
			if (Main.rand.Next(2) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("FeelerMembrane"), 1);
			
			if (Main.rand.Next(10) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("PolytithriteBar"), 3);
			
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.Overworld.Chance * 0.003f;
		}
	}
}
        