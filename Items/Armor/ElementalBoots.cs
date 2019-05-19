using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WarOfThePhantom.Items.Armor
{
    [AutoloadEquip(EquipType.Shoes)]
    public class ElementalBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Elemental Boots");
            Tooltip.SetDefault("Player can run insanely fast." +
                "\n+15% movement speed." +
                "\nAllows for rocket-powered flight." +
                "\nIncreased mobility on ice." +
                "\nIce won't break when you fall on it." +
                "\nCan walk on water and lava." +
                "\n7 seconds immunity to lava." +
                "\nImmunity to 'On Fire!'");
        }
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 32;
            item.value = Item.buyPrice(gold: 10);
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.accRunSpeed = 10f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.15f;
            player.iceSkate = true;
            player.waterWalk = true;
            player.lavaMax = 420;
            player.buffImmune[BuffID.OnFire] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
