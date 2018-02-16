using System;

namespace ClientCommon.CommandBody
{
	public class PartyCreateResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
		}

		public PartyCreateResponseBody()
		{
		}

		public long instanceId;

		public bool autoAccept;

		public int distributionType;
	}
}
