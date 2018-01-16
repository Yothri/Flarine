using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroBeginCastEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.mp);
			writer.Write(this.skillId);
			writer.Write(this.skillDegree);
			writer.Write(this.heroPosition);
			writer.Write(this.heroRotationY);
			writer.Write(this.targetPosition);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.mp = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
			this.skillDegree = reader.ReadInt32();
			this.heroPosition = reader.ReadPDVector3();
			this.heroRotationY = reader.ReadSingle();
			this.targetPosition = reader.ReadPDVector3();
		}

		public SEBHeroBeginCastEventBody()
		{
		}

		public int accountHeroId;

		public int mp;

		public int skillId;

		public int skillDegree;

		public PDVector3 heroPosition;

		public float heroRotationY;

		public PDVector3 targetPosition;
	}
}
