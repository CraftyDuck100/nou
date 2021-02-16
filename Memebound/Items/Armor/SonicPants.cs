using Memebound.Items;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Memebound.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]	
	public class SonicPants : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Pants fused and reinforced with raidoactive blue quills"
				+ "\n1000% increased movement speed"
				+ "\n+1000% ALL damage"
				+ "\n+696969696 max health"
				+ $"\n[c/FFFF00:You can do it Sonic! You can beat the Totinos!][i:{ModContent.ItemType<Tails>()}]");
			DisplayName.SetDefault("Sonic Pants");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 99999999;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 100f;
			player.statLifeMax2 += 696969696;
			player.allDamage += 100f;
		}
	}
}