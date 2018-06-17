﻿using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0CrushingResearch : BaseResearchable
    {
        public Nach0CrushingResearch()
        {
            key = "Nach0CrushingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Crusher.png";
            iterationCount = 15;
            AddIterationRequirement("stoneblock", 5);
            AddDependency("pipliz.baseresearch.bloomery");
            AddDependency("pipliz.baseresearch.stonemasonworkbench");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0CrusherCraft-pipliz.metalsmithjob", true, "pipliz.metalsmithjob");
        }
    }
}