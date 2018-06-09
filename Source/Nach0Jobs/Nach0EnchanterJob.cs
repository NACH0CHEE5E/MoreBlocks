using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.NPCs;
using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI.Jobs;
using PhentrixGames.NewColonyAPI;
using PhentrixGames;

namespace MoreBlocks.Nach0Jobs
{
    [JobAttribute]
    public class Nach0EnchanterJob : PhentrixGames.NewColonyAPI.Classes.Job, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0EnchanterJob";
        public override float CraftingCooldown { get => Nach0EnchanterJob.StaticCraftingCooldown; set => Nach0EnchanterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 1;

        public override void Init()
        {
            Block = "Nach0Enchanter";
            JobKey = NPCTypeKey;
            PrintName = NPCTypeKey;
        }
    }
}