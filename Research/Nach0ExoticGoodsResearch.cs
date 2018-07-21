using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGoodsResearch : BaseResearchable
    {
        public Nach0ExoticGoodsResearch()
        {
            key = "Nach0ExoticGoodsResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0SilverOre.png";
            iterationCount = 10;
            AddIterationRequirement("goldcoin", 25);
            AddDependency("pipliz.baseresearch.bronzeminting");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SilverOreCraft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}