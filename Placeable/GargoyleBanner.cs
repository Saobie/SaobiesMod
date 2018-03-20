using Terraria;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Placeable          //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class GargoyleBanner : ModItem
    {
        public override void SetDefaults()
        {
    
            item.width = 10;    //sprite width
            item.height = 24;  //sprite height
            item.maxStack = 99;  //This defines the items max stack
            item.useTurn = true;
            item.autoReuse = true;  //Weather your item will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.useAnimation = 15;  //How long the item is used for.
            item.useTime = 10;  //How fast the item is used.
            item.useStyle = 1;  //The way your item will be used, 1 is the regular sword swing for example
            item.consumable = true;  //Tells the game that this should be used up once placed
            item.rare = 1; //The color the title of your item when hovering over it ingame
            item.value = Item.buyPrice(0, 0, 10, 0);  //    How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10silver)
            item.createTile = mod.TileType("GargoyleBannerTile");  //This defines what type of tile this item will place 
            item.placeStyle = 0;
        }
    }
}
////then add this to the custom npc you want to drop the banner and in public override void SetDefaults()
/*  banner = npc.type;
  bannerItem = mod.ItemType("CustomBannerItem"); //this defines what banner this npc will drop       */