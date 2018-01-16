using System;

namespace ClientCommon.CommandBody
{
	public class SetStatCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.strengthToAdd);
			writer.Write(this.staminaToAdd);
			writer.Write(this.agilityToAdd);
			writer.Write(this.intelligenceToAdd);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.strengthToAdd = reader.ReadInt32();
			this.staminaToAdd = reader.ReadInt32();
			this.agilityToAdd = reader.ReadInt32();
			this.intelligenceToAdd = reader.ReadInt32();
		}

		public SetStatCommandBody()
		{
		}

		public int strengthToAdd;

		public int staminaToAdd;

		public int agilityToAdd;

		public int intelligenceToAdd;
	}
}
