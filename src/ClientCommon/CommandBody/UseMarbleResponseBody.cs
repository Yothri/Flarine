using System;

namespace ClientCommon.CommandBody
{
	public class UseMarbleResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.strength);
			writer.Write(this.agility);
			writer.Write(this.intelligence);
			writer.Write(this.stamina);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.strength = reader.ReadInt32();
			this.agility = reader.ReadInt32();
			this.intelligence = reader.ReadInt32();
			this.stamina = reader.ReadInt32();
		}

		public UseMarbleResponseBody()
		{
		}

		public DateTime date;

		public int strength;

		public int agility;

		public int intelligence;

		public int stamina;
	}
}
