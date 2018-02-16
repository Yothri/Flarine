using System;

namespace ClientCommon.CommandBody
{
	public class AccumulateLoginGetRewardCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.loginCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.loginCount = reader.ReadInt32();
		}

		public AccumulateLoginGetRewardCommandBody()
		{
		}

		public int loginCount;
	}
}
