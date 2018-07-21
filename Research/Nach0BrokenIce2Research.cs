using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0BrokenIce2Research : BaseResearchable
    {
        public Nach0BrokenIce2Research()
        {
            key = "Nach0BrokenIce2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0IceBroken2.png";
            iterationCount = 30;
            AddIterationRequirement("Nach0IceBroken1", 10);
            AddDependency("Nach0BrokenIce1Research");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0IceBroken2Craft-Nach0CrusherJob", true, "Nach0Crusher");
        }
    }
}