using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0Currency2Research : BaseResearchable
    {
        public Nach0Currency2Research()
        {
            key = "Nach0Currency2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PlatniumCoins.png";
            iterationCount = 100;
            AddIterationRequirement("Nach0PlatniumOre", 15);
            AddDependency("Nach0ExoticGoods2Research");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PlatniumCoinsCraft-pipliz.minter", true, "pipliz.minter");
        }
    }
}