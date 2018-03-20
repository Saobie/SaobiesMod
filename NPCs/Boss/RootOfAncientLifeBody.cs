using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{    
    public class RootOfAncientLifeBody : ModNPC
    {
		int projectileTimer1 = 0;
		
        public override void SetDefaults()
        {
            npc.width = 40;               //this is where you put the npc sprite width.     important
            npc.height = 58;              //this is where you put the npc sprite height.   important
            npc.damage = 50;
            npc.defense = 60;
            npc.lifeMax = 1;
            npc.knockBackResist = 0.0f;
            npc.behindTiles = true;
            npc.noTileCollide = true;
            npc.netAlways = true;
            npc.noGravity = true;
            npc.dontCountMe = true;
            npc.HitSound = SoundID.NPCHit9;
			
			projectileTimer1 = 0;
           
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
               //     NetMessage.SendData(28, -1, -1, "", npc.whoAmI, -1f, 0.0f, 0.0f, 0, 0, 0);
                }
            }
			
			
				if(Main.rand.Next(900) == 0)
			{
					Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
					Player player = Main.player[npc.target];
							
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 40;  // The damage your projectile deals.
					float knockBack = 5;
					int type = ProjectileID.SeedPlantera; // The type of the projectile you want to shoot.
							
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);			
			}
			if (npc.life <= 600000)
			{
			if(Main.rand.Next(500) == 0)
			{
					Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
					Player player = Main.player[npc.target];
							
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 40;  // The damage your projectile deals.
					float knockBack = 5;
					int type = ProjectileID.PoisonSeedPlantera; // The type of the projectile you want to shoot.
							
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);			
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
		
 
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {
            Texture2D texture = Main.npcTexture[npc.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            Main.spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
            return false;
        }
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
 
            return false;       //this make that the npc does not have a health bar
        }
    }
}