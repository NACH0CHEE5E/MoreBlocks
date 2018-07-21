using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0PaperMakingResearch : BaseResearchable
    {
        public Nach0PaperMakingResearch()
        {
            key = "Nach0PaperMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Paper.png";
            iterationCount = 15;
            AddIterationRequirement("flax", 5);
            AddDependency("pipliz.baseresearch.herbfarming");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaperCraft-pipliz.crafter", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SandPaperCraft-pipliz.crafter", true, "pipliz.crafter");
        }
    }
}