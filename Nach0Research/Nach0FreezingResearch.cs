using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0FreezingResearch : BaseResearchable
    {
        public Nach0FreezingResearch()
        {
            key = "Nach0FreezingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Freezer.png";
            iterationCount = 10;
            AddIterationRequirement("sciencebagbasic");
            AddDependency("pipliz.baseresearch.sciencebagbasic");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0FreezerCraft-pipliz.metalsmithjob", true, "pipliz.metalsmithjob");
        }
    }
}