using System;

namespace WebCommon
{
	public class WPDGearInstance : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardId);
			writer.Write(this.gearInstanceId);
			writer.Write(this.grade);
			writer.Write(this.owned);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.socketCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardId = reader.ReadInt32();
			this.gearInstanceId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.socketCount = reader.ReadInt32();
		}

		public WPDGearInstance()
		{
		}

		public int rewardId;

		public int gearInstanceId;

		public int grade;

		public bool owned;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int socketCount;
	}
}
