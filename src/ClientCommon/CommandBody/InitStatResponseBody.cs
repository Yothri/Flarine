using System;

namespace ClientCommon.CommandBody
{
	public class InitStatResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.statPoint);
			writer.Write(this.statStrength);
			writer.Write(this.statStamina);
			writer.Write(this.statAgility);
			writer.Write(this.statIntelligence);
			writer.Write(this.dia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.statPoint = reader.ReadInt32();
			this.statStrength = reader.ReadInt32();
			this.statStamina = reader.ReadInt32();
			this.statAgility = reader.ReadInt32();
			this.statIntelligence = reader.ReadInt32();
			this.dia = reader.ReadInt32();
		}

		public InitStatResponseBody()
		{
		}

		public int statPoint;

		public int statStrength;

		public int statStamina;

		public int statAgility;

		public int statIntelligence;

		public int dia;
	}
}
