using System;
using Pipliz.Mods.APIProvider.Jobs;
using PhentrixGames.NewColonyAPI;
using Pipliz.Mods.APIProvider;
using PhentrixGames.NewColonyAPI.Jobs;
using BlockTypes.Builtin;
using Server.NPCs;
using System.Collections.Generic;

namespace Nach0Jobs
{
    public class Nach0PaintMixerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0PaintMixerJob";
        public override float CraftingCooldown { get => Nach0PaintMixerJob.StaticCraftingCooldown; set => Nach0PaintMixerJob.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "PaintMixer",
                maskColor1 = new UnityEngine.Color32(0, 0, 0, 0),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}