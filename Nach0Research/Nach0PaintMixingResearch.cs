using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0PaintMixingResearch : BaseResearchable
    {
        public Nach0PaintMixingResearch()
        {
            key = "Nach0PaintMixingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintMixer.png";
            iterationCount = 15;
            AddIterationRequirement("Nach0WhitePaint", 5);
            AddIterationRequirement("Nach0BlackPaint", 5);
            AddIterationRequirement("Nach0RedPaint", 5);
            AddIterationRequirement("Nach0BluePaint", 5);
            AddIterationRequirement("Nach0YellowPaint", 5);
            AddDependency("Nach0PaintMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0AquaPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkBluePaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreenPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreyPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightBluePaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightGreyPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0OrangePaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PinkPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PurplePaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrownPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkGreenPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkMagentaPaintCraft-Nach0PaintMixerJob", true, "Nach0PaintMixerJob");
        }
    }
}