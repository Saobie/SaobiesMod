using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;
 
 
namespace SaobiesMod
{
    public class SaobiesModWorld : ModWorld
    {
		private const int saveVersion = 0;
		public static bool downedTheMaw = false;
		public static bool downedAlbinoMaw = false;
		public static bool downedMoonLord = false;
		
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex == -1)
			{
				return;
			}
			tasks.Insert(ShiniesIndex + 1, new PassLegacy("Plexicite And Polytithrite", delegate (GenerationProgress progress)
			{
				progress.Message = "Growing rare ores";
				
				for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
				{
					WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(4, 6), WorldGen.genRand.Next(4, 5), mod.TileType("PlexiciteOreTile"), false, 0f, 0f, false, true);
					WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), (double)WorldGen.genRand.Next(4, 4), WorldGen.genRand.Next(4, 4), mod.TileType("PolytithriteOreTile"), false, 0f, 0f, false, true);
				}
			}));
        }
		public override void Initialize()
		{
			downedTheMaw = false;
			downedMoonLord = false;
			downedAlbinoMaw = false;
		}
		
		public override TagCompound Save()
		{
			var downed = new List<string>();
			if (downedTheMaw) downed.Add("TheMaw");
			if (downedMoonLord) downed.Add("MoonLord");
			if (downedAlbinoMaw) downed.Add("AlbinoMaw");
			
			return new TagCompound {
				{"downed", downed}
			};
		}
		public override void Load(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			downedTheMaw = downed.Contains("TheMaw");
			downedMoonLord = downed.Contains("MoonLord");
			downedAlbinoMaw = downed.Contains("AlbinoMaw");
		}
		public override void NetSend(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = downedTheMaw;
			flags[1] = downedAlbinoMaw;
			flags[2] = downedMoonLord;
			writer.Write(flags);
		}
		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			downedTheMaw = flags[0];
			downedAlbinoMaw = flags[1];
			downedMoonLord = flags[2];
		}

    }
}