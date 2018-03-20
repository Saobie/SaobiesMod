using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Consumables
{
	public class LuckyGrabbag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lucky Grabbag");
			Tooltip.SetDefault("May fortune smile upon you.");
		}
		 public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 11;
            bossBagNPC = mod.NPCType("LuckySpirit");  //add this if the tresure bag is droped from a boss
           
        }
        public override bool CanRightClick()
        {
            return true;
        }
 
        public override void OpenBossBag(Player player)
        {                                         //below it's a choice from 3 items that will drop randomly
		
			if (Main.hardMode)
			{
				int choice1 = Main.rand.Next(7);
									
					if (choice1 == 0)
					{
						player.QuickSpawnItem(ItemID.MythrilBar, 5);      
					}
					if (choice1 == 1)
					{
						player.QuickSpawnItem(ItemID.CobaltBar, 5);
					}
					if (choice1 == 2)
					{
						player.QuickSpawnItem(ItemID.PalladiumBar, 5);
					}
					if (choice1 == 3)
					{
						player.QuickSpawnItem(ItemID.TitaniumBar, 5);
					}
					if (choice1 == 4)
					{
						player.QuickSpawnItem(ItemID.AdamantiteBar, 5);
					}
					if (choice1 == 5)
					{
						player.QuickSpawnItem(ItemID.OrichalcumBar, 5);
					}
					if (choice1 == 6)
					{
						player.QuickSpawnItem(ItemID.PlatinumCoin, 1);
					}	
					
				int choice2 = Main.rand.Next(7);
									
					if (choice2 == 0)
					{
						player.QuickSpawnItem(ItemID.Bladetongue, 1);      
					}
					if (choice2 == 1)
					{
						player.QuickSpawnItem(ItemID.ValkyrieYoyo, 1);
					}
					if (choice2 == 2)
					{
						player.QuickSpawnItem(ItemID.CrystalSerpent, 1);
					}
					if (choice2 == 3)
					{
						player.QuickSpawnItem(ItemID.PulseBow, 1);
					}
					if (choice2 == 4)
					{
						player.QuickSpawnItem(ItemID.Gatligator, 1);
					}
					if (choice2 == 5)
					{
						player.QuickSpawnItem(ItemID.ClingerStaff, 1);
					}
					if (choice2 == 6)
					{
						player.QuickSpawnItem(ItemID.RavenStaff, 1);
					}	
				int choice3 = Main.rand.Next(9);
									
					if (choice3 == 0)
					{
						player.QuickSpawnItem(ItemID.WoodenCrate, 1);      
					}
					if (choice3 == 1)
					{
						player.QuickSpawnItem(ItemID.IronCrate, 1);
					}
					if (choice3 == 2)
					{
						player.QuickSpawnItem(ItemID.GoldenCrate, 1);
					}
					if (choice3 == 3)
					{
						player.QuickSpawnItem(ItemID.JungleFishingCrate, 1);
					}
					if (choice3 == 4)
					{
						player.QuickSpawnItem(ItemID.HallowedFishingCrate, 1);
					}
					if (choice3 == 5)
					{
						player.QuickSpawnItem(ItemID.CorruptFishingCrate, 1);
						player.QuickSpawnItem(ItemID.AnglerTackleBag, 1);
					}
					if (choice3 == 6)
					{
						player.QuickSpawnItem(ItemID.CrimsonFishingCrate, 1);
						player.QuickSpawnItem(ItemID.FishFinder, 1);
					}	
					if (choice3 == 7)
					{
						player.QuickSpawnItem(ItemID.FloatingIslandFishingCrate, 1);
						player.QuickSpawnItem(ItemID.BottomlessBucket, 1);
					}
					if (choice3 == 8)
					{
						player.QuickSpawnItem(ItemID.DungeonFishingCrate, 1);
						player.QuickSpawnItem(ItemID.GoldenFishingRod, 1);
					}
					
					if (Main.rand.Next(10) == 0)
					{
						int choice4 = Main.rand.Next(9);
									
							if (choice4 == 0)
							{
								player.QuickSpawnItem(ItemID.BrainOfConfusion, 1); 
								player.QuickSpawnItem(ItemID.HardySaddle, 1);
							}
							if (choice4 == 1)
							{
								player.QuickSpawnItem(ItemID.WormScarf, 1);
								player.QuickSpawnItem(ItemID.BrainScrambler, 1);
							}
							if (choice4 == 2)
							{
								player.QuickSpawnItem(ItemID.MechanicalWheelPiece, 1);
								player.QuickSpawnItem(ItemID.MechanicalWagonPiece, 1);
								player.QuickSpawnItem(ItemID.MechanicalBatteryPiece, 1);
							}
							if (choice4 == 3)
							{
								player.QuickSpawnItem(mod.ItemType("EvolutionWorm"), 1);
							}
							if (choice4 == 4)
							{
								player.QuickSpawnItem(mod.ItemType("HorribleMaggot"), 1);
							}
							if (choice4 == 5)
							{
								player.QuickSpawnItem(ItemID.CorruptionKey, 1);
								player.QuickSpawnItem(ItemID.ReindeerBells, 1);
							}
							if (choice4 == 6)
							{
								player.QuickSpawnItem(ItemID.CrimsonKey, 1);
								player.QuickSpawnItem(ItemID.RedsWings, 1);
							}	
							if (choice4 == 7)
							{
								player.QuickSpawnItem(ItemID.HallowedKey, 1);
								player.QuickSpawnItem(ItemID.BejeweledValkyrieWing, 1);
							}
							if (choice4 == 8)
							{
								player.QuickSpawnItem(ItemID.JungleKey, 1);
								player.QuickSpawnItem(ItemID.FrozenKey, 1);
							}
					}
			}
			
			
				
					int choice5 = Main.rand.Next(4);
									
					if (choice5 == 0)
					{
						player.QuickSpawnItem(ItemID.GoldBar, 30);      
					}
					if (choice5 == 1)
					{
						player.QuickSpawnItem(ItemID.PlatinumBar, 30);
					}
					if (choice5 == 2)
					{
						player.QuickSpawnItem(ItemID.HellstoneBar, 20);
					}
					if (choice5 == 3)
					{
						player.QuickSpawnItem(mod.ItemType("PlexiciteBar"), 20);
					}
					
					int choice6 = Main.rand.Next(4);
									
					if (choice6 == 0)
					{
						player.QuickSpawnItem(ItemID.Arkhalis, 1);      
					}
					if (choice6 == 1)
					{
						player.QuickSpawnItem(ItemID.HellwingBow, 1);
					}
					if (choice6 == 2)
					{
						player.QuickSpawnItem(ItemID.PhoenixBlaster, 1);
					}
					if (choice6 == 3)
					{
						player.QuickSpawnItem(mod.ItemType("SwordStorm"), 1);
						player.QuickSpawnItem(mod.ItemType("SummonerStone"), 300);
					}
					
					int choice7 = Main.rand.Next(4);
									
					if (choice7 == 0)
					{
						player.QuickSpawnItem(ItemID.ManaRegenerationBand, 1);      
					}
					if (choice7 == 1)
					{
						player.QuickSpawnItem(mod.ItemType("PureSuspiciousRing"), 1);
					}
					if (choice7 == 2)
					{
						player.QuickSpawnItem(mod.ItemType("FusedRing"), 1);
					}
					if (choice7 == 3)
					{
						player.QuickSpawnItem(mod.ItemType("SyntheticWings"), 1);
					}
				
					if (Main.rand.Next(10) == 0)
					{
						int choice8 = Main.rand.Next(9);
									
						if (choice8 == 0)
						{
							player.QuickSpawnItem(ItemID.WoodenCrate, 1);      
						}
						if (choice8 == 1)
						{
							player.QuickSpawnItem(ItemID.IronCrate, 1);
						}
						if (choice8 == 2)
						{
							player.QuickSpawnItem(ItemID.GoldenCrate, 1);
						}
						if (choice8 == 3)
						{
							player.QuickSpawnItem(ItemID.JungleFishingCrate, 1);
							player.QuickSpawnItem(ItemID.FishFinder, 1);
						}
						if (choice8 == 4)
						{
							player.QuickSpawnItem(ItemID.HallowedFishingCrate, 1);
						}
						if (choice8 == 5)
						{
							player.QuickSpawnItem(ItemID.CorruptFishingCrate, 1);
						}
						if (choice8 == 6)
						{
							player.QuickSpawnItem(ItemID.CrimsonFishingCrate, 1);
							player.QuickSpawnItem(ItemID.BottomlessBucket, 1);
						}	
						if (choice8 == 7)
						{
							player.QuickSpawnItem(ItemID.FloatingIslandFishingCrate, 1);
							player.QuickSpawnItem(ItemID.AnglerTackleBag, 1);
						}
						if (choice8 == 8)
						{
							player.QuickSpawnItem(ItemID.DungeonFishingCrate, 1);
							player.QuickSpawnItem(ItemID.GoldenFishingRod, 1);
						}
					}
        }
    }
}