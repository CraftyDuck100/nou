using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Memebound.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SonicHead : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A helm crafted out of the spines of a blue hedgehog" +
			"\n+300% increased movement speed" +
			"\n+999999999 max health" +
			"\n[c/FFFF00:You're too slow!]");
			DisplayName.SetDefault("Sonic Head");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
		}
		
		public override void UpdateEquip(Player player) {
			player.moveSpeed += 3f;
			player.statLifeMax2 += 999999999;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<SonicTunic>() && legs.type == ModContent.ItemType<SonicPants>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "+10000% increased movement speed \nImmunity to 'Slow' [c/FFFF00:The only downside of traveling faster than light, is that you always live in darkness.]";
			player.moveSpeed += 100f;
			player.buffImmune[BuffID.Slow] = true;
		}
	}
}