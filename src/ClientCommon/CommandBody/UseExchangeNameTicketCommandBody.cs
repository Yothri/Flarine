using System;

namespace ClientCommon.CommandBody
{
	public class UseExchangeNameTicketCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotNo);
			writer.Write(this.changeName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.slotNo = reader.ReadInt32();
			this.changeName = reader.ReadString();
		}

		public UseExchangeNameTicketCommandBody()
		{
		}

		public int slotNo;

		public string changeName;
	}
}
