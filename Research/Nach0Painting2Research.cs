using Recipes;
using Science;


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

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        { 
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0AquaPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0DarkBluePaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0GreenPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0GreyPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0LightBluePaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0LightGreyPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0OrangePaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PinkPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PurplePaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0DarkGreenPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0BrownPaintBlockCraft-Nach0PainterJob"));
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0MagentaPaintBlockCraft-Nach0PainterJob"));
        }
    }
}