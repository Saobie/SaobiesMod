using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Enemy
{    
    public class WingedDjinn : ModNPC
    {
		int projectileTimer1 = 0;
		int TextTimer = 0;
		int TextTimer1 = 0;
		int TextTimer2 = 0;
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
		int	projectileTimer12 = 0;
		int	projectileTimer13 = 0;
		int	projectileTimer14 = 0;
		int AprojectileTimer1 = 0;
		int	AprojectileTimer2 = 0;
		int	AprojectileTimer3 = 0;
		int	AprojectileTimer4 = 0;
		int	AprojectileTimer5 = 0;
		int	AprojectileTimer6 = 0;
		int	AprojectileTimer7 = 0;
		int AprojectileTimer8 = 0;
		int AprojectileTimer9 = 0;
		int AprojectileTimer10 = 0;
		int AprojectileTimer11 = 0;
		int	AprojectileTimer12 = 0;
		int	AprojectileTimer13 = 0;
		int	AprojectileTimer14 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 94;               //this is where you put the npc sprite width.     important
            npc.height = 58;              //this is where you put the npc sprite height.   important
            npc.damage = 25;
			npc. scale = 1.3f;
            npc.defense = 22;
            npc.lifeMax = 2000;
            npc.knockBackResist = 0.5f;
            npc.behindTiles = false;
            npc.noTileCollide = false;
            npc.netAlways = true;
			Main.npcFrameCount[npc.type] = 5;
            npc.noGravity = true;
			npc.npcSlots = 1f;
			npc.value = Item.buyPrice(0, 2, 0, 0);
            npc.HitSound = SoundID.NPCHit12;
			npc.DeathSound = SoundID.NPCDeath24;
			npc.aiStyle = 14;
			aiType = NPCID.IlluminantBat;
			animationType = NPCID.RedDevil;
		//	banner = npc.type;
		//	bannerItem = mod.ItemType("GargoyleBanner");
			
			projectileTimer1 = 0;
			TextTimer = 0;
			TextTimer1 = 0;
			TextTimer2 = 0;
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
			AprojectileTimer1 = 0;
			AprojectileTimer2 = 0;
			AprojectileTimer3 = 0;
			AprojectileTimer4 = 0;
			AprojectileTimer5 = 0;
			AprojectileTimer6 = 0;
			AprojectileTimer7 = 0;
			AprojectileTimer8 = 0;
			AprojectileTimer9 = 0;
			AprojectileTimer10 = 0;
			AprojectileTimer11 = 0;
			AprojectileTimer12 = 0;
			AprojectileTimer13 = 0;
			AprojectileTimer14 = 0;
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
		
		if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(projectileTimer5++ == 260) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(projectileTimer6++ == 280) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(projectileTimer7++ == 300) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 21;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.UnholyTridentHostile; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
				projectileTimer6 = 0;
				projectileTimer7 = 0;
			}
		if (npc.life <= 3000)
		{
			if (TextTimer++ == 1)
				{
				int choice = Main.rand.Next(2);
					
				if (choice == 0)
				{
					Main.NewText("A pitiful effort.");     
				}
				if (choice == 1)
				{
					Main.NewText("Cease this pointless flailing!");
				}
			}
			
			projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
				projectileTimer6 = 0;
				projectileTimer7 = 0;
			if(AprojectileTimer1++ == 130) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(AprojectileTimer2++ == 150) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
		if(AprojectileTimer3++ == 170) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(AprojectileTimer4++ == 190) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(AprojectileTimer5++ == 210) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(AprojectileTimer6++ == 230) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
		if(AprojectileTimer7++ == 250) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0.4f;  // The speed of your projectile (in pixels per second).
				int damage = 28;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.DemonSickle; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				AprojectileTimer1 = 0;
				AprojectileTimer2 = 0;
				AprojectileTimer3 = 0;
				AprojectileTimer4 = 0;
				AprojectileTimer5 = 0;
				AprojectileTimer6 = 0;
				AprojectileTimer7 = 0;
			}
		}
			if (npc.life <= 2000)
			{
			if (TextTimer1++ == 1)
				{
				int choice = Main.rand.Next(2);
					
				if (choice == 0)
				{
					Main.NewText("Enough already!");     
				}
				if (choice == 1)
				{
					Main.NewText("Why wont you die!");
				}
			}
			if(projectileTimer8++ == 580) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer9++ == 590) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer10++ == 600) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer11++ == 610) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer12++ == 620) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer13++ == 630) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(projectileTimer14++ == 640) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 15;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.CultistBossFireBallClone; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				projectileTimer8 = 0;
				projectileTimer9 = 0;
				projectileTimer10 = 0;
				projectileTimer11 = 0;
				projectileTimer12 = 0;
				projectileTimer13 = 0;
				projectileTimer14 = 0;
			}			
			}
			
		
			if (npc.life <= 1000)
			{
				if(TextTimer2++ == 1)
				{
					int choice = Main.rand.Next(2);
						
					if (choice == 0)
					{
						Main.NewText("Enough of this!");     
					}
					if (choice == 1)
					{
						Main.NewText("How?!");
					}
				}
				
				if(AprojectileTimer8++ == 580) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(AprojectileTimer9++ == 590) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(AprojectileTimer10++ == 600) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(AprojectileTimer11++ == 610) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(AprojectileTimer12++ == 620) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(AprojectileTimer13++ == 630) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
			if(AprojectileTimer14++ == 640) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 7f;  // The speed of your projectile (in pixels per second).
				int damage = 20;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.InfernoHostileBolt; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				AprojectileTimer8 = 0;
			AprojectileTimer9 = 0;
			AprojectileTimer10 = 0;
			AprojectileTimer11 = 0;
			AprojectileTimer12 = 0;
			AprojectileTimer13 = 0;
			AprojectileTimer14 = 0;
			}			
			}
		
		}
		
		
		
			
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CeremonialGrabbag"), 1);
		}  
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (Main.expertMode)
			{
				if (Main.hardMode)
				{
					return SpawnCondition.OverworldNight.Chance * 0.02f;
				}
				// we would like this npc to spawn in the overworld.
				return SpawnCondition.OverworldNight.Chance * 0.006f;
			}
			else
			
			return SpawnCondition.OverworldNight.Chance * 0.00000006f;
		}
	}
}
        