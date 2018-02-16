using System;

namespace WebCommon
{
	public class WPDDay30DiaReward : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.day);
			writer.Write(this.ownDia);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.day = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDDay30DiaReward()
		{
		}

		public int day;

		public int ownDia;

		public int unOwnDia;
	}
}
