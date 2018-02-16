using System;

namespace ClientCommon.CommandBody
{
	public class CouponUseCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.couponId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.couponId = reader.ReadString();
		}

		public CouponUseCommandBody()
		{
		}

		public string couponId;
	}
}
