using System;

namespace ClientCommon.CommandBody
{
	public class AcquireConstellationResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownGold);
			writer.Write(this.unOwnGold);
			writer.Write(this.starEssense);
			writer.Write(this.constellationId);
			writer.Write(this.step);
			writer.Write(this.cycle);
			writer.Write(this.entryId);
			writer.Write(this.isSuccess);
			writer.Write(this.failPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownGold = reader.ReadInt64();
			this.unOwnGold = reader.ReadInt64();
			this.starEssense = reader.ReadInt64();
			this.constellationId = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.cycle = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.isSuccess = reader.ReadBoolean();
			this.failPoint = reader.ReadInt32();
		}

		public AcquireConstellationResponseBody()
		{
		}

		public long ownGold;

		public long unOwnGold;

		public long starEssense;

		public int constellationId;

		public int step;

		public int cycle;

		public int entryId;

		public bool isSuccess;

		public int failPoint;
	}
}
