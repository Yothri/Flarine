using System;

namespace WebCommon
{
	public class WPDInAppProductPrice : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.inAppProductId);
			writer.Write(this.storeType);
			writer.Write(this.priceString);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.inAppProductId = reader.ReadInt32();
			this.storeType = reader.ReadInt32();
			this.priceString = reader.ReadString();
		}

		public WPDInAppProductPrice()
		{
		}

		public int inAppProductId;

		public int storeType;

		public string priceString;
	}
}
