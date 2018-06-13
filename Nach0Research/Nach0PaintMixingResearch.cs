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
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0AquaPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkBluePaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreenPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0GreyPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightBluePaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0LightGreyPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0OrangePaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PinkPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PurplePaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BrownPaintCraft", true, "Nach0PaintMixerJob");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0DarkGreenPaintCraft", true, "Nach0PaintMixerJob");
        }
    }
}