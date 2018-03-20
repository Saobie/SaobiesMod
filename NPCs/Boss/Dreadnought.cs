using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{    
	[AutoloadBossHead]
    public class Dreadnought : ModNPC
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
		int projectileTimer16 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 210;               //this is where you put the npc sprite width.     important
            npc.height = 94;              //this is where you put the npc sprite height.   important
            npc.damage = 300;
            npc.defense = 20;
            npc.lifeMax = 500000;
            npc.knockBackResist = -1f;
            npc.behindTiles = false;
            npc.noTileCollide = true;
            npc.netAlways = true;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 80, 0, 0);
            npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.aiStyle = 76;
			npc.boss = true;
			aiType = NPCID.MartianSaucer;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Dreadnought/DreadnoughtMusic");
			
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
			 projectileTimer16 = 0;

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
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(25) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer6++ == 280) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(25) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer7++ == 300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
				
					projectileTimer1 = 0;
					 projectileTimer2 = 0;
					 projectileTimer3 = 0;
					 projectileTimer4 = 0;
					 projectileTimer5 = 0;
					 projectileTimer6 = 0;
					 projectileTimer7 = 0;
				}
				
			if (npc.life <= 400000)
			{
				if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(2) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(2) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(3) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(3) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(3) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer6++ == 280) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(2) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer7++ == 300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerLaser; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(2) * i), type, damage, knockBack, Main.myPlayer);
				
					projectileTimer1 = 0;
					 projectileTimer2 = 0;
					 projectileTimer3 = 0;
					 projectileTimer4 = 0;
					 projectileTimer5 = 0;
					 projectileTimer6 = 0;
					 projectileTimer7 = 0;
				}
			}
			if (npc.life <= 280000)
			{
				if(projectileTimer8++ == 320) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerMissile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -1; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer9++ == 340) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -1; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(25) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer10++ == 360) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerMissile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -1; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
					projectileTimer8 = 0;
					 projectileTimer9 = 0;
					 projectileTimer10 = 0;
				}
			if(projectileTimer11++ == 500) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -1; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer12++ == 520) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -1; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(30) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer13++ == 560) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerMissile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -2; i < 3; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(25) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer14++ == 580) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.SaucerMissile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -4; i < 5; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(45) * i), type, damage, knockBack, Main.myPlayer);
				
					projectileTimer11 = 0;
					 projectileTimer12 = 0;
					 projectileTimer13 = 0;
					  projectileTimer14 = 0;
				}
			}
			
			if (npc.life <= 260000)
			{
				if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 2; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(3) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer6++ == 280) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				}
			if(projectileTimer7++ == 300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = 0; i < 1; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(8) * i), type, damage, knockBack, Main.myPlayer);
				
					projectileTimer1 = 0;
					 projectileTimer2 = 0;
					 projectileTimer3 = 0;
					 projectileTimer4 = 0;
					 projectileTimer5 = 0;
					 projectileTimer6 = 0;
					 projectileTimer7 = 0;
				}
			}
			if (npc.life <= 100000)
			{
				if(projectileTimer15++ == 60) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 8f;  // The speed of your projectile (in pixels per second).
					int damage = 50;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.Missile; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -6; i < 7; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(40) * i), type, damage, knockBack, Main.myPlayer);
					projectileTimer15 = 0;
				}
			}
			
			if (npc.life <= 50000)
			{
				if(projectileTimer16++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
				{
					Main.PlaySound(SoundID.Item12, npc.position); // plays a sound
								
					Player player = Main.player[npc.target];
								
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 70;  // The damage your projectile deals.
					float knockBack = 7;
					int type = ProjectileID.RocketSkeleton; // The type of the projectile you want to shoot.
					Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
					for (int i = -6; i < 7; i++)
					Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(40) * i), type, damage, knockBack, Main.myPlayer);
					projectileTimer16 = 0;
				}
			}
				
		}
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FragmentNebula, Main.rand.Next(25, 35));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FragmentStardust, Main.rand.Next(25, 35));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LunarOre, Main.rand.Next(15, 35));
			Item.NewItem(npc.getRect(), mod.ItemType("StarBar"), Main.rand.Next(6, 12));
			
			if (Main.rand.Next(100) <= 9)
			Item.NewItem(npc.getRect(), mod.ItemType("StarBar"), Main.rand.Next(6, 12));		

			if (Main.rand.Next(100) <= 11)
			Item.NewItem(npc.getRect(), ItemID.FallenStar, Main.rand.Next(9, 13));

			if (Main.rand.Next(100) <= 11)
			Item.NewItem(npc.getRect(), ItemID.ManaCrystal, Main.rand.Next(3, 7));	
		
			if (Main.rand.Next(100) <= 9)
			Item.NewItem(npc.getRect(), ItemID.CelestialMagnet, 1);

			if (Main.rand.Next(100) <= 14)
			Item.NewItem(npc.getRect(), ItemID.StarVeil, 1);	
		
			if (Main.rand.Next(100) <= 14)
			Item.NewItem(npc.getRect(), ItemID.LuckyHorseshoe, 1);	
		}  
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = 500000;
			npc.defense = 50;
		}
		
		
	}
}
        