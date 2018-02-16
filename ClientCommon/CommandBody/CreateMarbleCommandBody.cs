using System;

namespace ClientCommon.CommandBody
{
	public class CreateMarbleCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownFirstUse);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownFirstUse = reader.ReadBoolean();
		}

		public CreateMarbleCommandBody()
		{
		}

		public bool ownFirstUse;
	}
}
