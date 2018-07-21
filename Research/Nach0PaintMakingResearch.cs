using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace MoreBlocks.Research
{
    [AutoLoadedResearchable]
    public class Nach0PaintMakingResearch : BaseResearchable
    {
        public Nach0PaintMakingResearch()
        {
            key = "Nach0PaintMakingResearch";
            icon = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/icons/Nach0PaintMixer.png";
            iterationCount = 12;
            AddIterationRequirement("Nach0WaterBucket", 1);
            AddIterationRequirement("flour", 5);
            AddIterationRequirement("hollyhock", 5);
            AddIterationRequirement("alkanet", 5);
            AddIterationRequirement("wolfsbane", 5);
            AddDependency("Nach0PailingResearch");
            AddDependency("pipliz.baseresearch.herbfarming");
            AddDependency("pipliz.baseresearch.wheatfarming");
            AddDependency("pipliz.baseresearch.dyertable");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("Nach0PaintMixerCraft-pipliz.metalsmithjob", true, "pipliz.metalsmithjob");
        }
    }
}