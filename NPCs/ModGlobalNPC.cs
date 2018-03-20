using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs          
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
			if (NPC.downedMechBossAny)
			{
            if (Main.rand.Next(100) < 1)   //item rarity
            {
                if (Main.player[Main.myPlayer].ZoneCrimson) // world biome 
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VileEssence"));
                    }    
            }
			
			if (Main.rand.Next(100) < 1) 
            {
                if (Main.player[Main.myPlayer].ZoneCrimson) 
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EvilEssence"));
                    }    
            }
			}

			if (npc.type == NPCID.Plantera) // the npc to drop
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(60, 100));
                if (Main.rand.Next(2) == 0)   //item rarity 2
                {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TaintedShard")); //Item spawn
                }
            }
			
			if (SaobiesModWorld.downedMoonLord) // the npc to drop
            {
				if (Main.rand.Next(300) < 1)   //item rarity
				{
					if (Main.player[Main.myPlayer].ZoneDungeon) // world biome 
						{
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RitualDagger"));
						}    
				}
			}

			if (npc.type == NPCID.EyeofCthulhu) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(5, 10));
			}
			if (npc.type == NPCID.BrainofCthulhu) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(15, 25));
			}
			if (npc.type == NPCID.EaterofWorldsHead) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(1, 2));
			}
			if (npc.type == NPCID.SkeletronHead) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(20, 30));
			}
			if (npc.type == NPCID.WallofFlesh) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(25, 35));
			}
			if (npc.type == NPCID.SkeletronPrime)
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(40, 50));
			}
			if (npc.type == NPCID.TheDestroyer)
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(40, 50));
			}
			if (npc.type == NPCID.Retinazer)
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(20, 25));
			}
			if (npc.type == NPCID.Spazmatism) 
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(20, 25));
			}
			if (npc.type == NPCID.Golem)
            {
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SummonerStone"), Main.rand.Next(80, 120));
			}
			
			
			
			if (npc.type == NPCID.MoonLordCore) // the npc to drop
            {
				if (!SaobiesModWorld.downedMoonLord)
				{
				SaobiesModWorld.downedMoonLord = true;
				if (Main.netMode == NetmodeID.Server)
					NetMessage.SendData(MessageID.WorldData); // Immediately inform clients of new world state.
				}
			}

            if (npc.type == NPCID.Probe)
            {
                
                    if (Main.rand.Next(200) < 1) 
                    {
                        if (Main.player[Main.myPlayer].ZoneCrimson)  
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MechanicalBatteryPiece);
                        }
                    }
                    if (Main.rand.Next(200) < 1)  
                    {
                        if (Main.player[Main.myPlayer].ZoneCrimson) 
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MechanicalWheelPiece);
                        }
                    }
                    if (Main.rand.Next(200) < 1)  
                    {
                        if (Main.player[Main.myPlayer].ZoneCrimson) 
                        {
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MechanicalWagonPiece);
                        }
                    }
          /*      if (NPC.downedMechBossAny)
                {
                    public override float SpawnChance(NPCSpawnInfo spawnInfo)
                    {
                        return SpawnCondition.OverworldNight.Chance * 0.08f;
                    }
                }  */
            }
        }
    }
}