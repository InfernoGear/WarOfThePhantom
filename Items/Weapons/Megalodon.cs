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
    public class Megalodon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Megalodon");
            Tooltip.SetDefault("Who's extinct now?" +
                "\nMegashark's older brother." +
                "\n50% chance to not consume ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 36;
            item.ranged = true;
            item.width = 80;
            item.height = 28;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1.5f;
            item.value = Item.buyPrice(gold: 10);
            item.rare = 8;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .50f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Megashark);
            recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddIngredient(ItemID.SharkFin, 5);
        }
    }
}
