﻿using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ChiselerResearch : BaseResearchable
    {
        public Nach0ChiselerResearch()
        {
            key = "Nach0ChiselerResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Chiseler.png";
            iterationCount = 15;
            AddIterationRequirement("stoneblock", 20);
            AddIterationRequirement("Nach0Chisel", 5);
            AddDependency("pipliz.baseresearch.stonemasonworkbench");
            AddDependency("Nach0ChiselResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0ChiselerCraft", true, "pipliz.stonemason");
        }
    }
}