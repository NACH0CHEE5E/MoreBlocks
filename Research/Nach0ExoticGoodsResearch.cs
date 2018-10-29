using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGoodsResearch : BaseResearchable
    {
        public Nach0ExoticGoodsResearch()
        {
            key = "Nach0ExoticGoodsResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0SilverOre.png";
            iterationCount = 10;
            AddIterationRequirement("goldcoin", 25);
            AddDependency("pipliz.baseresearch.bronzeminting");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SilverOreCraft-pipliz.merchant"));
        }
    }
}