using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Consumables
{
	public class MawTreasureBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}
		 public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 11;
            bossBagNPC = mod.NPCType("TheMaw");  //add this if the tresure bag is droped from a boss
            item.expert = true;      //add this if it's expert mode only
        }
        public override bool CanRightClick()
        {
            return true;
        }
 
        public override void OpenBossBag(Player player)
        {                                         //below it's a choice from 3 items that will drop randomly
            int choice = Main.rand.Next(9);
            if (choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("HungryBow"));      
            }
            if (choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("FeederFlail"));
            }
            if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("FeederheadStaff"));
            }
			if (choice == 3)
            {
                player.QuickSpawnItem(mod.ItemType("HorribleClump"), 2);
            }
			if (choice == 4)
            {
                player.QuickSpawnItem(mod.ItemType("HorribleClump"), 2);
            }
			if (choice == 5)
            {
                player.QuickSpawnItem(mod.ItemType("HorrificTooth"), 2);
            }
			if (choice == 6)
            {
                player.QuickSpawnItem(mod.ItemType("HorrificTooth"), 2);
            }
			if (choice == 7)
            {
                player.QuickSpawnItem(mod.ItemType("GhastlyHeart"));
            }
			if (choice == 8)
            {
                player.QuickSpawnItem(mod.ItemType("FeelerMembrane"));
            }
            //and this is the items that will 100% drop from the treasure bag
            player.QuickSpawnItem(mod.ItemType("HorrificTooth"), Main.rand.Next(3, 5));
			player.QuickSpawnItem(mod.ItemType("HorribleClump"), Main.rand.Next(3, 5));
            player.QuickSpawnItem(mod.ItemType("GhastlyGaze"));
        }
    }
}