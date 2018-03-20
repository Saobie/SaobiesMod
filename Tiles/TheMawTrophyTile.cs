using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
 
namespace SaobiesMod.Tiles
{
    public class TheMawTrophyTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 36;
            TileObjectData.addTile(Type);          
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
			name.SetDefault("The Maw Trophy");
			AddMapEntry(new Color(120, 85, 60), name);
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY) //this make that when you break the Trophy it will give you the TrophyItem
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("TheMawTrophy"));
        }
 
    }
}