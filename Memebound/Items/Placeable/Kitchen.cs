using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items.Placeable
{
	public class Kitchen : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("The Kitchen");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.Kitchen>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MetalSink);
			recipe.AddIngredient(ItemID.Keg);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}