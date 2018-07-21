using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0BrokenIce3Research : BaseResearchable
    {
        public Nach0BrokenIce3Research()
        {
            key = "Nach0BrokenIce3Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0IceBroken3.png";
            iterationCount = 60;
            AddIterationRequirement("Nach0IceBroken2", 20);
            AddDependency("Nach0BrokenIce2Research");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0IceBroken3Craft-Nach0CrusherJob", true, "Nach0Crusher");
        }
    }
}