﻿using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0SpellsResearch : BaseResearchable
    {
        public Nach0SpellsResearch()
        {
            key = "Nach0SpellsResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Enchanter.png";
            iterationCount = 250;
            AddIterationRequirement("goldore", 150);
            AddIterationRequirement("Nach0SilverOre", 50);
            AddIterationRequirement("Nach0PlatniumOre");
            AddDependency("Nach0FaithResearch");
            AddDependency("Nach0RockResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0EnchanterCraft-pipliz.stonemason", true, "pipliz.stonemason");
        }
    }
}