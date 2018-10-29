using Recipes;
using Science;


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

		public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.RecipeData.UnlockRecipe(new RecipeKey("Nach0PaintMixerCraft-pipliz.metalsmithjob"));
        }
    }
}