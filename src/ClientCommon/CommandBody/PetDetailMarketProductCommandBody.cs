using System;

namespace ClientCommon.CommandBody
{
	public class PetDetailMarketProductCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.productId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.productId = reader.ReadGuid();
		}

		public PetDetailMarketProductCommandBody()
		{
		}

		public Guid productId;
	}
}
