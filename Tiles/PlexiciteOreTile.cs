using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace SaobiesMod.Tiles
{
	public class PlexiciteOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			Main.tileValue[Type] = 500;
			Main.tileSpelunker[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.addTile(Type);
			drop = mod.ItemType("PlexiciteOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Plexicite");
			AddMapEntry(new Color(170, 170, 200), name);
			minPick = 55;
		}
	}
}