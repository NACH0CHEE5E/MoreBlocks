using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0Painting2Research : BaseResearchable
    {
        public Nach0Painting2Research()
        {
            key = "Nach0Painting2Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintersTable.png";
            iterationCount = 24;
            AddIterationRequirement("Nach0WhitePaintBlock", 5);
            AddIterationRequirement("Nach0BlackPaintBlock", 5);
            AddIterationRequirement("Nach0RedPaintBlock", 5);
            AddIterationRequirement("Nach0BluePaintBlock", 5);
            AddIterationRequirement("Nach0YellowPaintBlock", 5);
            AddDependency("Nach0PaintingResearch");
            AddDependency("Nach0PaintMixingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        { 
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0AquaPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkBluePaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreenPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreyPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightBluePaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightGreyPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0OrangePaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PinkPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PurplePaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkGreenPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrownPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0MagentaPaintBlockCraft-Nach0PainterJob", true, "Nach0PainterJob");
        }
    }
}