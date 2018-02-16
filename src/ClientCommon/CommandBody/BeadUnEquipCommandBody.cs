using System;

namespace ClientCommon.CommandBody
{
	public class BeadUnEquipCommandBody : CommandBody
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

		public BeadUnEquipCommandBody()
		{
		}

		public int socketId;
	}
}
