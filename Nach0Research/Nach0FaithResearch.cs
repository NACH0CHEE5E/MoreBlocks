using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0FaithResearch : BaseResearchable
    {
        public Nach0FaithResearch()
        {
            key = "Nach0FaithResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Cross.png";
            iterationCount = 1000;
            AddIterationRequirement("Nach0Cross");
            AddDependency("pipliz.baseresearch.sciencebagadvanced");
            AddDependency("pipliz.baseresearch.sciencebagcolony");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0CrossCraft", true, "pipliz.crafter");
        }
    }
}