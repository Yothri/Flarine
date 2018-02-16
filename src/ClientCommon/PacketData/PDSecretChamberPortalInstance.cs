using System;

namespace ClientCommon.PacketData
{
	public class PDSecretChamberPortalInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.portalId);
			writer.Write(this.linkedFloor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.portalId = reader.ReadInt32();
			this.linkedFloor = reader.ReadInt32();
		}

		public PDSecretChamberPortalInstance()
		{
		}

		public int floor;

		public int portalId;

		public int linkedFloor;
	}
}
