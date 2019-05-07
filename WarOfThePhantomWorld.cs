using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace WarOfThePhantom
{
    public class WarOfThePhantomWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int[] itemsToPlaceInChests = new int[] { mod.ItemType("Microshark"), ItemID.MusketBall, 100 };
            int itemsToPlaceInChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                // If you look at the sprite for Chests by extracting Tiles_21.xnb, you'll see that the 12th chest is the Ice Chest. Since we are counting from 0, this is where 11 comes from. 36 comes from the width of each tile including padding. 
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 0 * 36)
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {
                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInChests[itemsToPlaceInChestsChoice]);
                            itemsToPlaceInChestsChoice = (itemsToPlaceInChestsChoice + 1) % itemsToPlaceInChests.Length;
                            // Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInChests));
                            break;
                        }
                    }
                }
            }
        }
    }
}