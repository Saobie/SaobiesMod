using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Tools
{
    public class PlexiciteDrill : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Highly practical drill made of refined Plexicite. Very effective and efficient at mining.");
		}
        public override void SetDefaults()
        {
  
            item.damage = 20;          
            item.melee = true;
            item.width = 20;
            item.height = 12;

            item.useTime = 7;
            item.useAnimation = 25;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.pick = 85;
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.buyPrice(0, 10, 20, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item23;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PlexiciteDrillProjectile");
            item.shootSpeed = 40f;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}