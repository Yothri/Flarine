using System;

namespace ClientCommon.CommandBody
{
	public class CreateJewelCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.createItemId);
			writer.Write(this.ownFirstUse);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.createItemId = reader.ReadInt32();
			this.ownFirstUse = reader.ReadBoolean();
		}

		public CreateJewelCommandBody()
		{
		}

		public int createItemId;

		public bool ownFirstUse;
	}
}
