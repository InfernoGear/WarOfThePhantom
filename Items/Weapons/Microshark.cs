using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WarOfThePhantom.Items.Weapons
{
    public class Microshark : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Microshark");
            Tooltip.SetDefault("Two round burst.\nOnly the first shot consumes ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.crit = 4;
            item.width = 38;
            item.height = 16;
            item.useTime = 4;
            item.useAnimation = 8;
            item.reuseDelay = 10;
            item.knockBack = 0;
            item.useStyle = 5;
            item.noMelee = true;
            item.value = Item.buyPrice(gold: 1);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool ConsumeAmmo(Player player)
        {
            // Because of how the game works, player.itemAnimation will be 7 and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
            // We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
            return !(player.itemAnimation < item.useAnimation - 1);
        }
    }
}
