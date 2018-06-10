using System;
using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI.Jobs;
using BlockTypes.Builtin;
using Server.NPCs;
using System.Collections.Generic;
using PhentrixGames.NewColonyAPI;

namespace MoreBlocks
{
    [ModLoader.ModManager]
    public static class MoreBlocks
    {
        public static string ModFolder = "gamedata/mods/NACH0/MoreBlocks/";
        public static string ModGamedata = "gamedata/mods/NACH0/MoreBlocks/gamedata/";
        public static string Textures = "gamedata/mods/NACH0/MoreBlocks/gamedata/textures";
        public static string blocktextures = "gamedata/mods/MoreBlocks/gamedata/textures/blocks/";
        public static Version APIVersion = new Version(0, 1, 10);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "nach0.moreblocks.assemblyload")]
        public static void OnAssemblyLoaded(string path)
        {
            ModFolder = Path.GetDirectoryName(path);

            ModGamedata = Path.Combine(Path.GetDirectoryName(path), "gamedata/").Replace("\\", "/");
            Textures = Path.Combine(Path.GetDirectoryName(path), "gamedata/textures").Replace("\\", "/");
            blocktextures = Path.Combine(Path.GetDirectoryName(path), "blocks/").Replace("\\", "/");

            //LocalizationFolder = Path.Combine(ModGamedataDirectory, "localization/").Replace("\\", "/");

            Utilities.CreateLogs("MoreBlocks");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "nach0.moreblocks.AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterStartup")]
        public static void AfterStartup()
        {
            PhentrixGames.NewColonyAPI.Managers.ModManager.RegisterMod("MoreBlocks", ModFolder);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "nach0.moreblocks.RegisterJobs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0AdvancedPainterJob>("Nach0AdvancedPaintersTable", "Nach0AdvancedPainterJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0BrickLayerJob>("Nach0BrickLayer", "Nach0BrickLayerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0BrickMakerJob>("Nach0BrickMaker", "Nach0BrickMakerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0CarverJob>("Nach0CarversTable", "Nach0CarverJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0ChiselerJob>("Nach0Chiseler", "Nach0ChiselerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0ConcreteLayerJob>("Nach0ConcreteLayer", "Nach0ConcreteLayerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0CrusherJob>("Nach0Crusher", "Nach0CrusherJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0EnchanterJob>("Nach0Enchanter", "Nach0EnchanterJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0FreezerJob>("Nach0Freezer", "Nach0FreezerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0MagicianJob>("Nach0MagicTable", "Nach0MagicicianJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0MelterJob>("Nach0Melter", "Nach0MelterJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0PailerJob>("Nach0Pailer", "Nach0PailerJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0PainterJob>("Nach0PaintersTable", "Nach0PainterJob");
            PhentrixGames.NewColonyAPI.Managers.JobManager.RegisterJob<Nach0Jobs.Nach0PaintMixerJob>("Nach0PaintMixer", "Nach0PaintMixerJob");
        }

        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "phentrixgames.examplemod..Localization")]
        public static void Localization()
        {
            //This is how localization is added using the API
            PhentrixGames.NewColonyAPI.Managers.LocalizationManager.Localize("ExampleMod", LocalizationFolder);
        }*/
    }
}