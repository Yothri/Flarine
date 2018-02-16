using System;

namespace ClientCommon.CommandBody
{
	public class SecretChamberPortalEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
		}

		public SecretChamberPortalEnterResponseBody()
		{
		}

		public int floor;
	}
}
