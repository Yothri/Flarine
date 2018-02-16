using System;

namespace ClientCommon.CommandBody
{
	public class EquipPetCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroPetId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroPetId = reader.ReadGuid();
		}

		public EquipPetCommandBody()
		{
		}

		public Guid accountHeroPetId;
	}
}
