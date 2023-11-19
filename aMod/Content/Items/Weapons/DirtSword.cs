using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace aMod.Content.Items.Weapons
{
	public class DirtSword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.aMod.hjson file.
		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Melee;
			Item.width = 64;
			Item.height = 64;
			Item.scale = 0.9F;
			Item.useTime = 25;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.holdStyle = 0;
			Item.knockBack = 2;
			Item.value = 1;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.maxStack = 9999;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}