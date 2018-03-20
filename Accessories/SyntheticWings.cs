using Terraria;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class SyntheticWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Wings made of some synthetic material. They seem fake, but oddly enough you actually can fly with these.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 14, 0, 0);
			item.rare = 2;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 60;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.7f;
			ascentWhenRising = 0.12f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1.8f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 7f;
			acceleration *= 2f;
		}
	}
}