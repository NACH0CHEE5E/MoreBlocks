using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ConcreteSmoothingResearch : BaseResearchable
    {
        public Nach0ConcreteSmoothingResearch()
        {
            key = "Nach0ConcreteSmoothingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Missing.png";
            iterationCount = 15;
            AddIterationRequirement("stoneblock", 5);
            AddDependency("Nach0ConcreteMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
        }
    }
}