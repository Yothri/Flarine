using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroSkillDegreeChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.skillId);
			writer.Write(this.skillDegree);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.skillId = reader.ReadInt32();
			this.skillDegree = reader.ReadInt32();
		}

		public SEBHeroSkillDegreeChangedEventBody()
		{
		}

		public int skillId;

		public int skillDegree;
	}
}
