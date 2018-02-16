using System;

namespace WebCommon
{
	public class WPDPetInstanceAttr : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petInstanceId);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.petInstanceId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDPetInstanceAttr()
		{
		}

		public int petInstanceId;

		public int attrId;

		public double value;
	}
}
