using Terraria;
using Terraria.ModLoader;

namespace Memebound.Buffs
{
	public class TankEngineMount : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Tank Engine");
			Description.SetDefault("They're 2, they're 4, they're 6, they're 8]");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.TankEngine>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
