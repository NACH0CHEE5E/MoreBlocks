using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ConcreteSmoothing2Research : BaseResearchable
    {
        public Nach0ConcreteSmoothing2Research()
        {
            key = "Nach0ConcreteSmoothing2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ConcreteSmoothing2Research.png";
            iterationCount = 25;
            AddIterationRequirement("Nach0SmoothedConcrete", 5);
            AddDependency("Nach0ConcreteSmoothingResearch");
            AddDependency("Nach0ColouredConcreteResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)        {
            /*RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedAquaConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBlackConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBlueConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedBrownConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedDarkGreenConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedGreenConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedLightBlueConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedLightGreyConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedOrangeConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedPinkConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedPurpleConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedRedConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedWhiteConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedYellowConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SmoothedMagentaConcreteCraft-Nach0SanderJob", true, "Nach0SanderJob");*/

            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedAquaConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedBlackConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedBlueConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedBrownConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedDarkGreenConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedGreenConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedLightBlueConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedLightGreyConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedOrangeConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedPinkConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedPurpleConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedRedConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedWhiteConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedYellowConcreteCraft-Nach0SanderJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0SmoothedMagentaConcreteCraft-Nach0SanderJob"));
        }
    }
}