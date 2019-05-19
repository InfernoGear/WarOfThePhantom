using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WarOfThePhantom.Projectiles
{
    public class EnchantedFuryBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Fury Beam");
        }

        public override void SetDefaults()
        {
            projectile.width = 28;
            projectile.height = 28;
            projectile.aiStyle = 27;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 2000;
            projectile.alpha = 0;
            projectile.light = 1f;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            aiType = ProjectileID.EnchantedBeam;
        }
    }
}
