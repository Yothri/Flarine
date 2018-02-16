using System;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductFailCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.logId);
			writer.Write(this.failReason);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.logId = reader.ReadGuid();
			this.failReason = reader.ReadString();
		}

		public PurchaseProductFailCommandBody()
		{
		}

		public Guid logId;

		public string failReason;
	}
}
