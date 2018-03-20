using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items              //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class GlobusFish : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Strange fish that apparently feeds on everything it can swallow, but loves slimes."
					+ "\nYou could give this to the angler. But there may be something useful in its guts.");
		}
		
        public override void SetDefaults()
        {
            
            item.questItem = true;    //this defines if this is a ques item or not
            item.maxStack = 1;  //This defines the items max stack
            item.width = 26;    //The size in width of the sprite in pixels.
            item.height = 26;    //The size in height of the sprite in pixels.
       //     item.uniqueStack = true;  //this make so you can have only one of this item in your inventory
            item.rare = -11;        //The rarity of -11 gives the item orange color
			item.consumable = true;
        }
 
		public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }
		
		public override void RightClick(Player player)  //this make so when you right click this item, then one of these items will drop
        {
			
                int Choose = Main.rand.Next(11);      //so there are 5 items to choose from, but only one will drop  ,  if you want to add more drops change the num 5 with how many items you want and below add another  if (Choose == number)      
                if (Choose == 0)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("CrateRing")); //this is an example of how to add a modded item, change customSentryItem with your modded item name
                }
                if (Choose == 1)                                                    //2 item
                {
                    player.QuickSpawnItem(mod.ItemType("SpelunkerRing"));
                }
                if (Choose == 2)                                                   // 3 item
                {
                    player.QuickSpawnItem(ItemID.Sextant, 1);
                }
                if (Choose == 3)                                                   // 4 item
                {
                    player.QuickSpawnItem(ItemID.MasterBait, 3);
                }
                if (Choose == 4)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.HerbBag, 1);
                }
                if (Choose == 5)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.IronCrate, 1);      //this is how to add another item
                }  
				if (Choose == 5)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Diamond, 2);      //this is how to add another item
                }  
				if (Choose == 6)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Ruby, 2);      //this is how to add another item
                }  
				if (Choose == 7)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Topaz, 2);      //this is how to add another item
                }  
				if (Choose == 8)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Sapphire, 2);      //this is how to add another item
                }  
				if (Choose == 9)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Emerald, 2);      //this is how to add another item
                }  
				if (Choose == 10)                                                  //5 item
                {
                    player.QuickSpawnItem(ItemID.Amethyst, 2);      //this is how to add another item
                }  
				player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(1, 2));
		}
 
        public override bool IsQuestFish()
        {
            return true;   //if it's a quest fish or not
        }
 
        public override bool IsAnglerQuestAvailable()
        {
            return NPC.downedSlimeKing;  //this defines when the angler will give you this quest,    return NPC.downedSlimeKing; is after you deafited kingslime
        }
 
        public override void AnglerQuestChat(ref string description, ref string catchLocation)
        {
            description = "I know a guy who knows a fish who knows a slime who knows that you need a baby slime for this quest.";   //this is the descrioption text when you get the custom text
            catchLocation = "\n(Caught in Ocean at day but you need a baby slime to help you)";  //this is the text that tells where and how to chath the custom fish
        }
    }
}