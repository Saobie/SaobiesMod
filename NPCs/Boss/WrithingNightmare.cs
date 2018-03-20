using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{    
	[AutoloadBossHead]
    public class WrithingNightmare : ModNPC
    {
		int projectileTimer1 = 0;
		int projectileTimer2 = 0;
		int projectileTimer3 = 0;
		int projectileTimer4 = 0;
		int projectileTimer5 = 0;
		int projectileTimer6 = 0;
		int projectileTimer7 = 0;
		int projectileTimer8 = 0;
		int projectileTimer9 = 0;
		int projectileTimer10 = 0;
		int projectileTimer11 = 0;
		int projectileTimer12 = 0;
		int projectileTimer13 = 0;
		int projectileTimer14 = 0;
		int projectileTimer15 = 0;
		int TextTimer1 = 0;
		int TextTimer2 = 0;
		int TextTimer3 = 0;
		int TextTimer4 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 76;               //this is where you put the npc sprite width.     important
            npc.height = 88;              //this is where you put the npc sprite height.   important
            npc.damage = 300;
            npc.defense = 150;
            npc.lifeMax = 400000;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = true;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 5;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 80, 0, 0);
            npc.HitSound = SoundID.NPCHit55;
			npc.DeathSound = SoundID.NPCDeath59;
			npc.aiStyle = 14;
			npc.boss = true;
			aiType = NPCID.IlluminantBat;
			animationType = NPCID.Harpy;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/WrithingNightmare/WrithingNightmareMusic");
			
			 projectileTimer1 = 0;
			 projectileTimer2 = 0;
			 projectileTimer3 = 0;
			 projectileTimer4 = 0;
			 projectileTimer5 = 0;
			 projectileTimer6 = 0;
			 projectileTimer7 = 0;
			 projectileTimer8 = 0;
			 projectileTimer9 = 0;
			 projectileTimer10 = 0;
			 projectileTimer11 = 0;
			 projectileTimer12 = 0;
			 projectileTimer13 = 0;
			 projectileTimer14 = 0;
			 projectileTimer15 = 0;
			 TextTimer1 = 0;
			 TextTimer2 = 0;
			 TextTimer3 = 0;
			 TextTimer4 = 0;

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
            Player player = Main.player[npc.target];

           player.AddBuff(mod.BuffType("LucidNightmare"), 2, true);		
			player.AddBuff(BuffID.Blackout, 2, true);	
			if(Main.rand.Next(700) == 0)
			{
				Main.PlaySound(29, npc.position, Main.rand.Next(81, 84));
				
			}
			
			//------------------------------------------------------
			
			if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				
				
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				player.AddBuff(mod.BuffType("LucidNightmare"), 2, true);
			//	Player player = Main.player[npc.target];
				if (npc.life <= 500000 && npc.life >= 170000)
				{								
				player.AddBuff(BuffID.Blackout, 2, true);
				}		
				if (npc.life <= 240000 && npc.life >= 170000)
				{
				player.AddBuff(BuffID.Darkness, 2, true);
				}
						
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -3; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(40) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(27) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(34) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
			}
			
			if (npc.life <= 320000)
			{
				if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				
				
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
						
				player.AddBuff(mod.BuffType("LucidNightmare"), 2, true);		
				player.AddBuff(BuffID.Blackout, 2, true);	
						
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(120) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(210) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -1; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(90) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
			}
			}
			
			if (npc.life <= 240000)
			{
				if (TextTimer1++ == 1)
				{
					Main.NewText("The nightmare intensifies");
				}
				
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
				
				if(projectileTimer6++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer7++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer8++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer6 = 0;
				projectileTimer7 = 0;
				projectileTimer8 = 0;
			}
			if(projectileTimer6++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer7++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer8++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.1f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 3; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer6 = 0;
				projectileTimer7 = 0;
				projectileTimer8 = 0;
			}
			if(projectileTimer9++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 3f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.LostSoulHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -3; i < 4; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
				projectileTimer9 = 0;
			}
			}
			if (npc.life <= 170000)
			{
				if (TextTimer2++ == 1)
				{
					Main.NewText("The nightmare is consuming you");
				}
				

				
				projectileTimer6 = 0;
				projectileTimer7 = 0;
				projectileTimer8 = 0;
				
				if(projectileTimer10++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer11++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer12++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer13++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer14++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(180) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer10 = 0;
				projectileTimer11 = 0;
				projectileTimer12 = 0;
				projectileTimer13 = 0;
				projectileTimer14 = 0;
			}
			}
			
			if (npc.life <= 60000)
			{
				if (TextTimer3++ == 1)
				{
					Main.NewText("The nightmare is suffocating you");
				}
				player.AddBuff(BuffID.Suffocation, 2, true);
				
				if(projectileTimer10++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer11++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer12++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer13++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer14++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.2f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -5; i < 6; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
				
				projectileTimer10 = 0;
				projectileTimer11 = 0;
				projectileTimer12 = 0;
				projectileTimer13 = 0;
				projectileTimer14 = 0;
			}
			if(projectileTimer15++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
			//	Player player = Main.player[npc.target];
							
				float projectileSpeed = 3f;  // The speed of your projectile (in pixels per second).
				int damage = 55;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.LostSoulHostile; // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -3; i < 4; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(260) * i), type, damage, knockBack, Main.myPlayer);
				projectileTimer15 = 0;
			}
			}
			if (npc.life <= 0)
			{
				if (TextTimer4++ == 1)
				{
					Main.NewText("The nightmare has ended");
				}
			}
			
				
		}
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CursedEssence"), Main.rand.Next(1, 2));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(300, 400));

			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("VileEssence"), 1);
			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("EvilEssence"), 1);
			
			if (Main.rand.Next(10) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("CursedMetal"), 3);
			
			if (Main.rand.Next(20) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("CursedMetal"), 3);
			
			if (Main.rand.Next(9) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("NightmareTrophy"), 1);
			}
			
		}  
		
		
		
	}

        