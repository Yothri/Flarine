using System;

namespace ClientCommon.PacketData
{
	public class PDPartyDungeonListItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
			writer.Write(this.requiredBattlePower);
			writer.Write(this.memberCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
			this.requiredBattlePower = reader.ReadInt32();
			this.memberCount = reader.ReadInt32();
		}

		public PDPartyDungeonListItem()
		{
		}

		public long instanceId;

		public int masterId;

		public string masterName;

		public int requiredBattlePower;

		public int memberCount;
	}
}
