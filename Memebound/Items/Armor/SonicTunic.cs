using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SonicTunic : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sonic Tunic");
			Tooltip.SetDefault("A tunic made of pure sonic AND speed"
				+ "\n700% increased movement speed"
				+ "\n[c/FFFF00:Even Usain Bolt is jealous!]");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 7f;
		}
	}
}