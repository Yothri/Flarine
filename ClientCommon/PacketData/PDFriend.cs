using System;

namespace ClientCommon.PacketData
{
	public class PDFriend : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.type);
			writer.Write(this.regTime);
			writer.Write(this.name);
			writer.Write(this.tradition);
			writer.Write(this.heroId);
			writer.Write(this.faceId);
			writer.Write(this.level);
			writer.Write(this.battlePower);
			writer.Write(this.isOnline);
			writer.Write(this.locationId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.regTime = reader.ReadDateTime();
			this.name = reader.ReadString();
			this.tradition = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.faceId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.isOnline = reader.ReadBoolean();
			this.locationId = reader.ReadInt32();
		}

		public PDFriend()
		{
		}

		public int accountHeroId;

		public int type;

		public DateTime regTime;

		public string name;

		public int tradition;

		public int heroId;

		public int faceId;

		public int level;

		public int battlePower;

		public bool isOnline;

		public int locationId;
	}
}
