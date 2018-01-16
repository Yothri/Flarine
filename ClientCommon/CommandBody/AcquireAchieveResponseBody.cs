using System;

namespace ClientCommon.CommandBody
{
	public class AcquireAchieveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.achieveId);
			writer.Write(this.achievePoint);
			writer.Write(this.achieveTitleKey);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.achieveId = reader.ReadInt32();
			this.achievePoint = reader.ReadInt32();
			this.achieveTitleKey = reader.ReadString();
		}

		public AcquireAchieveResponseBody()
		{
		}

		public int achieveId;

		public int achievePoint;

		public string achieveTitleKey;
	}
}
