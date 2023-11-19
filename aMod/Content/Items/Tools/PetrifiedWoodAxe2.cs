using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace aMod.Content.Items.Tools
{
	public class PetrifiedWoodAxe2 : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.aMod.hjson file.
		public override void SetDefaults()
		{
			Item.damage = 15;
			Item.DamageType = DamageClass.Melee;
			Item.width = 32;
			Item.height = 32;
			Item.scale = 1;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.holdStyle = 0;
			Item.knockBack = 10;
			Item.value = 1000;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.useTurn = true;

            Item.axe = 15;
		}
	}
}