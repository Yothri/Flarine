using System;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroBeginSkillEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attackerId);
			writer.Write(this.skillId);
			writer.Write(this.isAutoBattle);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attackerId = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
			this.isAutoBattle = reader.ReadBoolean();
		}

		public CEBHeroBeginSkillEventBody()
		{
		}

		public int attackerId;

		public int skillId;

		public bool isAutoBattle;
	}
}
