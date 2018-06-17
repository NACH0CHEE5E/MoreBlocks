using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0RockResearch : BaseResearchable
    {
        public Nach0RockResearch()
        {
            key = "Nach0RockResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Rock.png";
            iterationCount = 25;
            AddIterationRequirement("Nach0Stone1", 5);
            AddIterationRequirement("Nach0Stone2", 5);
            AddIterationRequirement("Nach0Stone3", 5);
            AddIterationRequirement("Nach0Stone4", 5);
            AddDependency("Nach0ExoticStoneResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            /*//dirt
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt3Craft", true, "pipliz.merchant");
            */
            //stone
            /*RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone3Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone4Craft", true, "pipliz.merchant");*/
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0RockCraft-pipliz.merchant", true, "pipliz.merchant");

            //sand
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand1Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand2Craft", true, "pipliz.merchant");

            /*//grass
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1SidedCraft", true, "pipliz.merchant");
            */
        }
    }
}