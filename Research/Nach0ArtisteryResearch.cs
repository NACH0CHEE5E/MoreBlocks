using Recipes;
using Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0ArtisteryResearch : BaseResearchable
    {
        public Nach0ArtisteryResearch()
        {
            key = "NACH0.research.artistery";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintBrush.png";
            iterationCount = 64;
            AddIterationRequirement("Nach0PaintingScienceBag", 14);
            AddIterationRequirement("sciencebagadvanced", 5);
            AddDependency("Nach0PaintingScienceBagResearch");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
        }
    }
}