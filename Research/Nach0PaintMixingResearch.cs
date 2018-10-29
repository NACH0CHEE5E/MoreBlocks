using Recipes;
using Science;


namespace MoreBlocks.Research
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

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0AquaPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0DarkBluePaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0GreenPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0GreyPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0LightBluePaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0LightGreyPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0OrangePaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PinkPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PurplePaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0BrownPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0DarkGreenPaintCraft-Nach0PaintMixerJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0MagentaPaintCraft-Nach0PaintMixerJob"));
        }
    }
}