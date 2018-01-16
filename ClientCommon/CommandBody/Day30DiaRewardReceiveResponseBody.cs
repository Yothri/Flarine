using System;

namespace ClientCommon.CommandBody
{
	public class Day30DiaRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownDia);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownDia = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public Day30DiaRewardReceiveResponseBody()
		{
		}

		public int ownDia;

		public int unOwnDia;
	}
}
