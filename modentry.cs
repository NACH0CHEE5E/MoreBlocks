using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using System.Collections.Generic;
using PhentrixGames.NewColonyAPI.Managers;

namespace MoreBlocks
{
    [ModLoader.ModManager]
    public static class MoreBlocks
    {
        public static string ModFolder = "gamedata/mods/NACH0/MoreBlocks/";
        public static string ModGamedata = "gamedata/mods/NACH0/MoreBlocks/gamedata/";
        public static string LocaleFolder = "gamedata/mods/NACH0/MoreBlocks/gamedata/locale/";
        public static string ModKey = "NACH0.MoreBlocks";

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "NACH0.MoreBlocks.assemblyload")]
        public static void OnAssemblyLoaded(string path)
        {
            ModFolder = Path.GetDirectoryName(path);
    
            ModGamedata = Path.Combine(Path.GetDirectoryName(path), "gamedata/").Replace("\\", "/");

            LocaleFolder = Path.Combine(Path.GetDirectoryName(path), "gamedata/locale/").Replace("\\", "/");

            Utilities.CreateLogs("MoreBlocks");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, "NACH0.MoreBlocks.AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterModsLoaded")]
        public static void AfterStartup(List<ModLoader.ModDescription> a)
        {
            ModManager.RegisterMod("MoreBlocks", ModFolder);
            LocalizationManager.Localize("MoreBlocks", LocaleFolder);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "NACH0.MoreBlocks.RegisterJobs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            JobManager.RegisterJob<Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTable", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTableX-", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTableX+", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTableZ-", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTableZ+", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Jobs.Nach0BrickLayerJob>("Nach0BrickLayer", "Nach0BrickLayerJob");
            JobManager.RegisterJob<Jobs.Nach0BrickMakerJob>("Nach0BrickMaker", "Nach0BrickMakerJob");
            JobManager.RegisterJob<Jobs.Nach0CarverJob>("Nach0CarversTable", "Nach0CarverJob");
            JobManager.RegisterJob<Jobs.Nach0CarverJob>("Nach0CarversTableX-", "Nach0CarverJob");
            JobManager.RegisterJob<Jobs.Nach0CarverJob>("Nach0CarversTableX+", "Nach0CarverJob");
            JobManager.RegisterJob<Jobs.Nach0CarverJob>("Nach0CarversTableZ-", "Nach0CarverJob");
            JobManager.RegisterJob<Jobs.Nach0CarverJob>("Nach0CarversTableZ+", "Nach0CarverJob");
            JobManager.RegisterJob<Jobs.Nach0ChiselerJob>("Nach0Chiseler", "Nach0ChiselerJob");
            JobManager.RegisterJob<Jobs.Nach0ChiselerJob>("Nach0ChiselerX-", "Nach0ChiselerJob");
            JobManager.RegisterJob<Jobs.Nach0ChiselerJob>("Nach0ChiselerX+", "Nach0ChiselerJob");
            JobManager.RegisterJob<Jobs.Nach0ChiselerJob>("Nach0ChiselerZ-", "Nach0ChiselerJob");
            JobManager.RegisterJob<Jobs.Nach0ChiselerJob>("Nach0ChiselerZ+", "Nach0ChiselerJob");
            JobManager.RegisterJob<Jobs.Nach0ConcreteLayerJob>("Nach0ConcreteLayer", "Nach0ConcreteLayerJob");
            JobManager.RegisterJob<Jobs.Nach0CrusherJob>("Nach0Crusher", "Nach0CrusherJob");
            JobManager.RegisterJob<Jobs.Nach0EnchanterJob>("Nach0Enchanter", "Nach0EnchanterJob");
            JobManager.RegisterJob<Jobs.Nach0FreezerJob>("Nach0Freezer", "Nach0FreezerJob");
            JobManager.RegisterJob<Jobs.Nach0FreezerJob>("Nach0FreezerX-", "Nach0FreezerJob");
            JobManager.RegisterJob<Jobs.Nach0FreezerJob>("Nach0FreezerX+", "Nach0FreezerJob");
            JobManager.RegisterJob<Jobs.Nach0FreezerJob>("Nach0FreezerZ-", "Nach0FreezerJob");
            JobManager.RegisterJob<Jobs.Nach0FreezerJob>("Nach0FreezerZ+", "Nach0FreezerJob");
            JobManager.RegisterJob<Jobs.Nach0MagicianJob>("Nach0MagicTable", "Nach0MagicianJob");
            JobManager.RegisterJob<Jobs.Nach0MagicianJob>("Nach0MagicTableX-", "Nach0MagicianJob");
            JobManager.RegisterJob<Jobs.Nach0MagicianJob>("Nach0MagicTableX+", "Nach0MagicianJob");
            JobManager.RegisterJob<Jobs.Nach0MagicianJob>("Nach0MagicTableZ-", "Nach0MagicianJob");
            JobManager.RegisterJob<Jobs.Nach0MagicianJob>("Nach0MagicTableZ+", "Nach0MagicianJob");
            JobManager.RegisterJob<Jobs.Nach0MelterJob>("Nach0Melter", "Nach0MelterJob");
            JobManager.RegisterJob<Jobs.Nach0MelterJob>("Nach0MelterX-", "Nach0MelterJob");
            JobManager.RegisterJob<Jobs.Nach0MelterJob>("Nach0MelterX+", "Nach0MelterJob");
            JobManager.RegisterJob<Jobs.Nach0MelterJob>("Nach0MelterZ-", "Nach0MelterJob");
            JobManager.RegisterJob<Jobs.Nach0MelterJob>("Nach0MelterZ+", "Nach0MelterJob");
            JobManager.RegisterJob<Jobs.Nach0PailerJob>("Nach0Pailer", "Nach0PailerJob");
            JobManager.RegisterJob<Jobs.Nach0PainterJob>("Nach0PaintersTable", "Nach0PainterJob");
            JobManager.RegisterJob<Jobs.Nach0PainterJob>("Nach0PaintersTableX-", "Nach0PainterJob");
            JobManager.RegisterJob<Jobs.Nach0PainterJob>("Nach0PaintersTableX+", "Nach0PainterJob");
            JobManager.RegisterJob<Jobs.Nach0PainterJob>("Nach0PaintersTableZ-", "Nach0PainterJob");
            JobManager.RegisterJob<Jobs.Nach0PainterJob>("Nach0PaintersTableZ+", "Nach0PainterJob");
            JobManager.RegisterJob<Jobs.Nach0PaintMixerJob>("Nach0PaintMixer", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Jobs.Nach0PaintMixerJob>("Nach0PaintMixerX-", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Jobs.Nach0PaintMixerJob>("Nach0PaintMixerX+", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Jobs.Nach0PaintMixerJob>("Nach0PaintMixerZ-", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Jobs.Nach0PaintMixerJob>("Nach0PaintMixerZ+", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Jobs.Nach0SanderJob>("Nach0Sander", "Nach0SanderJob");
            JobManager.RegisterJob<Jobs.Nach0SanderJob>("Nach0SanderX", "Nach0SanderJob");
            JobManager.RegisterJob<Jobs.Nach0SanderJob>("Nach0SanderZ", "Nach0SanderJob");
        }
    }
}