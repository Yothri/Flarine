using System;

namespace ClientCommon.CommandBody
{
	public class EssenceExchangeSubmitCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.turn);
			writer.Write(this.round);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.turn = reader.ReadInt32();
			this.round = reader.ReadInt32();
		}

		public EssenceExchangeSubmitCommandBody()
		{
		}

		public int continentId;

		public int turn;

		public int round;
	}
}
