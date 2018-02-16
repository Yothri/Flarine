using System;

namespace ClientCommon.CommandBody
{
	public class LastTaskRewardDiaAccomplishedCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryIds);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryIds = reader.ReadInts();
		}

		public LastTaskRewardDiaAccomplishedCommandBody()
		{
		}

		public int[] entryIds;
	}
}
