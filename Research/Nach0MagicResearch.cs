using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0MagicResearch : BaseResearchable
    {
        public Nach0MagicResearch()
        {
            key = "Nach0MagicResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0MagicTable.png";
            iterationCount = 100;
            AddIterationRequirement("Nach0EnchantedStone", 25);
            AddDependency("Nach0SpellsResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0MagicTableCraft-Nach0EnchanterJob"));
        }
    }
}