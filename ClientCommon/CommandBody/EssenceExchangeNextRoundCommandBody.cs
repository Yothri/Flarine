using System;

namespace ClientCommon.CommandBody
{
	public class EssenceExchangeNextRoundCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
		}

		public EssenceExchangeNextRoundCommandBody()
		{
		}

		public int continentId;
	}
}
