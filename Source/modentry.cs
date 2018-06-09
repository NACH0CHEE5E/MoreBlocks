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
            //We set ModFolder to where the mod is located
            ModFolder = Path.GetDirectoryName(path);

            //Saying we have a folder called gamedata in our mod's folder
            ModGamedata = Path.Combine(Path.GetDirectoryName(path), "gamedata/").Replace("\\", "/");
            Textures = Path.Combine(Path.GetDirectoryName(path), "gamedata/textures").Replace("\\", "/");
            blocktextures = Path.Combine(Path.GetDirectoryName(path), "blocks/").Replace("\\", "/");

            //We set our localization folder.
            //LocalizationFolder = Path.Combine(ModGamedataDirectory, "localization/").Replace("\\", "/");

            //Optional but nice to set up incase you want to output info to a text file
            Utilities.CreateLogs("MoreBlocks");
        }

        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, ModKey + ".AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterStartup")]
  public static void AfterStartup()
          {
      PhentrixGames.NewColonyAPI.Managers.ModManager.RegisterMod("RiseoftheNewColonies", ModFolder);
  }*/

        //This callback might be removed later on
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "nach0.moreblocks.AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterStartup")]
        public static void AfterStartup()
        {
            //This can be used to do things such as version checking, have dependencies in your mod if you so wish.
            PhentrixGames.NewColonyAPI.Managers.ModManager.RegisterMod("MoreBlocks", ModFolder);
        }

        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "nach0.moreblocks.RegisterJobs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            BlockJobManagerTracker.Register<Nach0Jobs.Nach0PailerJob>("Nach0Pailer");
            RecipeStorage.AddBlockToRecipeMapping("Nach0Pailer", "Nach0PailerJob");
        }*/


        /// <summary>
        /// AfterWorldLoad callback entry point. Used for localization routines.
        /// </summary>
        /*[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "phentrixgames.examplemod..Localization")]
        public static void Localization()
        {
            //This is how localization is added using the API
            PhentrixGames.NewColonyAPI.Managers.LocalizationManager.Localize("ExampleMod", LocalizationFolder);
        }*/
    }
}