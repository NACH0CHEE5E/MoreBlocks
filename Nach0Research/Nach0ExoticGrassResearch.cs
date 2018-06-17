﻿using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Nach0Research
{
    [AutoLoadedResearchable]
    public class Nach0ExoticGrassResearch : BaseResearchable
    {
        public Nach0ExoticGrassResearch()
        {
            key = "Nach0ExoticGrassResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0Grass1Sided.png";
            iterationCount = 15;
            AddIterationRequirement("grasstemperate", 1);
            AddIterationRequirement("grasstaiga", 1);
            AddIterationRequirement("grasstundra", 1);
            AddIterationRequirement("grasssavanna", 1);
            AddIterationRequirement("grassrainforest", 1);
            AddDependency("Nach0ExoticDirtResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            /*//dirt
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt1Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt2Craft", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Dirt3Craft", true, "pipliz.merchant");
            */
            //stone
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone1Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone2Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone3Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Stone4Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0RockCraft", true, "pipliz.merchant");

            //sand
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand1Craft", true, "pipliz.merchant");
            //RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Sand2Craft", true, "pipliz.merchant");

            //grass
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1Craft-pipliz.merchant", true, "pipliz.merchant");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0Grass1SidedCraft-pipliz.merchant", true, "pipliz.merchant");
            
        }
    }
}