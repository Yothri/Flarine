using System;

namespace ClientCommon.PacketData
{
	public abstract class PDReward : PDPacketData
	{
		public abstract int type { get; }

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.owned);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.owned = reader.ReadBoolean();
		}

		public static PDReward Create(int nType)
		{
			switch (nType)
			{
			case 1:
				return new PDGearReward();
			case 2:
				return new PDItemReward();
			default:
				return null;
			}
		}

		protected PDReward()
		{
		}

		public const int kType_Gear = 1;

		public const int kType_Item = 2;

		public bool owned;
	}
}
