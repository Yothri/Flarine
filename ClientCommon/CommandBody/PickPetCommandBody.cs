using System;

namespace ClientCommon.CommandBody
{
	public class PickPetCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pickMethod);
			writer.Write(this.pickCategoryId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pickMethod = reader.ReadInt32();
			this.pickCategoryId = reader.ReadInt32();
		}

		public PickPetCommandBody()
		{
		}

		public int pickMethod;

		public int pickCategoryId;
	}
}
