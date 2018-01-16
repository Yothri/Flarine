using System;

namespace ClientCommon.CommandBody
{
	public class PickTenProductCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.categoryId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.categoryId = reader.ReadInt32();
		}

		public PickTenProductCommandBody()
		{
		}

		public int categoryId;
	}
}
