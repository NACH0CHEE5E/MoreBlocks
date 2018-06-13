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
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0Concrete", 5);
            AddDependency("Nach0ConcreteMakingResearch");
            AddDependency("Nach0PaintMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0AquaConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BlackConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BlueConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrownConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkGreenConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreenConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightBlueConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0OrangeConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PinkConcreteCraft", true, "Nach0ConcreteLayerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PurpleConcreteCraft", true, "Nach0ConcreteLayerJob");
        }
    }
}