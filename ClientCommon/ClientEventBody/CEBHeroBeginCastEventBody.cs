using System;
using ClientCommon.PacketData;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroBeginCastEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attackerId);
			writer.Write(this.skillId);
			writer.Write(this.heroPosition);
			writer.Write(this.heroRotationY);
			writer.Write(this.targetPosition);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attackerId = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
			this.heroPosition = reader.ReadPDVector3();
			this.heroRotationY = reader.ReadSingle();
			this.targetPosition = reader.ReadPDVector3();
		}

		public CEBHeroBeginCastEventBody()
		{
		}

		public int attackerId;

		public int skillId;

		public PDVector3 heroPosition;

		public float heroRotationY;

		public PDVector3 targetPosition;
	}
}
