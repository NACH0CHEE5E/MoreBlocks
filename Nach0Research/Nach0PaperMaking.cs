using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0PaperMaking : BaseResearchable
    {
        public Nach0PaperMaking()
        {
            key = "Nach0PaperMaking";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Paper.png";
            iterationCount = 15;
            AddIterationRequirement("flax", 5);
            AddDependency("pipliz.baseresearch.herbfarming");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            /*RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedAquaConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBlackConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBlueConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBrownConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedDarkGreenConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedGreenConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedLightBlueConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedLightGreyConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedOrangeConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedPinkConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedPurpleConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedRedConcreteCraft", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedWhiteConcreteCraft", true, "pipliz.crafter");*/
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaperCraft-pipliz.crafter", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SandPaperCraft-pipliz.crafter", true, "pipliz.crafter");
        }
    }
}