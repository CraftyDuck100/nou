using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;

namespace Memebound.Projectiles
{
	public class Tide : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tide");     //The English name of the projectile
			Main.projFrames[projectile.type] = 5;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(612);
			projectile.melee = false;
			projectile.ranged = true;
			projectile.aiStyle = 117;
			aiType = 612;
		}
	}
}
