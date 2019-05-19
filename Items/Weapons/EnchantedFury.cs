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
    public class EnchantedFury : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Fury");
            Tooltip.SetDefault("Fires sword beams from the sky." +
                "\nHas lower damage compared to Starfury and Enchanted Sword because of the fact that it would destroy the Destroyer otherwise." +
                "\nI tested that by the way. On Expert Destroyer. " +
                "\nIt had lost 80,000 HP in 2 minutes. 40,000 per minute." +
                "\nNice Pre-Hardmode weapon, overall.");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.crit = 4;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 52;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.knockBack = 5.5f;
            item.value = Item.buyPrice(gold: 1, silver: 5);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shootSpeed = 9.5f;
            item.shoot = mod.ProjectileType("EnchantedFuryBeam");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 3; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;
        }
    }
}