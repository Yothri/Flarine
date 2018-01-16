using System;

namespace ClientCommon.CommandBody
{
	public class LastTaskRewardGoldAccomplishedCommandBody : CommandBody
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

		public LastTaskRewardGoldAccomplishedCommandBody()
		{
		}

		public int[] entryIds;
	}
}
