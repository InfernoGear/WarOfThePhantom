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
            Tooltip.SetDefault("Minishark's little brother.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.crit = 4;
            item.width = 38;
            item.height = 16;
            item.useTime = 12;
            item.useAnimation = 12;
            item.knockBack = 0;
            item.useStyle = 5;
            item.noMelee = true;
            item.value = Item.buyPrice(silver: 25);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ItemID.SharkFin);
            recipe.AddIngredient(ItemID.DemoniteBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Minishark);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ItemID.SharkFin);
            recipe.AddIngredient(ItemID.CrimtaneBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Minishark);
            recipe.AddRecipe();
        }
    }
}
