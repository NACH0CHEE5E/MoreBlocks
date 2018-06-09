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
    public class Nach0CarverJob : PhentrixGames.NewColonyAPI.Classes.Job, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0CarverJob";
        public override float CraftingCooldown { get => Nach0CarverJob.StaticCraftingCooldown; set => Nach0CarverJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;
         
        public override void Init()
        {
            Block = "Nach0CarversTable";
            JobKey = NPCTypeKey;
            PrintName = NPCTypeKey;
        }
    }
}