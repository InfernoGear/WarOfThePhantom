using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WarOfThePhantom.Items.Weapons
{
    public class HorrorsEnd : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Horror's End");
            Tooltip.SetDefault("A replica of the Night's Edge, made in a area with only Crimtane materials." +
                "\nCredit to NoHaxJustXMod from Terraria Fan Ideas Wiki for the sprite!");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.crit = 4;
            item.melee = true;
            item.width = 46;
            item.height = 58;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 6.5f;
            item.value = Item.buyPrice(gold: 1, silver: 8);
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BloodButcherer);
            recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddIngredient(ItemID.BladeofGrass);
            recipe.AddIngredient(ItemID.FieryGreatsword);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

            RecipeFinder finder = new RecipeFinder();
            finder.AddIngredient(ItemID.BloodButcherer);
            finder.AddIngredient(ItemID.Muramasa);
            finder.AddIngredient(ItemID.BladeofGrass);
            finder.AddIngredient(ItemID.FieryGreatsword);
            finder.AddTile(TileID.DemonAltar);
            finder.SetResult(ItemID.NightsEdge);
            Recipe recipe2 = finder.FindExactRecipe();
            if (recipe2 != null)
            {
                RecipeEditor editor = new RecipeEditor(recipe2);
                editor.DeleteRecipe();
            }
        }
    }
}
