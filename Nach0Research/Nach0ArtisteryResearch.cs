using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ArtisteryResearch : BaseResearchable
    {
        public Nach0ArtisteryResearch()
        {
            key = "Nach0ArtisteryResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintBrush.png";
            iterationCount = 64;
            AddIterationRequirement("Nach0PaintingScienceBag", 14);
            AddIterationRequirement("sciencebagadvanced", 5);
            AddDependency("Nach0PaintingScienceBagResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0BasicPaintPalletCraft", true, "pipliz.crafter");
        }
    }
}