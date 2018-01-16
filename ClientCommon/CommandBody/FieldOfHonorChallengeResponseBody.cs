using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorChallengeResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.targetAccountHero);
			writer.Write(this.dia);
			writer.Write(this.hp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.targetAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.dia = reader.ReadInt32();
			this.hp = reader.ReadInt32();
		}

		public FieldOfHonorChallengeResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero targetAccountHero;

		public int dia;

		public int hp;
	}
}
