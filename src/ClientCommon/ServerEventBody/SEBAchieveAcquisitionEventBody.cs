using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBAchieveAcquisitionEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.achieveId);
			writer.Write(this.achieveTitleKey);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.achieveId = reader.ReadInt32();
			this.achieveTitleKey = reader.ReadString();
		}

		public SEBAchieveAcquisitionEventBody()
		{
		}

		public int accountHeroId;

		public int achieveId;

		public string achieveTitleKey;
	}
}
