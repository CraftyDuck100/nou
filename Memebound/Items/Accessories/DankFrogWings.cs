using Memebound.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Memebound.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class DankFrogWings : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The wings of the Meme Lord"
			+ "\n[c/00FFCF:Waaaaaaaaaaiiiiiiit, Ze Dank Frog doesn't have wings");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.wingTimeMax = 999999999;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend) {
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration) {
			speed = 9f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WingsSolar);
			recipe.AddIngredient(ItemID.WingsStardust);
			recipe.AddIngredient(ItemID.WingsNebula);
			recipe.AddIngredient(ItemID.WingsVortex);
			//Change to to Memer's Den later
			recipe.AddTile(ModContent.TileType<GoogleDrive>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}