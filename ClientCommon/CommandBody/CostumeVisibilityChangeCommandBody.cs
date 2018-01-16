using System;

namespace ClientCommon.CommandBody
{
	public class CostumeVisibilityChangeCommandBody : CommandBody
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

		public CostumeVisibilityChangeCommandBody()
		{
		}

		public bool visible;
	}
}
