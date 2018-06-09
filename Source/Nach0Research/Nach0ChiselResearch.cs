using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
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

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0ChiselCraft", true, "pipliz.metalsmithjob");
        }
    }
}