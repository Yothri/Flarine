using System;

namespace ClientCommon.CommandBody
{
	public class UseCostumeTicketResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.costumeId);
			writer.Write(this.costumeLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.costumeId = reader.ReadInt32();
			this.costumeLevel = reader.ReadInt32();
		}

		public UseCostumeTicketResponseBody()
		{
		}

		public int costumeId;

		public int costumeLevel;
	}
}
