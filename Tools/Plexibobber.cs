using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SaobiesMod.Items.Tools     
{
    public class Plexibobber : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fishing pole made from Plexicite. Throws 2 bobbers at once.");
		}
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GoldenFishingRod);  
            item.fishingPole = 35;        
            item.value = Item.buyPrice(0, 25, 0, 0);
            item.rare = 5;  
            item.shoot = mod.ProjectileType("PlexibobberProjectile");  
            item.shootSpeed = 18f; 
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 2 + Main.rand.Next(0); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }  
        public override void AddRecipes()  
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteOre", 8);
			recipe.AddIngredient(mod, "PlexiciteBar", 10);
			recipe.AddIngredient(ItemID.CobaltBar, 25);
			recipe.AddIngredient(ItemID.Diamond, 4);
			recipe.AddIngredient(ItemID.Sapphire, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}