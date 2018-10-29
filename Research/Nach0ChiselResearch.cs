using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ChiselResearch : BaseResearchable
    {
        public Nach0ChiselResearch()
        {
            key = "Nach0ChiselResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Chisel.png";
            iterationCount = 5;
            AddIterationRequirement("ironingot", 2);
            AddDependency("pipliz.baseresearch.bronzeanvil");
            AddDependency("pipliz.baseresearch.bloomery");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0ChiselCraft-pipliz.metalsmithjob"));
        }
    }
}