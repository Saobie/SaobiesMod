using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs.Boss
{
    public class AlbinoMaw : ModNPC
    {
		int projectileTimer1 = 0;
		int projectileTimer2 = 0;
		int projectileTimer3 = 0;
		int projectileTimer4 = 0;
		int projectileTimer5 = 0;
		
        public override void SetDefaults()
        {
            npc.lifeMax = 60250;        //this is the npc health
            npc.damage = 75;    //this is the npc damage
            npc.defense = 35;         //this is the npc defense
            npc.knockBackResist = 0f;
			npc.scale = 2f;
            npc.width = 48; //this is where you put the npc sprite width.     important
            npc.height = 44; //this is where you put the npc sprite height.   important
            npc.boss = true;
            npc.lavaImmune = true;       //this make the npc immune to lava
            npc.noGravity = true;           //this make the npc float
            npc.noTileCollide = true;        //this make the npc go thru walls
            npc.HitSound = SoundID.NPCDeath10;
            npc.DeathSound = SoundID.NPCDeath10;
            npc.behindTiles = true;          
            Main.npcFrameCount[npc.type] = 1;
            npc.value = Item.buyPrice(0, 20, 0, 10);
            npc.npcSlots = 1f;
            npc.netAlways = true;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/AlbinoMaw/AlbinoMawMusic"); // <3
			
			projectileTimer1 = 0;
			projectileTimer2 = 0;
			projectileTimer3 = 0;
			projectileTimer4 = 0;
			projectileTimer5 = 0;
        }
		public override void OnHitPlayer(Player player, int damage, bool crit)  //this make so when this npc hit he player it will give to the player this debuff
        {
			if (npc.life >= 30000)
			{ 
			
            player.AddBuff(BuffID.Venom, 300, true);
			}
			else 
				
			player.AddBuff(BuffID.Frostburn, 300, true);
			player.AddBuff(BuffID.Slow, 180, true);
 
        }
		
		
        public override bool PreAI()
        {
            if (Main.netMode != 1)
            {
                // So, we start the AI off by checking if npc.ai[0] is 0.
                // This is practically ALWAYS the case with a freshly spawned NPC, so this means this is the first update.
                // Since this is the first update, we can safely assume we need to spawn the rest of the worm (bodies + tail).
                if (npc.ai[0] == 0)
                {
                    // So, here we assing the npc.realLife value.
                    // The npc.realLife value is mainly used to determine which NPC loses life when we hit this NPC.
                    // We don't want every single piece of the worm to have its own HP pool, so this is a neat way to fix that.
                    npc.realLife = npc.whoAmI;
                    // LatestNPC is going to be used later on and I'll explain it there.
                    int latestNPC = npc.whoAmI;
 
                    // Here we determine the length of the worm.
                    // In this case the worm will have a length of 10 to 14 body parts.
                    int randomWormLength = Main.rand.Next(21, 22);
                    for (int i = 0; i < randomWormLength; ++i)
                    {
                        // We spawn a new NPC, setting latestNPC to the newer NPC, whilst also using that same variable
                        // to set the parent of this new NPC. The parent of the new NPC (may it be a tail or body part)
                        // will determine the movement of this new NPC.
                        // Under there, we also set the realLife value of the new NPC, because of what is explained above.
                        latestNPC = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("AlbinoMawBody"), npc.whoAmI, 0, latestNPC);
                        Main.npc[(int)latestNPC].realLife = npc.whoAmI;
                        Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;
                    }
                    // When we're out of that loop, we want to 'close' the worm with a tail part!
                    latestNPC = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("AlbinoMawTail"), npc.whoAmI, 0, latestNPC);
                    Main.npc[(int)latestNPC].realLife = npc.whoAmI;
                    Main.npc[(int)latestNPC].ai[3] = npc.whoAmI;
 
                    // We're setting npc.ai[0] to 1, so that this 'if' is not triggered again.
                    npc.ai[0] = 1;
                    npc.netUpdate = true;
                }
            }
			
			
			
			if(projectileTimer1++ == 180) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
				int damage = 45;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.FrostBeam; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
			}
				if(projectileTimer2++ == 200) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
				int damage = 45;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.FrostBeam; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer3++ == 220) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
				int damage = 45;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.FrostBeam; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
			}
			if(projectileTimer4++ == 240) // EVERY 60 TICKS EQUALS TO 1 SECOND SO THIS CAUSES BOSS TO SHOOT EVERY 3 SECOND
			{
				Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
				Player player = Main.player[npc.target];
							
				float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
				int damage = 45;  // The damage your projectile deals.
				float knockBack = 5;
				int type = ProjectileID.FrostBeam; // The type of the projectile you want to shoot.
							
				Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
					new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
				Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);
				
				projectileTimer1 = 0;
				projectileTimer2 = 0;
				projectileTimer3 = 0;
				projectileTimer4 = 0;
			}
			if (npc.life <= 40000)
			{
				if(Main.rand.Next(40) == 0)
			{
					Main.PlaySound(SoundID.NPCHit52, npc.position); // plays a sound
							
					Player player = Main.player[npc.target];
							
					float projectileSpeed = 14f;  // The speed of your projectile (in pixels per second).
					int damage = 24;  // The damage your projectile deals.
					float knockBack = 5;
					int type = ProjectileID.IcewaterSpit; // The type of the projectile you want to shoot.
							
					Vector2 velocity = Vector2.Normalize(new Vector2(player.position.X + player.width / 2, player.position.Y + player.height / 2) - 
						new Vector2(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2)) * projectileSpeed; // We get a correct velocity towards the player.
							
					Projectile.NewProjectile(npc.position.X + npc.width / 2, npc.position.Y + npc.height / 2, velocity.X, velocity.Y, type, damage, knockBack, Main.myPlayer);			
			}
			}
			
 
            int minTilePosX = (int)(npc.position.X / 16.0) - 1;
            int maxTilePosX = (int)((npc.position.X + npc.width) / 16.0) + 2;
            int minTilePosY = (int)(npc.position.Y / 16.0) - 1;
            int maxTilePosY = (int)((npc.position.Y + npc.height) / 16.0) + 2;
            if (minTilePosX < 0)
                minTilePosX = 0;
            if (maxTilePosX > Main.maxTilesX)
                maxTilePosX = Main.maxTilesX;
            if (minTilePosY < 0)
                minTilePosY = 0;
            if (maxTilePosY > Main.maxTilesY)
                maxTilePosY = Main.maxTilesY;
 
            bool collision = false;
            // This is the initial check for collision with tiles.
            for (int i = minTilePosX; i < maxTilePosX; ++i)
            {
                for (int j = minTilePosY; j < maxTilePosY; ++j)
                {
                    if (Main.tile[i, j] != null && (Main.tile[i, j].nactive() && (Main.tileSolid[(int)Main.tile[i, j].type] || Main.tileSolidTop[(int)Main.tile[i, j].type] && (int)Main.tile[i, j].frameY == 0) || (int)Main.tile[i, j].liquid > 64))
                    {
                        Vector2 vector2;
                        vector2.X = (float)(i * 16);
                        vector2.Y = (float)(j * 16);
                        if (npc.position.X + npc.width > vector2.X && npc.position.X < vector2.X + 16.0 && (npc.position.Y + npc.height > (double)vector2.Y && npc.position.Y < vector2.Y + 16.0))
                        {
                            collision = true;
                            if (Main.rand.Next(100) == 0 && Main.tile[i, j].nactive())
                                WorldGen.KillTile(i, j, true, true, false);
                        }
                    }
                }
            }
            // If there is no collision with tiles, we check if the distance between this NPC and its target is too large, so that we can still trigger 'collision'.
            if (!collision)
            {
                Rectangle rectangle1 = new Rectangle((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height);
                int maxDistance = 1000;
                bool playerCollision = true;
                for (int index = 0; index < 255; ++index)
                {
                    if (Main.player[index].active)
                    {
                        Rectangle rectangle2 = new Rectangle((int)Main.player[index].position.X - maxDistance, (int)Main.player[index].position.Y - maxDistance, maxDistance * 2, maxDistance * 2);
                        if (rectangle1.Intersects(rectangle2))
                        {
                            playerCollision = false;
                            break;
                        }
                    }
                }
                if (playerCollision)
                    collision = true;
            }
 
            // speed determines the max speed at which this NPC can move.
            // Higher value = faster speed.
            float speed = 15f;
            // acceleration is exactly what it sounds like. The speed at which this NPC accelerates.
            float acceleration = 0.08f;
 
            Vector2 npcCenter = new Vector2(npc.position.X + npc.width * 0.5f, npc.position.Y + npc.height * 0.5f);
            float targetXPos = Main.player[npc.target].position.X + (Main.player[npc.target].width / 2);
            float targetYPos = Main.player[npc.target].position.Y + (Main.player[npc.target].height / 2);
 
            float targetRoundedPosX = (float)((int)(targetXPos / 16.0) * 16);
            float targetRoundedPosY = (float)((int)(targetYPos / 16.0) * 16);
            npcCenter.X = (float)((int)(npcCenter.X / 16.0) * 16);
            npcCenter.Y = (float)((int)(npcCenter.Y / 16.0) * 16);
            float dirX = targetRoundedPosX - npcCenter.X;
            float dirY = targetRoundedPosY - npcCenter.Y;
 
            float length = (float)Math.Sqrt(dirX * dirX + dirY * dirY);
            // If we do not have any type of collision, we want the NPC to fall down and de-accelerate along the X axis.
            if (!collision)
            {
                npc.TargetClosest(true);
                npc.velocity.Y = npc.velocity.Y + 0.11f;
                if (npc.velocity.Y > speed)
                    npc.velocity.Y = speed;
                if (Math.Abs(npc.velocity.X) + Math.Abs(npc.velocity.Y) < speed * 0.4)
                {
                    if (npc.velocity.X < 0.0)
                        npc.velocity.X = npc.velocity.X - acceleration * 1.1f;
                    else
                        npc.velocity.X = npc.velocity.X + acceleration * 1.1f;
                }
                else if (npc.velocity.Y == speed)
                {
                    if (npc.velocity.X < dirX)
                        npc.velocity.X = npc.velocity.X + acceleration;
                    else if (npc.velocity.X > dirX)
                        npc.velocity.X = npc.velocity.X - acceleration;
                }
                else if (npc.velocity.Y > 4.0)
                {
                    if (npc.velocity.X < 0.0)
                        npc.velocity.X = npc.velocity.X + acceleration * 0.9f;
                    else
                        npc.velocity.X = npc.velocity.X - acceleration * 0.9f;
                }
            }
            // Else we want to play some audio (soundDelay) and move towards our target.
            else
            {
                if (npc.soundDelay == 0)
                {
                    float num1 = length / 40f;
                    if (num1 < 10.0)
                        num1 = 10f;
                    if (num1 > 20.0)
                        num1 = 20f;
                    npc.soundDelay = (int)num1;
                    Main.PlaySound(15, (int)npc.position.X, (int)npc.position.Y, 1);
                }
                float absDirX = Math.Abs(dirX);
                float absDirY = Math.Abs(dirY);
                float newSpeed = speed / length;
                dirX = dirX * newSpeed;
                dirY = dirY * newSpeed;
                if (npc.velocity.X > 0.0 && dirX > 0.0 || npc.velocity.X < 0.0 && dirX < 0.0 || (npc.velocity.Y > 0.0 && dirY > 0.0 || npc.velocity.Y < 0.0 && dirY < 0.0))
                {
                    if (npc.velocity.X < dirX)
                        npc.velocity.X = npc.velocity.X + acceleration;
                    else if (npc.velocity.X > dirX)
                        npc.velocity.X = npc.velocity.X - acceleration;
                    if (npc.velocity.Y < dirY)
                        npc.velocity.Y = npc.velocity.Y + acceleration;
                    else if (npc.velocity.Y > dirY)
                        npc.velocity.Y = npc.velocity.Y - acceleration;
                    if (Math.Abs(dirY) < speed * 0.2 && (npc.velocity.X > 0.0 && dirX < 0.0 || npc.velocity.X < 0.0 && dirX > 0.0))
                    {
                        if (npc.velocity.Y > 0.0)
                            npc.velocity.Y = npc.velocity.Y + acceleration * 2f;
                        else
                            npc.velocity.Y = npc.velocity.Y - acceleration * 2f;
                    }
                    if (Math.Abs(dirX) < speed * 0.2 && (npc.velocity.Y > 0.0 && dirY < 0.0 || npc.velocity.Y < 0.0 && dirY > 0.0))
                    {
                        if (npc.velocity.X > 0.0)
                            npc.velocity.X = npc.velocity.X + acceleration * 2f;
                        else
                            npc.velocity.X = npc.velocity.X - acceleration * 2f;
                    }
                }
                else if (absDirX > absDirY)
                {
                    if (npc.velocity.X < dirX)
                        npc.velocity.X = npc.velocity.X + acceleration * 1.1f;
                    else if (npc.velocity.X > dirX)
                        npc.velocity.X = npc.velocity.X - acceleration * 1.1f;
                    if (Math.Abs(npc.velocity.X) + Math.Abs(npc.velocity.Y) < speed * 0.5)
                    {
                        if (npc.velocity.Y > 0.0)
                            npc.velocity.Y = npc.velocity.Y + acceleration;
                        else
                            npc.velocity.Y = npc.velocity.Y - acceleration;
                    }
                }
                else
                {
                    if (npc.velocity.Y < dirY)
                        npc.velocity.Y = npc.velocity.Y + acceleration * 1.1f;
                    else if (npc.velocity.Y > dirY)
                        npc.velocity.Y = npc.velocity.Y - acceleration * 1.1f;
                    if (Math.Abs(npc.velocity.X) + Math.Abs(npc.velocity.Y) < speed * 0.5)
                    {
                        if (npc.velocity.X > 0.0)
                            npc.velocity.X = npc.velocity.X + acceleration;
                        else
                            npc.velocity.X = npc.velocity.X - acceleration;
                    }
                }
            }
            // Set the correct rotation for this NPC.
            npc.rotation = (float)Math.Atan2(npc.velocity.Y, npc.velocity.X) + 1.57f;
           
            // Some netupdate stuff (multiplayer compatibility).
            if (collision)
            {
                if (npc.localAI[0] != 1)
                    npc.netUpdate = true;
                npc.localAI[0] = 1f;
            }
            else
            {
                if (npc.localAI[0] != 0.0)
                    npc.netUpdate = true;
                npc.localAI[0] = 0.0f;
            }
            if ((npc.velocity.X > 0.0 && npc.oldVelocity.X < 0.0 || npc.velocity.X < 0.0 && npc.oldVelocity.X > 0.0 || (npc.velocity.Y > 0.0 && npc.oldVelocity.Y < 0.0 || npc.velocity.Y < 0.0 && npc.oldVelocity.Y > 0.0)) && !npc.justHit)
                npc.netUpdate = true;
 
            return false;
        }
 
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {
            Texture2D texture = Main.npcTexture[npc.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            Main.spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
            return false;
        }
		
		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GnarlyTooth"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GnarlyTooth"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FattyHide"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlbinoClump"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlbinoClump"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlbinoClump"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AlbinoClump"));
			
			if (Main.rand.Next(3) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("GnarlyTooth"), 2);
			
			if (Main.rand.Next(3) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("FattyHide"), 4);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("GhastlyHeart"), 1);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("FeelerMembrane"), 1);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("GnarlyTooth"), 2);
			
			if (Main.rand.Next(10) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("GnarlyTooth"), 2);
			
			if (Main.rand.Next(3) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("AlbinoClump"), 2);
			
			if (Main.rand.Next(5) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("AlbinoClump"), 2);
			
			if (Main.rand.Next(10) == 0)
				Item.NewItem(npc.getRect(), mod.ItemType("AlbinoClump"), 2);
			
			if (!SaobiesModWorld.downedAlbinoMaw)
			{
				SaobiesModWorld.downedAlbinoMaw = true;
				if (Main.netMode == NetmodeID.Server)
					NetMessage.SendData(MessageID.WorldData); // Immediately inform clients of new world state.
			}
			
		}  
		
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.9f;   //this make the NPC Health Bar biger
            return null;
        }
    }
}