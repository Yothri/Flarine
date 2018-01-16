using System;

namespace ClientCommon.CommandBody
{
	public class BeadEquipResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.socketId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.socketId = reader.ReadInt32();
		}

		public BeadEquipResponseBody()
		{
		}

		public int socketId;
	}
}
