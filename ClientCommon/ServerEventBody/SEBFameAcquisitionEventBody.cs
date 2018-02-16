using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBFameAcquisitionEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.fameId);
			writer.Write(this.fameTitleKey);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.fameId = reader.ReadInt32();
			this.fameTitleKey = reader.ReadString();
		}

		public SEBFameAcquisitionEventBody()
		{
		}

		public int accountHeroId;

		public int fameId;

		public string fameTitleKey;
	}
}
