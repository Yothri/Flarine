using System;

namespace ClientCommon.CommandBody
{
	public class CostumeEquipCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
		}

		public CostumeEquipCommandBody()
		{
		}

		public int id;
	}
}
