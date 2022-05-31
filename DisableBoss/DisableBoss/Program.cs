using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;
using DisableBossConfig;
using Terraria.ID;

namespace DisableBoss
{
    [ApiVersion(2, 1)]
    public class DisableBossPlugin : TerrariaPlugin
    {
        public override string Author => "Ozz5581";

        public override string Description => "Disable specific bosses";

        public override string Name => "DisableBoss";

        public override Version Version => new Version(1, 0, 0, 0);

        public DisableBossPlugin(Main game) : base(game)
        {

        }

        private static Config Config = Config.Read();

        public override void Initialize()
        {
            ServerApi.Hooks.NpcSpawn.Register(this, OnNPCSpawn);

            Commands.ChatCommands.Add(new Command("disableboss.reload", ReloadCommand, "breload"));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Deregister hooks here
            }
            base.Dispose(disposing);
        }

        private void ReloadCommand(CommandArgs args)
        {
            Config = Config.Read();
            args.Player.SendInfoMessage("DisableBoss config reloaded!");
        }

        public void OnNPCSpawn(NpcSpawnEventArgs args)
        {
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];

                if (!Config.AllowKingSlime && npc.type == NPCID.KingSlime) // King Slime
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowEyeOfCthulhu && npc.type == NPCID.EyeofCthulhu) // Eye of Cthulhu
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowEaterOfWorlds && npc.type == NPCID.EaterofWorldsHead) // Eater of Worlds
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowBrainOfCthulhu && npc.type == NPCID.BrainofCthulhu) // Brain of Cthulhu
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowQueenBee && npc.type == NPCID.QueenBee) // Queen Bee
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowSkeletron && npc.type == NPCID.SkeletronHead) // Skeletron
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowDeerclops && npc.type == NPCID.Deerclops) // Deerclops
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowWallOfFlesh && npc.type == NPCID.WallofFlesh) // Wall of Flesh
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowQueenSlime && npc.type == NPCID.QueenSlimeBoss) // Queen Slime
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowTheTwins && (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)) // The Twins
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowTheDestroyer && npc.type == NPCID.TheDestroyer) // The Destroyer
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowSkeletronPrime && npc.type == NPCID.SkeletronPrime) // Skeletron Prime
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowPlantera && npc.type == NPCID.Plantera) // Plantera
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowGolem && npc.type == NPCID.Golem) // Golem
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowDukeFishron && npc.type == NPCID.DukeFishron) // Duke Fishron
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowEmpressOfLight && npc.type == NPCID.HallowBoss) // Empress of Light
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowLunaticCultist && npc.type == NPCID.CultistBoss) // Lunatic Cultist
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }

                if (!Config.AllowMoonLord && npc.type == NPCID.MoonLordCore) // Moon Lord
                {
                    Main.npc[i].active = false;
                    Main.npc[i].type = 0;
                    TSPlayer.All.SendData(PacketTypes.NpcUpdate, "", i);
                }
            }
        }
    }
}