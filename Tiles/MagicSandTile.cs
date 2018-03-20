using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
 
namespace SaobiesMod.Tiles
{
    public class MagicSandTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileBlockLight[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;      
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("MagicSand");   
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Magic Sand");
            AddMapEntry(new Color(200, 50, 200), name);      
            soundType = 19;
            soundStyle = 2;
        //    SetModTree(new GeodeTree());  
        }
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1.0f;
			g = 0.4f;
			b = 1.0f;
		}
    /*    public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("GeodeSapling");        
        }  */
    }
}