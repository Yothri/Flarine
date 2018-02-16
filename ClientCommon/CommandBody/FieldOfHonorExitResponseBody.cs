using System;

namespace ClientCommon.CommandBody
{
	public class FieldOfHonorExitResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.hp);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.hp = reader.ReadInt32();
		}

		public FieldOfHonorExitResponseBody()
		{
		}

		public int continentId;

		public int hp;
	}
}
