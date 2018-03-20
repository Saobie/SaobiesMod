using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HelmOfAncientLife : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Life is not about finding yourself, it is about creating yourself."
							+ "\nImproved hp regen."
                            + "\n+15% melee speed."
                            + "\nIncreaced invincibility time."
                            + "\n+10% melee, thrown, and ranged damage."
							+ "\nIncreased heart pickup range.");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 9;
			item.defense = 40;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.lifeRegen += 1;
            player.longInvince = true;
            player.meleeDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.lifeMagnet = true;
            player.meleeSpeed += 0.15f;
        }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("HeartOfAncientLife") && legs.type == mod.ItemType("TreadsOfAncientLife");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Immune to most offensive debuffs, and desert winds. Extremely improved life regen. Reduced potion cooldown. +15% physical damage. +3 minions.";
			player.maxMinions += 3;	
			player.meleeDamage += 0.15f;
			player.rangedDamage += 0.15f;
			player.thrownDamage += 0.15f;
			player.lifeRegen += 10;
            player.potionDelayTime = (int)((double)player.potionDelayTime * 0.75);
            player.restorationDelayTime = (int)((double)player.restorationDelayTime * 0.75);
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.WindPushed] = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AncientLifewood", 100);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.CharmofMyths, 1);
            recipe.AddIngredient(ItemID.CrossNecklace, 1);
            recipe.AddIngredient(ItemID.LifeFruit, 3);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}