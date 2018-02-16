using System;

namespace WebCommon
{
	public class WPDTrackingLocation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.locationId);
			writer.Write(this.aosTrackingId);
			writer.Write(this.iosTrackingId);
			writer.Write(this.myCardTrackingId);
			writer.Write(this.oneStoreTrackingId);
			writer.Write(this.commonTrackingId);
			writer.Write(this.multipleCalling);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.locationId = reader.ReadString();
			this.aosTrackingId = reader.ReadString();
			this.iosTrackingId = reader.ReadString();
			this.myCardTrackingId = reader.ReadString();
			this.oneStoreTrackingId = reader.ReadString();
			this.commonTrackingId = reader.ReadString();
			this.multipleCalling = reader.ReadBoolean();
		}

		public WPDTrackingLocation()
		{
		}

		public string locationId;

		public string aosTrackingId;

		public string iosTrackingId;

		public string myCardTrackingId;

		public string oneStoreTrackingId;

		public string commonTrackingId;

		public bool multipleCalling;
	}
}
