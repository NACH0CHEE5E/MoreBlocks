using System;
using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI.Jobs;
using BlockTypes.Builtin;
using Server.NPCs;
using System.Collections.Generic;
using PhentrixGames.NewColonyAPI;
using PhentrixGames.NewColonyAPI.Managers;

namespace MoreBlocks
{
    [ModLoader.ModManager]
    public static class MoreBlocks
    {
        public static string ModFolder = "gamedata/mods/NACH0/MoreBlocks/";
        public static string ModGamedata = "gamedata/mods/NACH0/MoreBlocks/gamedata/";
        public static string Textures = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures";
        public static string blocktextures = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures/blocks/";
        public static string ModKey = "NACH0.MoreBlocks";
        public static Version APIVersion = new Version(1, 2, 0);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "NACH0.MoreBlocks.assemblyload")]
        public static void OnAssemblyLoaded(string path)
        {
            ModFolder = Path.GetDirectoryName(path);

            ModGamedata = Path.Combine(Path.GetDirectoryName(path), "gamedata/").Replace("\\", "/");
            Textures = Path.Combine(Path.GetDirectoryName(path), "gamedata/textures").Replace("\\", "/");
            blocktextures = Path.Combine(Path.GetDirectoryName(path), "blocks/").Replace("\\", "/");

            //LocalizationFolder = Path.Combine(ModGamedataDirectory, "localization/").Replace("\\", "/");

            Utilities.CreateLogs("MoreBlocks");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, "NACH0.MoreBlocks.AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterModsLoaded")]
        public static void AfterStartup(List<ModLoader.ModDescription> a)
        {
            ModManager.RegisterMod("MoreBlocks", ModFolder);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "NACH0.MoreBlocks.RegisterJobs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            JobManager.RegisterJob<Nach0Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTable", "Nach0AdvancedPainterJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0BrickLayerJob>("Nach0BrickLayer", "Nach0BrickLayerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0BrickMakerJob>("Nach0BrickMaker", "Nach0BrickMakerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0CarverJob>("Nach0CarversTable", "Nach0CarverJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0ChiselerJob>("Nach0Chiseler", "Nach0ChiselerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0ConcreteLayerJob>("Nach0ConcreteLayer", "Nach0ConcreteLayerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0CrusherJob>("Nach0Crusher", "Nach0CrusherJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0EnchanterJob>("Nach0Enchanter", "Nach0EnchanterJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0FreezerJob>("Nach0Freezer", "Nach0FreezerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0MagicianJob>("Nach0MagicTable", "Nach0MagicicianJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0MelterJob>("Nach0Melter", "Nach0MelterJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0PailerJob>("Nach0Pailer", "Nach0PailerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0PainterJob>("Nach0PaintersTable", "Nach0PainterJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0PaintMixerJob>("Nach0PaintMixer", "Nach0PaintMixerJob");
            JobManager.RegisterJob<Nach0Jobs.Nach0SanderJob>("Nach0Sander", "Nach0SanderJob");
        }

        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "phentrixgames.examplemod..Localization")]
        public static void Localization()
        {
            //This is how localization is added using the API
            LocalizationManager.Localize("ExampleMod", LocalizationFolder);
        }*/
    }
}