using System;

namespace ClientCommon.CommandBody
{
	public class PartySettingsChangeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
		}

		public PartySettingsChangeCommandBody()
		{
		}

		public bool autoAccept;

		public int distributionType;
	}
}
