using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGoods2Research : BaseResearchable
    {
        public Nach0ExoticGoods2Research()
        {
            key = "Nach0ExoticGoods2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PlatniumOre.png";
            iterationCount = 50;
            AddIterationRequirement("Nach0SilverCoins", 25);
            AddDependency("Nach0CurrencyResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PlatniumOreCraft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0CrystalBlockCraft-pipliz.merchant", true, "pipliz.merchant");
        }
    }
}