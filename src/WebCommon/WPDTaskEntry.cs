using System;

namespace WebCommon
{
	public class WPDTaskEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.rewardDiv1);
			writer.Write(this.rewardDiv2);
			writer.Write(this.rewardDiv3);
			writer.Write(this.isLastTask);
			writer.Write(this.lastTaskRewardType);
			writer.Write(this.receivedEntryId);
			writer.Write(this.date);
			writer.Write(this.activationNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.rewardDiv1 = reader.ReadInt32();
			this.rewardDiv2 = reader.ReadInt32();
			this.rewardDiv3 = reader.ReadInt32();
			this.isLastTask = reader.ReadBoolean();
			this.lastTaskRewardType = reader.ReadInt32();
			this.receivedEntryId = reader.ReadInt32();
			this.date = reader.ReadString();
			this.activationNo = reader.ReadInt32();
		}

		public WPDTaskEntry()
		{
		}

		public int entryId;

		public string name;

		public string nameKey;

		public int rewardDiv1;

		public int rewardDiv2;

		public int rewardDiv3;

		public bool isLastTask;

		public int lastTaskRewardType;

		public int receivedEntryId;

		public string date;

		public int activationNo;
	}
}
