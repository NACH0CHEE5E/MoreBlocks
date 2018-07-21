﻿using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0CurrencyResearch : BaseResearchable
    {
        public Nach0CurrencyResearch()
        {
            key = "Nach0CurrencyResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0SilverCoins.png";
            iterationCount = 50;
            AddIterationRequirement("Nach0SilverOre", 10);
            AddDependency("Nach0ExoticGoodsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0SilverCoinsCraft-pipliz.minter", true, "pipliz.minter");
        }
    }
}