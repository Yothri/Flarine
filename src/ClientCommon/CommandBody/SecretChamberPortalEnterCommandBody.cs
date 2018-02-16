using System;

namespace ClientCommon.CommandBody
{
	public class SecretChamberPortalEnterCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.portalId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.portalId = reader.ReadInt32();
		}

		public SecretChamberPortalEnterCommandBody()
		{
		}

		public int portalId;
	}
}
