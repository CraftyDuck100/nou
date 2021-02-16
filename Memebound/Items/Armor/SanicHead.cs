using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Memebound.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SanicHead : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The head of a 3 year old's Sonic OC" +
			"\n+1000% increased movement speed" +
			"\n[c/FFFF0F:Gotta Go Faaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaast]");
			DisplayName.SetDefault("Sanic Head");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.defense = 999999999;
		}
		
		public override void UpdateEquip(Player player) {
			player.moveSpeed += 100f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<SonicTunic>() && legs.type == ModContent.ItemType<SonicPants>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "+10000% increased movement speed \nImmunity to 'Slow' \n[c/FFFF00:The only downside of traveling faster than light, is that you always live in darkness.]";
			player.moveSpeed += 100f;
			player.buffImmune[BuffID.Slow] = true;
		}
	}
}