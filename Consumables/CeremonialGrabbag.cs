using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Consumables
{
	public class CeremonialGrabbag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ceremonial Grabbag");
			Tooltip.SetDefault("Contains some pretty suspicious stuff.");
		}
		 public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 11;
            bossBagNPC = mod.NPCType("WingedDjinn");  //add this if the tresure bag is droped from a boss
            item.expert = true;      //add this if it's expert mode only
        }
        public override bool CanRightClick()
        {
            return true;
        }
 
        public override void OpenBossBag(Player player)
        {                                         //below it's a choice from 3 items that will drop randomly
		
				int choice = Main.rand.Next(12);
					
				if (choice == 0)
				{
					player.QuickSpawnItem(mod.ItemType("WickedLookingEye"), 1);      
				}
				if (choice == 1)
				{
					player.QuickSpawnItem(mod.ItemType("WickedSlimeCrown"), 1);
				}
				if (choice == 2)
				{
					player.QuickSpawnItem(mod.ItemType("WickedWormFood"), 1);
				}
				if (choice == 3)
				{
					player.QuickSpawnItem(mod.ItemType("WickedAbeemination"), 1);
				}
				if (choice == 4)
				{
					player.QuickSpawnItem(mod.ItemType("WickedSpine"), 1);
				}
				if (choice == 5)
				{
					player.QuickSpawnItem(mod.ItemType("WickedWormFood"), 1);
				}
				if (choice == 6)
				{
					player.QuickSpawnItem(mod.ItemType("WickedClothierDoll"), 1);
				}
				if (choice == 7)
				{
					player.QuickSpawnItem(mod.ItemType("HorribleFlesh"), 1);
				}
				if (choice == 8)
				{
					player.QuickSpawnItem(mod.ItemType("WickedMechaskull"), 1);
				}
				if (choice == 9)
				{
					player.QuickSpawnItem(mod.ItemType("WickedMechaworm"), 1);
				}
				if (choice == 10)
				{
					player.QuickSpawnItem(mod.ItemType("WickedMechaeye"), 1);
				}
				if (choice == 11)
				{
					player.QuickSpawnItem(mod.ItemType("WickedTruffleWorm"), 1);
				}
			
        }
    }
}