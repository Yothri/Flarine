using System;

namespace ClientCommon.CommandBody
{
	public class CreateShiningOrichalcumCommandBody : CommandBody
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

		public CreateShiningOrichalcumCommandBody()
		{
		}

		public bool ownFirstUse;
	}
}
