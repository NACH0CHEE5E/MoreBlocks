using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0WoodWorkingResearch : BaseResearchable
    {
        public Nach0WoodWorkingResearch()
        {
            key = "Nach0WoodWorkingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 5;
            AddIterationRequirement("planks", 20);
            AddIterationRequirement("bronzeaxe", 5);
            AddDependency("pipliz.baseresearch.splittingstump");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
        }
    }
}