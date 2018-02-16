using System;

namespace ClientCommon.CommandBody
{
	public class CostumeEquipResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.visible);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.visible = reader.ReadBoolean();
		}

		public CostumeEquipResponseBody()
		{
		}

		public bool visible;
	}
}
