using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0SandingResearch : BaseResearchable
    {
        public Nach0SandingResearch()
        {
            key = "Nach0SandingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Sander.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0SandPaper", 5);
            AddDependency("Nach0PaperMakingResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)        
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SanderCraft-pipliz.crafter"));
        }
    }
}