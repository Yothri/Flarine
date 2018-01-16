using System;

namespace ClientCommon.CommandBody
{
	public class UseCostumeTicketCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotNo);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.slotNo = reader.ReadInt32();
		}

		public UseCostumeTicketCommandBody()
		{
		}

		public int slotNo;
	}
}
