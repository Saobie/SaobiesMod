using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
    public class Gargoyle : ModNPC
    {
		int projectileTimer1 = 0;
		int projectileTimer2 = 0;
		int projectileTimer3 = 0;
		int EprojectileTimer1 = 0;
		int EprojectileTimer2 = 0;
		int EprojectileTimer3 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 94;               //this is where you put the npc sprite width.     important
            npc.height = 58;              //this is where you put the npc sprite height.   important
            npc.damage = 15;
            npc.defense = 15;
            npc.lifeMax = 820;
            npc.knockBackResist = 0.3f;
            npc.behindTiles = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 5;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 1, 0, 0);
            npc.HitSound = SoundID.NPCHit12;
			npc.DeathSound = SoundID.NPCDeath24;
			npc.aiStyle = 14;
			aiType = NPCID.IlluminantBat;
			animationType = NPCID.RedDevil;
			banner = npc.type;
			bannerItem = mod.ItemType("GargoyleBanner");
			
			projectileTimer1 = 0;
			projectileTimer2 = 0;
			projectileTimer3 = 0;
			EprojectileTimer1 = 0;
			EprojectileTimer2 = 0;
			EprojectileTimer3 = 0;
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
				Main.PlaySound(29, npc.position, Main.rand.Next(26, 29));
				
			}
			
		if(Main.expertMode)
		{
			if(EprojectileTimer1++ == 140) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident2"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(EprojectileTimer2++ == 160) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident2"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(EprojectileTimer3++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident2"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				EprojectileTimer1 = 0;
				EprojectileTimer2 = 0;
				EprojectileTimer3 = 0;
			}
			if(EprojectileTimer1++ == 140) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 6f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(EprojectileTimer2++ == 160) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 6f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
			}
			if(EprojectileTimer3++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 6f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
				Vector2 velocity = (player.Center - npc.Center).SafeNormalize(Vector2.UnitY) * projectileSpeed; // We get a correct velocity towards the player.
				for (int i = -2; i < 2; i++)
				Projectile.NewProjectile(npc.Center, velocity.RotatedBy(MathHelper.ToRadians(20) * i), type, damage, knockBack, Main.myPlayer);
			
				EprojectileTimer1 = 0;
				EprojectileTimer2 = 0;
				EprojectileTimer3 = 0;
			}
		}

        else

		if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 10f;  // The speed of your projectile (in pixels per second).
				int damage = 14;  // The damage your projectile deals.
				float knockBack = 5;
				int type = mod.ProjectileType("GargoyleTrident"); // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
			}
		
		}
		
		
			
		public override void NPCLoot()
		{
			if (Main.rand.Next(10) == 0)
				Item.NewItem(npc.getRect(), ItemID.Abeemination, 1);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), ItemID.SuspiciousLookingEye, 1);
			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), ItemID.BloodySpine, 1);
			
			if (Main.rand.Next(7) == 0)
				Item.NewItem(npc.getRect(), ItemID.GoblinBattleStandard, 1);
			
			if (Main.rand.Next(8) == 0)
				Item.NewItem(npc.getRect(), ItemID.WormFood, 1);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), ItemID.SlimeCrown, 1);
			
			if (Main.rand.Next(14) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("HorribleFlesh"), 1);
			
			if (Main.rand.Next(19) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("MagnificentChrysalis"), 1);
			
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldNight.Chance * 0.04f;
		}
	}
}
        