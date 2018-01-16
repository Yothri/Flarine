using System;

namespace ClientCommon.CommandBody
{
	public class MoneyBuffUseCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
		}

		public MoneyBuffUseCommandBody()
		{
		}

		public int buffId;
	}
}
