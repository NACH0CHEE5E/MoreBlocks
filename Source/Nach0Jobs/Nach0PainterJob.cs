﻿using System;
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
    public class Nach0PainterJob : PhentrixGames.NewColonyAPI.Classes.Job, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0PainterJob";
        public override float CraftingCooldown { get => Nach0PainterJob.StaticCraftingCooldown; set => Nach0PainterJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public override void Init()
        {
            Block = "Nach0PaintersTable";
            JobKey = NPCTypeKey;
            PrintName = NPCTypeKey;
        }
    }
}