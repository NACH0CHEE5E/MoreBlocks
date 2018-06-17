using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
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

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0MagicTableCraft-Nach0EnchanterJob", true, "Nach0EnchanterJob");
        }
    }
}