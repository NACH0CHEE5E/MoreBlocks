using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0PaintingResearch : BaseResearchable
    {
        public Nach0PaintingResearch()
        {
            key = "Nach0PaintingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintersTable.png";
            iterationCount = 12;
            AddIterationRequirement("Nach0WhitePaint", 5);
            AddIterationRequirement("Nach0BlackPaint", 5);
            AddIterationRequirement("Nach0RedPaint", 5);
            AddIterationRequirement("Nach0BluePaint", 5);
            AddIterationRequirement("Nach0YellowPaint", 5);
            AddIterationRequirement("plasterblock", 15);
            AddDependency("Nach0PaintMakingResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaintersTableCraft-pipliz.crafter", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaintBrushCraft-pipliz.crafter", true, "pipliz.crafter");
        }
    }
}