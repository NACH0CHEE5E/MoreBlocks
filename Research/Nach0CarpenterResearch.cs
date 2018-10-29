using Recipes;
using Science;


namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0CarpenterResearch : BaseResearchable
    {
        public Nach0CarpenterResearch()
        {
            key = "Nach0CarpenterResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 15;
            AddIterationRequirement("planks", 20);
            AddIterationRequirement("bronzeaxe", 5);
            AddDependency("Nach0WoodWorkingResearch");
        }

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
        }
    }
}