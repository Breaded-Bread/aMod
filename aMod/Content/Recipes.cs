using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace aMod.Content
{
	public static RecipeGroup GoldBarRecipeGroup;

        public override void Unload() {
            GoldBarRecipeGroup = null;
        }
        public override void AddRecipeGroups() {
            
            // Create a recipe group and store it
            // Language.GetTextValue("LegacyMisc.37") is the word "Any" in English, and the corresponding word in other languages
            // While an "IronBar" group exists, "SilverBar" does not. tModLoader will merge recipe groups registered with the same name, so if you are registering a recipe group with a vanilla item as the 1st item, you can register it using just the internal item name if you anticipate other mods wanting to use this recipe group for the same concept. By doing this, multiple mods can add to the same group without extra effort. In this case we are adding a SilverBar group. Don't store the RecipeGroup instance, it might not be used, use the same nameof(ItemID.ItemName) or RecipeGroupID returned from RegisterGroup when using Recipe.AddRecipeGroup instead.
            RecipeGroup GoldBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}",
            ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar), GoldBarRecipeGroup);
        }
	// This class contains thoughtful examples of item recipe creation.
	// Recipes are explained in detail on the https://github.com/tModLoader/tModLoader/wiki/Basic-Recipes and https://github.com/tModLoader/tModLoader/wiki/Intermediate-Recipes wiki pages. Please visit the wiki to learn more about recipes if anything is unclear.
	public class Recipes : ModSystem
	{
        public static RecipeGroup GoldBarRecipeGroup;

        public override void Unload() {
            GoldBarRecipeGroup = null;
        }
        public override void AddRecipeGroups() {
            
            // Create a recipe group and store it
            // Language.GetTextValue("LegacyMisc.37") is the word "Any" in English, and the corresponding word in other languages
            // While an "IronBar" group exists, "SilverBar" does not. tModLoader will merge recipe groups registered with the same name, so if you are registering a recipe group with a vanilla item as the 1st item, you can register it using just the internal item name if you anticipate other mods wanting to use this recipe group for the same concept. By doing this, multiple mods can add to the same group without extra effort. In this case we are adding a SilverBar group. Don't store the RecipeGroup instance, it might not be used, use the same nameof(ItemID.ItemName) or RecipeGroupID returned from RegisterGroup when using Recipe.AddRecipeGroup instead.
            RecipeGroup GoldBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}",
            ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar), GoldBarRecipeGroup);
        }
		public override void AddRecipes() 
        {
			var petPick = ModContent.GetInstance<Items.Tools.PetrifiedWoodPickaxe>();
            var petAxe = ModContent.GetInstance<Items.Tools.PetrifiedWoodAxe>();
            var petHammer = ModContent.GetInstance<Items.Tools.PetrifiedWoodHammer>();
			// Start a new Recipe.
			petPick.CreateRecipe()
				// Adds a Mod Ingredient. Do not attempt ItemID.ExampleSword, it's not how it works.
				.AddIngredient(ModContent.GetInstance<Items.Placeables.petrifiedWood>(),35)
				.AddRecipeGroup(ItemID.GoldBar, 10)

				// Adds a vanilla tile requirement.
				// To specify a crafting station, specify a tile. Look up TileIDs: https://github.com/tModLoader/tModLoader/wiki/Vanilla-Tile-IDs
				.AddTile(TileID.Anvils)

				// When you're done, call this to register the recipe. Note that there's a semicolon at the end of the chain.
				.Register();
            petAxe.CreateRecipe()
				// Adds a Mod Ingredient. Do not attempt ItemID.ExampleSword, it's not how it works.
				.AddIngredient(ModContent.GetInstance<Items.Placeables.petrifiedWood>(),35)
				.AddRecipeGroup(ItemID.GoldBar, 10)

				// Adds a vanilla tile requirement.
				// To specify a crafting station, specify a tile. Look up TileIDs: https://github.com/tModLoader/tModLoader/wiki/Vanilla-Tile-IDs
				.AddTile(TileID.Anvils)

				// When you're done, call this to register the recipe. Note that there's a semicolon at the end of the chain.
				.Register();
            petHammer.CreateRecipe()
				// Adds a Mod Ingredient. Do not attempt ItemID.ExampleSword, it's not how it works.
				.AddIngredient(ModContent.GetInstance<Items.Placeables.petrifiedWood>(),35)
				.AddRecipeGroup(GoldBarRecipeGroup,10)

				// Adds a vanilla tile requirement.
				// To specify a crafting station, specify a tile. Look up TileIDs: https://github.com/tModLoader/tModLoader/wiki/Vanilla-Tile-IDs
				.AddTile(TileID.Anvils)

				// When you're done, call this to register the recipe. Note that there's a semicolon at the end of the chain.
				.Register();
        }
	}
}
