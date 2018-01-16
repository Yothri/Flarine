using System;

namespace ClientCommon.CommandBody
{
	public class EquipSkillCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.skillSlotId);
			writer.Write(this.skillId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.skillSlotId = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
		}

		public EquipSkillCommandBody()
		{
		}

		public int skillSlotId;

		public int skillId;
	}
}
