using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticPlantsResearch : BaseResearchable
    {
        public Nach0ExoticPlantsResearch()
        {
            key = "Nach0ExoticPlantsResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Cactus.png";
            iterationCount = 15;
            AddIterationRequirement("cherrysapling", 5);
            AddDependency("Nach0ExoticSandResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0CactusCraft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}