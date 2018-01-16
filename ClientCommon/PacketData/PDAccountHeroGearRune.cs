using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroGearRune : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.value = reader.ReadSingle();
		}

		public PDAccountHeroGearRune()
		{
		}

		public int id;

		public float value;
	}
}
