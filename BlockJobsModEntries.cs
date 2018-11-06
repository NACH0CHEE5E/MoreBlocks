using BlockTypes;
using Pipliz.APIProvider.Jobs;
using System.IO;

namespace Jobs
{
    [ModLoader.ModManager]
    public static class jobentrys
    {
        public static string ModGamedataDirectory;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "nach0.moreblocks.assemblyload")]
        [ModLoader.ModDocumentation("Sets BaseGame gamedata directory")]
        public static void OnAssemblyLoaded(string path)
        {
            ModGamedataDirectory = Path.Combine(Path.GetDirectoryName(path), "gamedata/");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "nach0.moreblocks.registerjobs")]
        [ModLoader.ModDocumentation("Adds all the job block implementations to BlockJobManagerTracker")]
        [ModLoader.ModCallbackDependsOn("create_servermanager_trackers")]
        [ModLoader.ModCallbackProvidesFor("create_savemanager")]
        public static void AfterDefiningNPCTypes()
        {
            /*BlockJobManagerTracker.Register<Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTable");
            BlockJobManagerTracker.Register<Nach0BrickLayerJob>("Nach0BrickLayer");
            BlockJobManagerTracker.Register<Nach0BrickMakerJob>("Nach0BrickMaker");
            BlockJobManagerTracker.Register<Nach0CarverJob>("Nach0CarversTable");
            BlockJobManagerTracker.Register<Nach0ChiselerJob>("Nach0Chiseler");
            BlockJobManagerTracker.Register<Nach0ConcreteLayerJob>("Nach0ConcreteLayer");
            BlockJobManagerTracker.Register<Nach0CrusherJob>("Nach0Crusher");
            BlockJobManagerTracker.Register<Nach0EnchanterJob>("Nach0Enchanter");
            BlockJobManagerTracker.Register<Nach0FreezerJob>("Nach0Freezer");
            BlockJobManagerTracker.Register<Nach0MagicianJob>("Nach0MagicTable");
            BlockJobManagerTracker.Register<Nach0MelterJob>("Nach0Melter");
            BlockJobManagerTracker.Register<Nach0PailerJob>("Nach0Pailer");
            BlockJobManagerTracker.Register<Nach0PainterJob>("Nach0PaintersTable");
            BlockJobManagerTracker.Register<Nach0PaintMixerJob>("Nach0PaintMixer");
            BlockJobManagerTracker.Register<Nach0SanderJob>("Nach0Sander");*/

            /*CreateJob(new CraftingJobSettings("Nach0AdvancedPaintersTable", "Nach0AdvancedPainterJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0BrickLayer", "Nach0BrickLayerJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0BrickMaker", "Nach0BrickMakerJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0CarversTable", "Nach0CarverJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0Chiseler", "Nach0ChiselerJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0ConcreteLayer", "Nach0ConcreteLayerJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0Crusher", "Nach0CrusherJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0Enchanter", "Nach0EnchanterJob", 20f, 1));
            CreateJob(new CraftingJobSettings("Nach0MagicTable", "Nach0MagicianJob", 35f, 1));
            CreateJob(new CraftingJobSettings("Nach0Pailer", "Nach0PailerJob", 2f, 15));
            CreateJob(new CraftingJobSettings("Nach0PaintersTable", "Nach0PainterJob", 5f, 10));
            CreateJob(new CraftingJobSettings("Nach0Sander", "Nach0SanderJob", 5f, 10));
            CreateJob(new CraftingJobRotatedSettings("Nach0Freezer", "Nach0FreezerJob", 5f, 10));
            CreateJob(new CraftingJobRotatedSettings("Nach0PaintMixer", "Nach0PaintMixerJob", 5f, 10));
            CreateJob(new CraftingJobRotatedSettings("Nach0Melter", "Nach0MelterJob", 5f, 10));
            //CreateJob(new CraftingJobSettings("blockassingedto", "name of job", craftingCooldown, maxCraftsPerHaul))*/




            /*void CreateJob(CraftingJobSettings settings)
            {
                ServerManager.BlockEntityCallbacks.RegisterEntityManager(new BlockJobManager<CraftingJobInstance>(settings));
            }*/
        }
    }
}
