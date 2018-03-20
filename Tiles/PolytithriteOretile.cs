using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace SaobiesMod.Tiles
{
	public class PolytithriteOreTile : ModTile
	{
		public int soundType = 0;
        public int soundStyle = 1;
		public float mineResist = 1.6f;
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			Main.tileValue[Type] = 700;
			Main.tileSpelunker[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.addTile(Type);
			drop = mod.ItemType("PolytithriteOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Polytithrite");
			AddMapEntry(new Color(030, 050, 050), name);
			minPick = 180;
			
		}
		 public virtual bool CanExplode(int i, int j)
           {
               return false;
           }
	}
}