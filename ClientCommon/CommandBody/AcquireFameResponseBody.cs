using System;

namespace ClientCommon.CommandBody
{
	public class AcquireFameResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fameId);
			writer.Write(this.fameTitleKey);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fameId = reader.ReadInt32();
			this.fameTitleKey = reader.ReadString();
		}

		public AcquireFameResponseBody()
		{
		}

		public int fameId;

		public string fameTitleKey;
	}
}
