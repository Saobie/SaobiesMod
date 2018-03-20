using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
	[AutoloadBossHead]
    public class StarProbe : ModNPC
    {
			int projectileTimer1 = 0;
			int projectileTimer2 = 0;
			int projectileTimer3 = 0;
			int projectileTimer4 = 0;
			int projectileTimer5 = 0;
			int projectileTimer6 = 0;
			int	projectileTimer7 = 0;
			int	projectileTimer8 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 45;               //this is where you put the npc sprite width.     important
            npc.height = 32;              //this is where you put the npc sprite height.   important
            npc.damage = 120;
            npc.defense = 90;
            npc.lifeMax = 100000;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
			npc.boss = true;
			Main.npcFrameCount[npc.type] = 1;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 30, 0, 0);
            npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.aiStyle = 24;
			npc.rarity = 398;
			npc.aiStyle = 5;
			animationType = NPCID.Probe;
			music = MusicID.Boss4;
			
			projectileTimer1 = 0;
			projectileTimer2 = 0;
			projectileTimer3 = 0;
			projectileTimer4 = 0;
			projectileTimer5 = 0;
			projectileTimer6 = 0;
			projectileTimer7 = 0;
			projectileTimer8 = 0;

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
			Lighting.AddLight(npc.Center, ((255 - npc.alpha) * 0.8f) / 255f, ((255 - npc.alpha) * 0.8f) / 255f, ((255 - npc.alpha) * 0.8f) / 255f);
			
			if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
								
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
								
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
								
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
								
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
								
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
								
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
								
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
								
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
								
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
								
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
					
					projectileTimer1 = 0;
					projectileTimer2 = 0;
					projectileTimer3 = 0;
					projectileTimer4 = 0;
					projectileTimer5 = 0;
				}
			if (npc.life <= 75000)
			{
				if(projectileTimer6++ == 300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item61, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 80;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -3; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer7++ == 320) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item61, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 80;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -3; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer8++ == 340) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item61, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 80;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -3; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
					
					projectileTimer6 = 0;
					projectileTimer7 = 0;
					projectileTimer8 = 0;
				}
			if (npc.life <= 30000)
			{
					if(Main.rand.Next(20) == 0)
				{
					Main.PlaySound(SoundID.Item13, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 30;  // The damage your projectile deals.
					float knockBack = 0;
					int type = ProjectileID.SaucerScrap; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -3; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
					
				}
			}
		}
		}
		
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FragmentNebula, Main.rand.Next(5, 15));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FragmentStardust, Main.rand.Next(5, 15));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LunarOre, Main.rand.Next(10, 15));
			
			if (Main.rand.Next(100) <= 9)
			Item.NewItem(npc.getRect(), mod.ItemType("StarBar"), Main.rand.Next(1, 3));		

			if (Main.rand.Next(100) <= 11)
			Item.NewItem(npc.getRect(), ItemID.FallenStar, Main.rand.Next(3, 8));

			if (Main.rand.Next(100) <= 11)
			Item.NewItem(npc.getRect(), ItemID.ManaCrystal, Main.rand.Next(1, 2));	
		
			if (Main.rand.Next(100) <= 9)
			Item.NewItem(npc.getRect(), ItemID.CelestialMagnet, 1);

			if (Main.rand.Next(100) <= 14)
			Item.NewItem(npc.getRect(), ItemID.StarVeil, 1);	
		
			if (Main.rand.Next(100) <= 14)
			Item.NewItem(npc.getRect(), ItemID.LuckyHorseshoe, 1);	
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (SaobiesModWorld.downedMoonLord)
			{ 
				// we would like this npc to spawn in the overworld.
				return SpawnCondition.OverworldNight.Chance * 0.009f;
			}
			
			else
				
			return SpawnCondition.OverworldNight.Chance * 0f;
		}
	}
}
        