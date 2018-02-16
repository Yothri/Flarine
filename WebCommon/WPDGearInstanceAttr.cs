using System;

namespace WebCommon
{
	public class WPDGearInstanceAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.rewardId);
			writer.Write(this.gearInstanceId);
			writer.Write(this.type);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.rewardId = reader.ReadInt32();
			this.gearInstanceId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDGearInstanceAttr()
		{
		}

		public int rewardId;

		public int gearInstanceId;

		public int type;

		public int attrId;

		public double value;
	}
}
