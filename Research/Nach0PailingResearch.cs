using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0PailingResearch : BaseResearchable
    {
        public Nach0PailingResearch()
        {
            key = "Nach0PailingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Pailer.png";
            iterationCount = 5;
            AddIterationRequirement("Nach0Bucket", 2);
            AddDependency("pipliz.baseresearch.bronzeanvil");
            AddDependency("pipliz.baseresearch.bloomery");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PailerCraft-pipliz.metalsmithjob"));
        }
    }
}