using System;

namespace ClientCommon.CommandBody
{
	public class MoneyBuffUseResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.usedGold);
			writer.Write(this.usedOwnGold);
			writer.Write(this.usedDia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.usedGold = reader.ReadInt32();
			this.usedOwnGold = reader.ReadInt32();
			this.usedDia = reader.ReadInt32();
		}

		public MoneyBuffUseResponseBody()
		{
		}

		public int usedGold;

		public int usedOwnGold;

		public int usedDia;
	}
}
