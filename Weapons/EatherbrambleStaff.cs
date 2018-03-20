using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;


namespace SaobiesMod.Items.Weapons       ///We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class EatherbrambleStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Create an ethereal bramble sentry that conjures swords at foes."
							+ "\nConsumes a summoner stone.");
		}
        public override void SetDefaults()
        {
           
            item.damage = 60;  //The damage stat for the Weapon.
            item.mana = 20;      //this defines how many mana this weapon use
            item.width = 56;    //The size of the width of the hitbox in pixels.
            item.height = 56;     //The size of the height of the hitbox in pixels.
            item.useTime = 25;   //How fast the Weapon is used.
            item.useAnimation = 25;    //How long the Weapon is used for.
            item.useStyle = 1;  //The way your Weapon will be used, 1 is the regular sword swing for example
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2.5f;  //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 35, 0, 0); //	How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 3;   //The color the title of your Weapon when hovering over it ingame  
            item.UseSound = SoundID.Item44;   //The sound played when using your Weapon
            item.autoReuse = true;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = mod.ProjectileType("EatherbrambleSentry");   //This defines what type of projectile this weapon will shot	
            item.summon = true;    //This defines if it does Summon damage and if its effected by Summon increasing Armor/Accessories.
            item.sentry = true; //tells the game that this is a sentry
			item.useAmmo = mod.ItemType("SummonerStone");
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 SPos = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);   //this make so the projectile will spawn at the mouse cursor position
            position = SPos;
            for (int l = 0; l < Main.projectile.Length; l++)
            {                                                                  //this make so you can only spawn one of this projectile at the time,
                Projectile proj = Main.projectile[l];
                if (proj.active && proj.type == item.shoot && proj.owner == player.whoAmI)
                {
                    proj.active = false;
                }
            }
            return true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FirebrambleStaff", 1);
			recipe.AddIngredient(mod, "SummonerStone", 100);
			recipe.AddIngredient(mod, "SwordStorm", 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}