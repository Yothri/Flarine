using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGearSkillDegreeChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.skillDegree);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadGuid();
			this.skillDegree = reader.ReadInt32();
		}

		public SEBGearSkillDegreeChangedEventBody()
		{
		}

		public Guid gearId;

		public int skillDegree;
	}
}
