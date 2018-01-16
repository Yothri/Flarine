using System;

namespace ClientCommon.PacketData
{
	public class PDGearInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.grade);
			writer.Write(this.owned);
			writer.Write(this.enchantLevel);
			writer.Write(this.elemental);
			writer.Write(this.elementalLevel);
			writer.Write(this.socketCount);
			writer.Write(this.attributes);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.enchantLevel = reader.ReadInt32();
			this.elemental = reader.ReadInt32();
			this.elementalLevel = reader.ReadInt32();
			this.socketCount = reader.ReadInt32();
			this.attributes = reader.ReadPDPacketDatas<PDGearInstanceAttribute>();
		}

		public PDGearInstance()
		{
		}

		public int id;

		public int grade;

		public bool owned;

		public int enchantLevel;

		public int elemental;

		public int elementalLevel;

		public int socketCount;

		public PDGearInstanceAttribute[] attributes;
	}
}
