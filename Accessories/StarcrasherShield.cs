using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class StarcrasherShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Enchanted magic shield that provides great magical bonuses"
				+ "\n+20 max mana and greatly improved mana regen"
				+ "\nImmune to most debuffs"
				+ "\n+10% magic damage and crit"
				+ "\n-5% mana cost"
				+ "\nAble to dash"
				+ "\nEmits blue light"
				+ "\n+1 max minions and sentries");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.magic = true;
			item.width = 24;
			item.height = 28;
			item.value = Item.buyPrice(0, 90, 0, 0);
			item.rare = 9;
			item.accessory = true;
			item.expert = true;
			item.defense = 5;
			
		}
	/*	public override void CanEquip(Player player)
		{
			ItemID.MagicCuffs = false;
			ItemID.CelestialCuffs = false;
			ItemID.ManaFlower = false;
			ItemID.SorcerersEmblem = false;
			ItemID.AnkhShield = false;
			ItemID.StarCloak = false;
			ItemID.Tabi = false;
		}  */

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.magicDamage += 0.05f;
				player.magicCrit += 5;
				player.manaCost -= 0.05f;
				player.manaRegen += 5;
				player.manaRegenBonus += 5;
				player.statManaMax2 += 20;
				player.buffImmune[BuffID.Frozen] = true;
				player.buffImmune[BuffID.Bleeding] = true;
				player.buffImmune[BuffID.Cursed] = true;
				player.buffImmune[BuffID.Slow] = true;
				player.buffImmune[BuffID.Confused] = true;
				player.buffImmune[BuffID.Chilled] = true;
				player.buffImmune[BuffID.BrokenArmor] = true;
				player.buffImmune[BuffID.Burning] = true;
				player.buffImmune[BuffID.Weak] = true;
				player.buffImmune[BuffID.Silenced] = true;
				player.buffImmune[BuffID.Darkness] = true;
				player.buffImmune[BuffID.Blackout] = true;
				player.buffImmune[BuffID.Poisoned] = true;
				player.dash = 4;
				player.maxMinions += 1;
				player.maxTurrets += 1;
				player.dashDelay = 120;
				player.dashTime = 30;
				Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 1.0f, 1.0f, 1.6f);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ArchmageEmblem", 1);
			recipe.AddIngredient(null, "StarBar", 5);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.AnkhShield, 1);
			recipe.AddIngredient(ItemID.EoCShield, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}