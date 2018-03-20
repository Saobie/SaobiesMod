using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Utilities;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

namespace SaobiesMod.Tiles
{
	public class Gemroot : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = true;
			//Main.tileAlch[Type] = true;
			Main.tileNoFail[Type] = true;
			Main.tileLavaDeath[Type] = true;
			//dustType = -1;
			//disableSmartCursor = true;
			//AddMapEntry(new Color(13, 88, 130), "Banner");
			TileObjectData.newTile.Width = 1;
			TileObjectData.newTile.Height = 1;
			//TileObjectData.newTile.Origin = Point16.Zero;
			//TileObjectData.newTile.UsesCustomCanPlace = true;
			//TileObjectData.newTile.CoordinateHeights = new int[]
			//{
			//	20
			//};
			//TileObjectData.newTile.CoordinateWidth = 16;
			//TileObjectData.newTile.CoordinatePadding = 2;
			//TileObjectData.newTile.DrawYOffset = -1;
			//TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.AlternateTile, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
			TileObjectData.newTile.LavaDeath = true;
			TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
			//TileObjectData.addBaseTile(out TileObjectData.StyleAlch);
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
			TileObjectData.newTile.AnchorValidTiles = new int[]
			{
				2, //TileID.Grass
				109, // TileId.HallowedGrass
				mod.TileType<MagicSandTile>()
			};
			TileObjectData.addTile(Type);
			//drop = mod.ItemType()
		}
		//public override bool CanPlace(int i, int j)
		//{
		//	return base.CanPlace(i, j);
		//}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override bool Drop(int i, int j)
		{
			int stage = Main.tile[i, j].frameX / 18;
			if (stage == 2)
			{
				
				WeightedRandom<int> chances = new WeightedRandom<int>();
				chances.Add(ItemID.Amethyst, 100);
				chances.Add(ItemID.Topaz, 80);
				chances.Add(ItemID.Emerald, 50);
				chances.Add(ItemID.Sapphire, 40);
				chances.Add(ItemID.Amber, 30);
				chances.Add(ItemID.Ruby, 15);
				chances.Add(ItemID.Diamond, 5);
				Item.NewItem(i*16, j*16, 16, 16, chances.Get(), Main.rand.Next(1, 6));
				
				if (Main.dayTime)
				{
					if (Main.moonPhase == 3)
					{
						Item.NewItem(i * 16, j * 16, 0, 0,  mod.ItemType("GemrootSeeds"), Main.rand.Next(1, 3));
					}
				}
				
			}
			return false;
		}
		public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
		{
			if (Main.dayTime)
				{
					if (Main.moonPhase == 3)
					{
						if (Main.rand.NextBool(10))
						{
							Dust.NewDust(new Vector2(i * 16, j * 16), 16, 16, 20, 0, 0, 0, new Color(220, 100, 220), 1f);
						}
					}
				}
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].frameX == 0)
			{
				Main.tile[i, j].frameX += 18;
			}
			else if (Main.tile[i, j].frameX == 18)
			{
				Main.tile[i, j].frameX += 18;
			}
		}
		//public override void RightClick(int i, int j)
		//{
		//	base.RightClick(i, j);
		//}
	}
}
