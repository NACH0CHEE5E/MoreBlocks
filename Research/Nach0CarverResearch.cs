using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0CarverResearch : BaseResearchable
    {
        public Nach0CarverResearch()
        {
            key = "Nach0CarverResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0CarversTable.png";
            iterationCount = 15;
            AddIterationRequirement("planks", 20);
            AddIterationRequirement("Nach0Chisel", 5);
            AddDependency("Nach0CarpenterResearch");
            AddDependency("Nach0ChiselResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0CarversTableCraft-pipliz.crafter", true, "pipliz.crafter");
        }
    }
}