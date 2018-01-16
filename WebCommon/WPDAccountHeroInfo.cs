using System;
using System.IO;

namespace WebCommon
{
	public class WPDAccountHeroInfo : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.accountHeroVipLevelRewards);
			writer.Write(this.equipedGears);
			writer.Write(this.equippedGearSockets);
			writer.Write(this.equippedGearRunes);
			writer.Write(this.inventories);
			writer.Write(this.accountHeroGears);
			writer.Write(this.sockets);
			writer.Write(this.inventorySlotGearRunes);
			writer.Write(this.accountHeroSkills);
			writer.Write(this.mainQuestComplete);
			writer.Write(this.mainQuest);
			writer.Write(this.mainQuestDialogues);
			writer.Write(this.mainQuestRewards);
			writer.Write(this.gearInstances);
			writer.Write(this.gearInstanceAttrs);
			writer.Write(this.accountHeroAchieveEntries);
			writer.Write(this.accountHeroMonsterBooks);
			writer.Write(this.monsterBookBuffs);
			writer.Write(this.warehouseSlotItems);
			writer.Write(this.warehouseSlotGears);
			writer.Write(this.warehouseSlotGearSockets);
			writer.Write(this.warehouseSlotGearRunes);
			writer.Write(this.storyDungeonDifficulties);
			writer.Write(this.expDungeonDifficulties);
			writer.Write(this.stores);
			writer.Write(this.storeCategories);
			writer.Write(this.products);
			writer.Write(this.limitedProductMasters);
			writer.Write(this.limitedProducts);
			writer.Write(this.dailyExchangeProducts);
			writer.Write(this.dailyExchangeProductTargets);
			writer.Write(this.magicPowderExchangeProducts);
			writer.Write(this.pickAvailableProducts);
			writer.Write(this.pickAvailableProductGears);
			writer.Write(this.pickPointExchangeProducts);
			writer.Write(this.pickProductWarehouseSlotItems);
			writer.Write(this.pickProductWarehouseSlotGears);
			writer.Write(this.equipmentProducts);
			writer.Write(this.pickPetAvailableProducts);
			writer.Write(this.ankouTombDifficulties);
			writer.Write(this.bossAnnihilationDifficulties);
			writer.Write(this.tradeShipDifficulties);
			writer.Write(this.taskEntries);
			writer.Write(this.taskTraditionRewards);
			writer.Write(this.taskMainChapterRewards);
			writer.Write(this.taskRewardItems);
			writer.Write(this.dailyActiveEntries);
			writer.Write(this.dailyActiveRewards);
			writer.Write(this.dailyActiveRewardItems);
			writer.Write(this.heroLevelRewards);
			writer.Write(this.heroLevelRewardItems);
			writer.Write(this.continuationLoginRewardItems);
			writer.Write(this.accumulateLoginRewards);
			writer.Write(this.accumulateLoginRewardItems);
			writer.Write(this.dailyAccessRewards);
			writer.Write(this.constellationStepEntries);
			writer.Write(this.petInventorySlots);
			writer.Write(this.equippedPets);
			writer.Write(this.pickPetWarehouseSlots);
			writer.Write(this.petInstances);
			writer.Write(this.petInstanceAttrs);
			writer.Write(this.beadInventorySlots);
			writer.Write(this.beadSockets);
			writer.Write(this.accountHeroMenuActivations);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<WPDAccountHero>();
			this.accountHeroVipLevelRewards = reader.ReadPDPacketDatas<WPDAccountHeroVipLevelReward>();
			this.equipedGears = reader.ReadPDPacketDatas<WPDEquipedGear>();
			this.equippedGearSockets = reader.ReadPDPacketDatas<WPDEquippedGearSocket>();
			this.equippedGearRunes = reader.ReadPDPacketDatas<WPDEquippedGearRune>();
			this.inventories = reader.ReadPDPacketDatas<WPDInventory>();
			this.accountHeroGears = reader.ReadPDPacketDatas<WPDAccountHeroGear>();
			this.sockets = reader.ReadPDPacketDatas<WPDSocket>();
			this.inventorySlotGearRunes = reader.ReadPDPacketDatas<WPDInventorySlotGearRune>();
			this.accountHeroSkills = reader.ReadPDPacketDatas<WPDAccountHeroSkill>();
			this.mainQuestComplete = reader.ReadPDPacketData<WPDMainQuestComplete>();
			this.mainQuest = reader.ReadPDPacketData<WPDMainQuest>();
			this.mainQuestDialogues = reader.ReadPDPacketDatas<WPDMainQuestDialogue>();
			this.mainQuestRewards = reader.ReadPDPacketDatas<WPDMainQuestReward>();
			this.gearInstances = reader.ReadPDPacketDatas<WPDGearInstance>();
			this.gearInstanceAttrs = reader.ReadPDPacketDatas<WPDGearInstanceAttr>();
			this.accountHeroAchieveEntries = reader.ReadPDPacketDatas<WPDAccountHeroAchieveEntry>();
			this.accountHeroMonsterBooks = reader.ReadPDPacketDatas<WPDAccountHeroMonsterBook>();
			this.monsterBookBuffs = reader.ReadPDPacketDatas<WPDMonsterBookBuff>();
			this.warehouseSlotItems = reader.ReadPDPacketDatas<WPDWarehouseSlotItem>();
			this.warehouseSlotGears = reader.ReadPDPacketDatas<WPDWarehouseSlotGear>();
			this.warehouseSlotGearSockets = reader.ReadPDPacketDatas<WPDWarehouseSlotGearSocket>();
			this.warehouseSlotGearRunes = reader.ReadPDPacketDatas<WPDWarehouseSlotGearRune>();
			this.storyDungeonDifficulties = reader.ReadPDPacketDatas<WPDAHStoryDungeonDifficulty>();
			this.expDungeonDifficulties = reader.ReadPDPacketDatas<WPDAHExpDungeonDifficulty>();
			this.stores = reader.ReadPDPacketDatas<WPDStore>();
			this.storeCategories = reader.ReadPDPacketDatas<WPDStoreCategory>();
			this.products = reader.ReadPDPacketDatas<WPDProduct>();
			this.limitedProductMasters = reader.ReadPDPacketDatas<WPDLimitedProductMaster>();
			this.limitedProducts = reader.ReadPDPacketDatas<WPDLimitedProduct>();
			this.dailyExchangeProducts = reader.ReadPDPacketDatas<WPDDailyExchangeProduct>();
			this.dailyExchangeProductTargets = reader.ReadPDPacketDatas<WPDDailyExchangeProductTarget>();
			this.magicPowderExchangeProducts = reader.ReadPDPacketDatas<WPDMagicPowderExchangeProduct>();
			this.pickAvailableProducts = reader.ReadPDPacketDatas<WPDPickAvailableProduct>();
			this.pickAvailableProductGears = reader.ReadPDPacketDatas<WPDPickAvailableProductGear>();
			this.pickPointExchangeProducts = reader.ReadPDPacketDatas<WPDPickPointExchangeProduct>();
			this.pickProductWarehouseSlotItems = reader.ReadPDPacketDatas<WPDPickProductWarehouseSlotItem>();
			this.pickProductWarehouseSlotGears = reader.ReadPDPacketDatas<WPDPickProductWarehouseSlotGear>();
			this.equipmentProducts = reader.ReadPDPacketDatas<WPDEquipmentProduct>();
			this.pickPetAvailableProducts = reader.ReadPDPacketDatas<WPDPickPetAvailableProduct>();
			this.ankouTombDifficulties = reader.ReadPDPacketDatas<WPDAHAnkouTombDifficulty>();
			this.bossAnnihilationDifficulties = reader.ReadPDPacketDatas<WPDAHBossAnnihilationDifficulty>();
			this.tradeShipDifficulties = reader.ReadPDPacketDatas<WPDAHTradeShipDifficulty>();
			this.taskEntries = reader.ReadPDPacketDatas<WPDTaskEntry>();
			this.taskTraditionRewards = reader.ReadPDPacketDatas<WPDTaskTraditionReward>();
			this.taskMainChapterRewards = reader.ReadPDPacketDatas<WPDTaskMainChapterReward>();
			this.taskRewardItems = reader.ReadPDPacketDatas<WPDTaskRewardItem>();
			this.dailyActiveEntries = reader.ReadPDPacketDatas<WPDDailyActiveEntry>();
			this.dailyActiveRewards = reader.ReadPDPacketDatas<WPDDailyActiveReward>();
			this.dailyActiveRewardItems = reader.ReadPDPacketDatas<WPDDailyActiveRewardItem>();
			this.heroLevelRewards = reader.ReadPDPacketDatas<WPDHeroLevelReward>();
			this.heroLevelRewardItems = reader.ReadPDPacketDatas<WPDHeroLevelRewardItem>();
			this.continuationLoginRewardItems = reader.ReadPDPacketDatas<WPDContinuationLoginRewardItem>();
			this.accumulateLoginRewards = reader.ReadPDPacketDatas<WPDAccumulateLoginReward>();
			this.accumulateLoginRewardItems = reader.ReadPDPacketDatas<WPDAccumulateLoginRewardItem>();
			this.dailyAccessRewards = reader.ReadPDPacketDatas<WPDDailyAccessReward>();
			this.constellationStepEntries = reader.ReadPDPacketDatas<WPDAHConstellationStepEntry>();
			this.petInventorySlots = reader.ReadPDPacketDatas<WPDPetInventorySlot>();
			this.equippedPets = reader.ReadPDPacketDatas<WPDEquippedPet>();
			this.pickPetWarehouseSlots = reader.ReadPDPacketDatas<WPDPickPetWarehouseSlot>();
			this.petInstances = reader.ReadPDPacketDatas<WPDPetInstance>();
			this.petInstanceAttrs = reader.ReadPDPacketDatas<WPDPetInstanceAttr>();
			this.beadInventorySlots = reader.ReadPDPacketDatas<WPDBeadInventorySlot>();
			this.beadSockets = reader.ReadPDPacketDatas<WPDBeadSocket>();
			this.accountHeroMenuActivations = reader.ReadPDPacketDatas<WPDAccountHeroMenuActivation>();
		}

		public string SerializeBase64String()
		{
			byte[] inArray;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				WPacketWriter writer = new WPacketWriter(memoryStream);
				this.Serialize(writer);
				inArray = memoryStream.ToArray();
			}
			return Convert.ToBase64String(inArray);
		}

		public void DeserializeFromBase64String(string sData)
		{
			byte[] buffer = Convert.FromBase64String(sData);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				WPacketReader reader = new WPacketReader(memoryStream);
				this.Deserialize(reader);
			}
		}

		public WPDAccountHeroInfo()
		{
		}

		public WPDAccountHero accountHero;

		public WPDAccountHeroVipLevelReward[] accountHeroVipLevelRewards;

		public WPDEquipedGear[] equipedGears;

		public WPDEquippedGearSocket[] equippedGearSockets;

		public WPDEquippedGearRune[] equippedGearRunes;

		public WPDInventory[] inventories;

		public WPDAccountHeroGear[] accountHeroGears;

		public WPDSocket[] sockets;

		public WPDInventorySlotGearRune[] inventorySlotGearRunes;

		public WPDAccountHeroSkill[] accountHeroSkills;

		public WPDMainQuestComplete mainQuestComplete;

		public WPDMainQuest mainQuest;

		public WPDMainQuestDialogue[] mainQuestDialogues;

		public WPDMainQuestReward[] mainQuestRewards;

		public WPDGearInstance[] gearInstances;

		public WPDGearInstanceAttr[] gearInstanceAttrs;

		public WPDAccountHeroAchieveEntry[] accountHeroAchieveEntries;

		public WPDAccountHeroMonsterBook[] accountHeroMonsterBooks;

		public WPDMonsterBookBuff[] monsterBookBuffs;

		public WPDWarehouseSlotItem[] warehouseSlotItems;

		public WPDWarehouseSlotGear[] warehouseSlotGears;

		public WPDWarehouseSlotGearSocket[] warehouseSlotGearSockets;

		public WPDWarehouseSlotGearRune[] warehouseSlotGearRunes;

		public WPDAHStoryDungeonDifficulty[] storyDungeonDifficulties;

		public WPDAHExpDungeonDifficulty[] expDungeonDifficulties;

		public WPDStore[] stores;

		public WPDStoreCategory[] storeCategories;

		public WPDProduct[] products;

		public WPDLimitedProductMaster[] limitedProductMasters;

		public WPDLimitedProduct[] limitedProducts;

		public WPDDailyExchangeProduct[] dailyExchangeProducts;

		public WPDDailyExchangeProductTarget[] dailyExchangeProductTargets;

		public WPDMagicPowderExchangeProduct[] magicPowderExchangeProducts;

		public WPDPickAvailableProduct[] pickAvailableProducts;

		public WPDPickAvailableProductGear[] pickAvailableProductGears;

		public WPDPickPointExchangeProduct[] pickPointExchangeProducts;

		public WPDPickProductWarehouseSlotItem[] pickProductWarehouseSlotItems;

		public WPDPickProductWarehouseSlotGear[] pickProductWarehouseSlotGears;

		public WPDEquipmentProduct[] equipmentProducts;

		public WPDPickPetAvailableProduct[] pickPetAvailableProducts;

		public WPDAHAnkouTombDifficulty[] ankouTombDifficulties;

		public WPDAHBossAnnihilationDifficulty[] bossAnnihilationDifficulties;

		public WPDAHTradeShipDifficulty[] tradeShipDifficulties;

		public WPDTaskEntry[] taskEntries;

		public WPDTaskTraditionReward[] taskTraditionRewards;

		public WPDTaskMainChapterReward[] taskMainChapterRewards;

		public WPDTaskRewardItem[] taskRewardItems;

		public WPDDailyActiveEntry[] dailyActiveEntries;

		public WPDDailyActiveReward[] dailyActiveRewards;

		public WPDDailyActiveRewardItem[] dailyActiveRewardItems;

		public WPDHeroLevelReward[] heroLevelRewards;

		public WPDHeroLevelRewardItem[] heroLevelRewardItems;

		public WPDContinuationLoginRewardItem[] continuationLoginRewardItems;

		public WPDAccumulateLoginReward[] accumulateLoginRewards;

		public WPDAccumulateLoginRewardItem[] accumulateLoginRewardItems;

		public WPDDailyAccessReward[] dailyAccessRewards;

		public WPDAHConstellationStepEntry[] constellationStepEntries;

		public WPDPetInventorySlot[] petInventorySlots;

		public WPDEquippedPet[] equippedPets;

		public WPDPickPetWarehouseSlot[] pickPetWarehouseSlots;

		public WPDPetInstance[] petInstances;

		public WPDPetInstanceAttr[] petInstanceAttrs;

		public WPDBeadInventorySlot[] beadInventorySlots;

		public WPDBeadSocket[] beadSockets;

		public WPDAccountHeroMenuActivation[] accountHeroMenuActivations;
	}
}
