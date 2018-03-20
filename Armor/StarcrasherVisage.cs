using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StarcrasherVisage : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It is not in the stars to hold our destiny, but in ourselves."
							+ "\nImproved mana regen."
							+ "\nEmits blue light."
							+ "\n-5% mana cost."
							+ "\n+10% minion damage."
							+ "\nIncreased mana pickup range."
							+ "\n+50 max mana");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 9;
			item.defense = 30;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.manaRegen += 3;
			player.manaRegenBonus += 3;
			player.manaCost -= 0.05f;
			player.minionDamage += 0.1f;
			player.manaMagnet = true;
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.3f, 0.3f, 1.0f);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("StarcrasherAegis") && legs.type == mod.ItemType("StarcrasherTreads");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Immune to mana sickness and desert winds. +15% magic damage. Automatically uses mana potions when needed. +3 minions. +10% minion damage";
			player.maxMinions += 3;	
			player.minionDamage += 0.1f;
			player.magicDamage += 0.15f;
			player.manaFlower = true;
			player.buffImmune[BuffID.ManaSickness] = true;
			player.buffImmune[BuffID.WindPushed] = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 12);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.CelestialMagnet, 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.ManaFlower, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}