using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpSkillCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetSkillId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetSkillId = reader.ReadInt32();
		}

		public LevelUpSkillCommandBody()
		{
		}

		public int targetSkillId;
	}
}
