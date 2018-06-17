using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0PaintingScienceBagResearch : BaseResearchable
    {
        public Nach0PaintingScienceBagResearch()
        {
            key = "Nach0PaintingScienceBagResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintingScienceBag.png";
            iterationCount = 50;
            AddIterationRequirement("Nach0WhitePaintBlock", 1);
            AddIterationRequirement("Nach0BlackPaintBlock", 1);
            AddIterationRequirement("Nach0RedPaintBlock", 1);
            AddIterationRequirement("Nach0BluePaintBlock", 1);
            AddIterationRequirement("Nach0YellowPaintBlock", 1);
            AddIterationRequirement("Nach0WhitePaint", 1);
            AddIterationRequirement("Nach0BlackPaint", 1);
            AddIterationRequirement("Nach0RedPaint", 1);
            AddIterationRequirement("Nach0BluePaint", 1);
            AddIterationRequirement("Nach0YellowPaint", 1);
            AddIterationRequirement("Nach0PaintBrush", 5);
            AddDependency("Nach0Painting3Research");
            AddDependency("pipliz.baseresearch.sciencebagadvanced");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaintingScienceBagCraft-pipliz.technologist", true, "pipliz.technologist");
        }
    }
}