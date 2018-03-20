using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{    
	[AutoloadBossHead]
    public class TheMawTail : ModNPC
    {
		int projectileTimer1 = 0;
		int projectileTimer2 = 0;
		int projectileTimer3 = 0;
		int	projectileTimer4 = 0;
		int	projectileTimer5 = 0;
		int	projectileTimer6 = 0;
		int	projectileTimer7 = 0;
		int	projectileTimer8 = 0;
		int	projectileTimer9 = 0;
		int EprojectileTimer1 = 0;
		int	EprojectileTimer2 = 0;
		int	EprojectileTimer3 = 0;
		int	EprojectileTimer4 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 36;     //this is where you put the npc sprite width.     important
            npc.height = 42;      //this is where you put the npc sprite height.   important
			npc.scale = 2f;
            npc.damage = 50;
            npc.defense = 20;
            npc.lifeMax = 1;
            npc.knockBackResist = 0.0f;
            npc.behindTiles = true;
            npc.noTileCollide = true;
            npc.netAlways = true;
            npc.noGravity = true;
            npc.dontCountMe = true;
            npc.HitSound = SoundID.NPCHit9;
			
			projectileTimer1 = 0;
			projectileTimer2 = 0;
			projectileTimer3 = 0;
			projectileTimer4 = 0;
			projectileTimer5 = 0;
			projectileTimer6 = 0;
			projectileTimer7 = 0;
			projectileTimer8 = 0;
			projectileTimer9 = 0;
			EprojectileTimer1 = 0;
			EprojectileTimer2 = 0;
			EprojectileTimer3 = 0;
			EprojectileTimer4 = 0;
        }
 
        public override bool PreAI()
        {
            if (npc.ai[3] > 0)
                npc.realLife = (int)npc.ai[3];
            if (npc.target < 0 || npc.target == byte.MaxValue || Main.player[npc.target].dead)
                npc.TargetClosest(true);
            if (Main.player[npc.target].dead && npc.timeLeft > 300)
                npc.timeLeft = 300;
 
            if (Main.netMode != 1)
            {
                if (!Main.npc[(int)npc.ai[1]].active)
                {
                    npc.life = 0;
                    npc.HitEffect(0, 10.0);
                    npc.active = false;
             //       NetMessage.SendData(28, -1, -1, "", npc.whoAmI, -1f, 0.0f, 0.0f, 0, 0, 0);
                }
            }
			if (Main.expertMode)
			{
				if(EprojectileTimer1++ == 60) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 12;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				EprojectileTimer1 = 0;
			}
				if(EprojectileTimer2++ == 120) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 3f;  // The speed of your projectile (in pixels per second).
				int damage = 12;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				EprojectileTimer2 = 0;
			}
			if (npc.life <= 6200)
			{
				if(EprojectileTimer3++ == 30) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 12;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				EprojectileTimer3 = 0;
			}
				if(EprojectileTimer4++ == 60) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 5f;  // The speed of your projectile (in pixels per second).
				int damage = 12;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				EprojectileTimer4 = 0;
			}
			}
			}
			
			else
			{
			if(projectileTimer1++ == 60) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				projectileTimer1 = 0;
			}
			
			if (npc.life <= 6200)
			{
				projectileTimer1 = 0;
				
				if(projectileTimer2++ == 30) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				projectileTimer2 = 0;
			}
			} 
			
			if (npc.life <= 2800)
			{
				projectileTimer2 = 0;
				
				if(projectileTimer3++ == 100) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer4++ == 115) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 30;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer5++ == 130) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer6++ == 145) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer7++ == 160) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer8++ == 175) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer9++ == 190) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 0f;  // The speed of your projectile (in pixels per second).
				int damage = 25;  // The damage your projectile deals.
				float knockBack = 0;
				int type = ProjectileID.Fireball; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				projectileTimer3 = 0;
				projectileTimer4 = 0;
				projectileTimer5 = 0;
				projectileTimer6 = 0;
				projectileTimer7 = 0;
				projectileTimer8 = 0;
				projectileTimer9 = 0;
			}
			}
			}
 
            if (npc.ai[1] < (double)Main.npc.Length)
            {
                // We're getting the center of this NPC.
                Vector2 npcCenter = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
                // Then using that center, we calculate the direction towards the 'parent NPC' of this NPC.
                float dirX = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - npcCenter.X;
                float dirY = Main.npc[(int)npc.ai[1]].position.Y + (float)(Main.npc[(int)npc.ai[1]].height / 2) - npcCenter.Y;
                // We then use Atan2 to get a correct rotation towards that parent NPC.
                npc.rotation = (float)Math.Atan2(dirY, dirX) + 1.57f;
                // We also get the length of the direction vector.
                float length = (float)Math.Sqrt(dirX * dirX + dirY * dirY);
                // We calculate a new, correct distance.
                float dist = (length - (float)npc.width) / length;
                float posX = dirX * dist;
                float posY = dirY * dist;
 
                // Reset the velocity of this NPC, because we don't want it to move on its own
                npc.velocity = Vector2.Zero;
                // And set this NPCs position accordingly to that of this NPCs parent NPC.
                npc.position.X = npc.position.X + posX;
                npc.position.Y = npc.position.Y + posY;
            }
            return false;
        }
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.defense = 25;
		}
 
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {
            Texture2D texture = Main.npcTexture[npc.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            Main.spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
            return false;
        }
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
 
            return false;      //this make that the npc does not have a health bar
        }
    }
}