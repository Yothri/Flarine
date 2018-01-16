using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpPetCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetAccountHeroPetId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetAccountHeroPetId = reader.ReadGuid();
		}

		public LevelUpPetCommandBody()
		{
		}

		public Guid targetAccountHeroPetId;
	}
}
