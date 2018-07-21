using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0RockResearch : BaseResearchable
    {
        public Nach0RockResearch()
        {
            key = "Nach0RockResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Rock.png";
            iterationCount = 250;
            AddIterationRequirement("Nach0Stone1", 15);
            AddIterationRequirement("Nach0Stone2", 15);
            AddIterationRequirement("Nach0Stone3", 15);
            AddIterationRequirement("Nach0Stone4", 15);
            AddDependency("Nach0ExoticStoneResearch");
            AddDependency("Nach0Currency2Research");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0RockCraft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}