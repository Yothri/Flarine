using System;

namespace WebCommon
{
	public class WPDAchieve : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.achieveId);
			writer.Write(this.point);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.achieveId = reader.ReadInt32();
			this.point = reader.ReadInt32();
		}

		public WPDAchieve()
		{
		}

		public int achieveId;

		public int point;
	}
}
