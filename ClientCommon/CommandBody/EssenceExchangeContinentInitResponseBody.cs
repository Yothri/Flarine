using System;

namespace ClientCommon.CommandBody
{
	public class EssenceExchangeContinentInitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.turn);
			writer.Write(this.turnRemainingTime);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.turn = reader.ReadInt32();
			this.turnRemainingTime = reader.ReadSingle();
			this.dia = reader.ReadInt32();
		}

		public EssenceExchangeContinentInitResponseBody()
		{
		}

		public int turn;

		public float turnRemainingTime;

		public int dia;
	}
}
