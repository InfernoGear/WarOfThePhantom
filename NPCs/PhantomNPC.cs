using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WarOfThePhantom.NPCs
{
    public class PhantomNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.TravellingMerchant)
            {
                if (Main.hardMode == true)
                {
                    if (Main.rand.NextFloat() <= 0.3f)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType<Items.Weapons.Destroyinator>());
                        nextSlot++;
                    }
                }
            }
        }
    }
}