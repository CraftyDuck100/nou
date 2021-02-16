using Memebound.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items.Weapons
{
	public class KitchenRound : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoot it to clean up!"+"\nPhases through walls"+"\nIt even works UNDERWATER!");
			DisplayName.SetDefault("Kitchen Round");
		}

		public override void SetDefaults() {
			item.damage = 9999999;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.Purple;
			item.shoot = ModContent.ProjectileType<Projectiles.KitchenRound>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddTile(ModContent.TileType<Kitchen>());
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}
