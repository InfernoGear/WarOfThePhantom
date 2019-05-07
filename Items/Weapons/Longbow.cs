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
    public class Longbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Longbow");
            Tooltip.SetDefault("Fires with great power!");
        }

        public override void SetDefaults()
        {
            item.damage = 21;
            item.ranged = true;
            item.width = 18;
            item.height = 76;
            item.useTime = 34;
            item.useAnimation = 34;
            item.knockBack = 5;
            item.crit = 7;
            item.useStyle = 5;
            item.noMelee = true;
            item.value = Item.buyPrice(silver: 25);
            item.rare = 2;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shoot = 10; // No current idea as to use.
            item.shootSpeed = 9f;
            item.useAmmo = ItemID.WoodenArrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBow);
            recipe.AddIngredient(ItemID.DemoniteBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBow);
            recipe.AddIngredient(ItemID.DemoniteBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBow);
            recipe.AddIngredient(ItemID.CrimtaneBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBow);
            recipe.AddIngredient(ItemID.CrimtaneBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
