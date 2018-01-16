using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroSimple : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.name);
			writer.Write(this.faceId);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.battlePower);
			writer.Write(this.locationId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.name = reader.ReadString();
			this.faceId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
		}

		public PDAccountHeroSimple()
		{
		}

		public int id;

		public string name;

		public int faceId;

		public int heroId;

		public int tradition;

		public int level;

		public int battlePower;

		public int locationId;
	}
}
