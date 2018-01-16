using System;

namespace WebCommon
{
	public class WPDMainQuest : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.chapterId);
			writer.Write(this.objectiveCompleted);
			writer.Write(this.completed);
			writer.Write(this.monsterKilledCount);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.targetGuide);
			writer.Write(this.targetGuideKey);
			writer.Write(this.completeGuide);
			writer.Write(this.completeGuideKey);
			writer.Write(this.npcId);
			writer.Write(this.type);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
			writer.Write(this.monsterId);
			writer.Write(this.monsterCount);
			writer.Write(this.completeNpcId);
			writer.Write(this.completeDialogue);
			writer.Write(this.completeDialogueKey);
			writer.Write(this.exp);
			writer.Write(this.gold);
			writer.Write(this.targetContinentId);
			writer.Write(this.targetXPosition);
			writer.Write(this.targetYPosition);
			writer.Write(this.targetZPosition);
			writer.Write(this.radius);
			writer.Write(this.nextMainQuestId);
			writer.Write(this.holdItemCount);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.moveType);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.chapterId = reader.ReadInt32();
			this.objectiveCompleted = reader.ReadBoolean();
			this.completed = reader.ReadBoolean();
			this.monsterKilledCount = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.targetGuide = reader.ReadString();
			this.targetGuideKey = reader.ReadString();
			this.completeGuide = reader.ReadString();
			this.completeGuideKey = reader.ReadString();
			this.npcId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.monsterCount = reader.ReadInt32();
			this.completeNpcId = reader.ReadInt32();
			this.completeDialogue = reader.ReadString();
			this.completeDialogueKey = reader.ReadString();
			this.exp = reader.ReadInt64();
			this.gold = reader.ReadInt32();
			this.targetContinentId = reader.ReadInt32();
			this.targetXPosition = reader.ReadDouble();
			this.targetYPosition = reader.ReadDouble();
			this.targetZPosition = reader.ReadDouble();
			this.radius = reader.ReadDouble();
			this.nextMainQuestId = reader.ReadInt32();
			this.holdItemCount = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.moveType = reader.ReadInt32();
		}

		public WPDMainQuest()
		{
		}

		public int mainQuestId;

		public int chapterId;

		public bool objectiveCompleted;

		public bool completed;

		public int monsterKilledCount;

		public string name;

		public string nameKey;

		public string targetGuide;

		public string targetGuideKey;

		public string completeGuide;

		public string completeGuideKey;

		public int npcId;

		public int type;

		public int itemId;

		public int itemCount;

		public int monsterId;

		public int monsterCount;

		public int completeNpcId;

		public string completeDialogue;

		public string completeDialogueKey;

		public long exp;

		public int gold;

		public int targetContinentId;

		public double targetXPosition;

		public double targetYPosition;

		public double targetZPosition;

		public double radius;

		public int nextMainQuestId;

		public int holdItemCount;

		public int requiredHeroLevel;

		public int moveType;
	}
}
