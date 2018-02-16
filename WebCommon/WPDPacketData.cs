using System;

namespace WebCommon
{
	public abstract class WPDPacketData
	{
		public virtual void Serialize(WPacketWriter writer)
		{
		}

		public virtual void Deserialize(WPacketReader reader)
		{
		}

		protected WPDPacketData()
		{
		}
	}
}
