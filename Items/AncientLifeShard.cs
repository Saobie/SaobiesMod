using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Items
{
    public class AncientLifeShard : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shard possessing the nature of life itself. It seeps with ancient magic."
					+ "\nYou just made this, but thanks to the manipulator, its aged and useful.");
		}
        public override void SetDefaults()
        {        
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 30, 50, 0);
            item.rare = 9;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.maxStack = 999;
			item.consumable = true;
        }  
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("RootOfAncientLife"));
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			
			int choice = Main.rand.Next(3);
			if (choice == 0)
            {
				Main.NewText("Child of man, what do you seek from me?");
			}
			if (choice == 1)
            {
				Main.NewText("Sweet child, do not temper with that which you do not know.");
			}
			if (choice == 2)
            {
				Main.NewText("Do you understand life, child?");
			}
		
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 200);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.LifeFruit, 8);
			recipe.AddIngredient(ItemID.LifeCrystal, 4);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}  
    }
}