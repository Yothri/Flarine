using System;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductCompleteCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.logId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.logId = reader.ReadGuid();
		}

		public PurchaseProductCompleteCommandBody()
		{
		}

		public Guid logId;
	}
}
