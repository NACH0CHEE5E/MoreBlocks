using System;
using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using Pipliz.Mods.APIProvider.Jobs;

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

        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "phentrixgames.examplemod..Localization")]
        public static void Localization()
        {
            //This is how localization is added using the API
            PhentrixGames.NewColonyAPI.Managers.LocalizationManager.Localize("ExampleMod", LocalizationFolder);
        }*/
    }
}