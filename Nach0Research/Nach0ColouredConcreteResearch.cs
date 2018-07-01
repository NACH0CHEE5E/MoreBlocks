using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ColouredConcreteResearch : BaseResearchable
    {
        public Nach0ColouredConcreteResearch()
        {
            key = "Nach0ColouredConcreteResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0ColouredConcreteResearch.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0Concrete", 5);
            AddDependency("Nach0ConcreteMakingResearch");
            AddDependency("Nach0PaintMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0AquaConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BlackConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BlueConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrownConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkGreenConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreenConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightBlueConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0OrangeConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PinkConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PurpleConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreyConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0RedConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0YellowConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0WhiteConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0MagentaConcreteCraft-Nach0ConcreteLayerJob", true, "Nach0ConcreteLayerJob");
        }
    }
}