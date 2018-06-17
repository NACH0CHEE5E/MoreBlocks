using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0PailingResearch : BaseResearchable
    {
        public Nach0PailingResearch()
        {
            key = "Nach0PailingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Pailer.png";
            iterationCount = 5;
            AddIterationRequirement("Nach0Bucket", 2);
            AddDependency("pipliz.baseresearch.bronzeanvil");
            AddDependency("pipliz.baseresearch.bloomery");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PailerCraft-pipliz.metalsmithjob", true, "pipliz.metalsmithjob");
        }
    }
}