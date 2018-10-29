using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0Painting3Research : BaseResearchable
    {
        public Nach0Painting3Research()
        {
            key = "Nach0Painting3Research";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0AdvancedPaintersTable.png";
            iterationCount = 45;
            AddIterationRequirement("Nach0WhitePaintBlock", 5);
            AddIterationRequirement("Nach0BlackPaintBlock", 5);
            AddIterationRequirement("Nach0RedPaintBlock", 5);
            AddIterationRequirement("Nach0BluePaintBlock", 5);
            AddIterationRequirement("Nach0YellowPaintBlock", 5);
            AddIterationRequirement("Nach0AquaPaintBlock", 5);
            AddIterationRequirement("Nach0DarkGreenPaintBlock", 5);
            AddIterationRequirement("Nach0GreenPaintBlock", 5);
            AddIterationRequirement("Nach0GreyPaintBlock", 5);
            AddIterationRequirement("Nach0LightBluePaintBlock", 5);
            AddIterationRequirement("Nach0LightGreyPaintBlock", 5);
            AddIterationRequirement("Nach0OrangePaintBlock", 5);
            AddIterationRequirement("Nach0PinkPaintBlock", 5);
            AddIterationRequirement("Nach0PurplePaintBlock", 5);
            AddDependency("Nach0Painting2Research");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0AdvancedPaintersTableCraft-pipliz.crafter"));
        }
    }
}