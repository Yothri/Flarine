using System;

namespace ClientCommon.PacketData
{
	public class PDMainQuest : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.mainChapterId);
			writer.Write(this.nameKey);
			writer.Write(this.targetGuideKey);
			writer.Write(this.completeGuideKey);
			writer.Write(this.npcId);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.monsterId);
			writer.Write(this.monsterCount);
			writer.Write(this.completeNpcId);
			writer.Write(this.completeDialogueKey);
			writer.Write(this.exp);
			writer.Write(this.gold);
			writer.Write(this.targetContinentId);
			writer.Write(this.targetPosition);
			writer.Write(this.radius);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.moveType);
			writer.Write(this.nextMainQuestId);
			writer.Write(this.rewards);
			writer.Write(this.dialogues);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.mainChapterId = reader.ReadInt32();
			this.nameKey = reader.ReadString();
			this.targetGuideKey = reader.ReadString();
			this.completeGuideKey = reader.ReadString();
			this.npcId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.monsterCount = reader.ReadInt32();
			this.completeNpcId = reader.ReadInt32();
			this.completeDialogueKey = reader.ReadString();
			this.exp = reader.ReadInt64();
			this.gold = reader.ReadInt32();
			this.targetContinentId = reader.ReadInt32();
			this.targetPosition = reader.ReadPDVector3();
			this.radius = reader.ReadSingle();
			this.requiredHeroLevel = reader.ReadInt32();
			this.moveType = reader.ReadInt32();
			this.nextMainQuestId = reader.ReadInt32();
			this.rewards = reader.ReadPDPacketDatas<PDMainQuestReward>();
			this.dialogues = reader.ReadPDPacketDatas<PDMainQuestDialogue>();
		}

		public PDMainQuest()
		{
		}

		public int id;

		public int mainChapterId;

		public string nameKey;

		public string targetGuideKey;

		public string completeGuideKey;

		public int npcId;

		public int type;

		public int itemId;

		public int itemCount;

		public int monsterId;

		public int monsterCount;

		public int completeNpcId;

		public string completeDialogueKey;

		public long exp;

		public int gold;

		public int targetContinentId;

		public PDVector3 targetPosition;

		public float radius;

		public int requiredHeroLevel;

		public int moveType;

		public int nextMainQuestId;

		public PDMainQuestReward[] rewards;

		public PDMainQuestDialogue[] dialogues;
	}
}
