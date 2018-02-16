using System;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductCancelCommandBody : CommandBody
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

		public PurchaseProductCancelCommandBody()
		{
		}

		public Guid logId;
	}
}
