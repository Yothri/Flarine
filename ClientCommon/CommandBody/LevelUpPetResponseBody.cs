using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpPetResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heart);
			writer.Write(this.level);
			writer.Write(this.owned);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.heart = reader.ReadInt64();
			this.level = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
		}

		public LevelUpPetResponseBody()
		{
		}

		public long heart;

		public int level;

		public bool owned;
	}
}
