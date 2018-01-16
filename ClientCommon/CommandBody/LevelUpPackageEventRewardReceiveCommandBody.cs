using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpPackageEventRewardReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
		}

		public LevelUpPackageEventRewardReceiveCommandBody()
		{
		}

		public int entryId;
	}
}
