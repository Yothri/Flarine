using System;

namespace ClientCommon.PacketData
{
	public abstract class PDPacketData
	{
		public virtual void Serialize(PacketWriter writer)
		{
		}

		public virtual void Deserialize(PacketReader reader)
		{
		}

		protected PDPacketData()
		{
		}
	}
}
