using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace Solaris.Projectiles 
{    
    public class NerfDartProj : ModProjectile 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Derf dart");
        }
        public override void SetDefaults()
        {
            projectile.width = 10; 
            projectile.height = 2; 
            projectile.timeLeft = 600; 
            projectile.penetrate = 1; 
            projectile.friendly = true; 
            projectile.hostile = false; 
            projectile.tileCollide = true; 
            projectile.ignoreWater = true; 
            projectile.ranged = true; 
            projectile.aiStyle = 0; 
            projectile.rotation = projectile.velocity.ToRotation();
        }
    }
}
