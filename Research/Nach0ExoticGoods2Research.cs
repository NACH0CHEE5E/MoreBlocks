using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGoods2Research : BaseResearchable
    {
        public Nach0ExoticGoods2Research()
        {
            key = "Nach0ExoticGoods2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PlatniumOre.png";
            iterationCount = 50;
            AddIterationRequirement("Nach0SilverCoins", 25);
            AddDependency("Nach0CurrencyResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PlatniumOreCraft-pipliz.merchant"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0CrystalBlockCraft-pipliz.merchant"));
        }
    }
}