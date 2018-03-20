using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
    public class LandUrchin : ModNPC
    {
		
		
        public override void SetDefaults()
        {
            npc.width = 44;               //this is where you put the npc sprite width.     important
            npc.height = 44;              //this is where you put the npc sprite height.   important
            npc.damage = 16;
            npc.defense = 10;
            npc.lifeMax = 100;
            npc.knockBackResist = 0.5f;
            npc.behindTiles = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 1;
            npc.noGravity = false;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 0, 3, 0);
            npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath15;
			npc.aiStyle = 26;
			
			aiType = NPCID.Tumbleweed;
			animationType = NPCID.Tumbleweed;
			
			
			

        }
		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter -= 0.9f;
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int frame = (int)npc.frameCounter;
			npc.frame.Y = frame * frameHeight;
			
			npc.spriteDirection = npc.direction;
		}


	/*	public override bool CheckDead(NPC npc)
        {
            if (Main.expertMode)
            {
                {
                    Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound

                    Player player = Main.player[npc.target];

                    float projectileSpeed = 6f;  // The speed of your projectile (in pixels per second).
                    int damage = 14;  // The damage your projectile deals.
                    float knockBack = 5;
                    int type = ProjectileID.ThornBall; // The type of the projectile you want to shoot.
                    Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
                    for (int i = -2; i < 2; i++)
                        Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
                }
            }
            return true;
		}  */
		public override void NPCLoot()
		{
			if (Main.rand.Next(6) < 1)
				Item.NewItem(npc.getRect(), ItemID.DaybloomSeeds, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(7) < 1)
				Item.NewItem(npc.getRect(), ItemID.BlinkrootSeeds, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(14) < 1)
				Item.NewItem(npc.getRect(), ItemID.HerbBag, 1);
			
			if (Main.rand.Next(14) < 1)
				Item.NewItem(npc.getRect(), ItemID.DeathweedSeeds, 1);
			
			if (Main.rand.Next(7) < 1)
				Item.NewItem(npc.getRect(), ItemID.MoonglowSeeds, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(8) < 1)
				Item.NewItem(npc.getRect(), ItemID.FireblossomSeeds, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(8) < 1)
				Item.NewItem(npc.getRect(), ItemID.Waterleaf, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(8) < 1)
				Item.NewItem(npc.getRect(), ItemID.Shiverthorn, Main.rand.Next(3, 5));
			
			if (Main.rand.Next(9) < 1)
				Item.NewItem(npc.getRect(), ItemID.PumpkinSeed, Main.rand.Next(3, 5));
			
			
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldDay.Chance * 0.08f;
		}
	}
}
        