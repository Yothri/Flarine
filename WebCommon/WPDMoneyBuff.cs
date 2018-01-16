using System;

namespace WebCommon
{
	public class WPDMoneyBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.duration);
			writer.Write(this.moneyType);
			writer.Write(this.price);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.duration = reader.ReadInt32();
			this.moneyType = reader.ReadInt32();
			this.price = reader.ReadInt32();
		}

		public WPDMoneyBuff()
		{
		}

		public int buffId;

		public string name;

		public string nameKey;

		public int duration;

		public int moneyType;

		public int price;
	}
}
