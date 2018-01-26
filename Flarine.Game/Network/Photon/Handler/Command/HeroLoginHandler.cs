using System;
using System.Linq;
using ClientCommon;
using ClientCommon.CommandBody;
using ClientCommon.PacketData;
using ClientCommon.ServerEventBody;
using Flarine.Core.Network.Photon;
using Flarine.Game.Network.Photon.Common;

namespace Flarine.Game.Network.Photon.Handler.Command
{
    [PhotonCommandHandler(ClientCommandName.kCommand_HeroLogin, typeof(HeroLoginCommandBody))]
    internal sealed class HeroLoginHandler<T> : OperationHandler<T> where T : HeroLoginCommandBody
    {
        public override void Handle(PhotonGameConnection connection, T requestBody)
        {
            var session = GameContext.GameSessions
                .Where(s => s.Connection == connection)
                .FirstOrDefault();

            if (session == null) return;

            var hero = DataContext.Heros
                .Where(h => h.Id == session.SelectedPlayCharacter)
                .FirstOrDefault();

            if (hero == null) return;

            var heroLoginResponse = new HeroLoginResponseBody
            {
                accountHeroes = new PDAccountHero[] { },
                arenaStatue = new PDArenaStatue() { },
                abyssTowerFloor = 0,
                abyssTowerSweepCount = 0,
                accumulateChargeRewardReceiveEntryIds = new int[] { },
                accumulateConsumeRewardReceiveEntryIds = new int[] { },
                cheerAccountHeroes = new int[] { },
                worldBuffs = new PDWorldBuff[] { },
                suppressionQuestOfLastDate = new PDAccountHeroSuppressionQuest()
                {
                    chapterId = 1,
                    completed = false,
                    currentRound = new PDAccountHeroSuppressionQuestRound(),
                },
                continuationChargeRewardReceiveList = new int[] { },
                costumes = new PDAccountHeroCostume[] { },
                dailyChargeRewardReceiveEntryIds = new int[] { },
                dailyQuest = new PDAccountHeroDailyQuest() { },
                dailyQuestOfLastDate = new PDAccountHeroDailyQuest() { },
                date = DateTime.UtcNow,
                day30DiaRewardReceiveDays = new int[] { },
                day30RewardReceiveDays = new int[] { },
                dropObjects = new PDDropObject[] { },
                dungeonKingEventEntryLogs = new int[] { },
                elixirBuffs = new PDAccountHeroElixirBuff[] { },
                guildBattlefieldStatue = new PDGuildBattlefieldStatue() { },
                guildBuffs = new PDAccountHeroGuildBuff[] { },
                itemTypeUseCounts = new PDAccountHeroItemTypeUseCount[] { },
                levelUpMasterEventEntryRewardLogs = new int[] { },
                levelUpPackageEvent2EntryLogs = new int[] { },
                levelUpPackageEvent3EntryLogs = new int[] { },
                levelUpPackageEventEntryLogs = new int[] { },
                monsters = new PDMonsterInstance[] { },
                myAccountHero = new PDAccountHero()
                {
                    accountHeroId = hero.Id,
                    name = hero.Name,
                    level = hero.Level,
                    abnormalStateEffects = new PDAbnormalStateEffect[] { },
                    equippedGearExs = new PDAccountHeroGearEx[] { },
                    equippedGears = new PDAccountHeroGear[] { },
                    position = new PDVector3(0, 0, 0),
                    isGM = true
                },
                purchaseProductBuyCounts = new PDPurchaseProductBuyCount[] { },
                spawnedContinentBossMonsters = new int[] { },
                storyDungeonPlayCounts = new PDStoryDungeonPlayCount[] { },
                suppressionQuest = new PDAccountHeroSuppressionQuest() { }
            };

            connection.SendResponse(heroLoginResponse, ClientCommandName.kCommand_HeroLogin);


            // Send Hero Login to other clients
            // Later maybe check whether in range
            GameContext.GameSessions
                .Where(s => s.Connection != connection)
                .ToList()
                .ForEach(s => s.Connection.SendEvent(new SEBInterestTargetChangeEventBody
                {
                    addedAccountHeroes = new PDAccountHero[] { heroLoginResponse.myAccountHero }
                }, ServerEventName.kEvent_InterestTargetChange));
        }
    }
}