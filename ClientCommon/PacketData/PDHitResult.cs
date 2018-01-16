using System;

namespace ClientCommon.PacketData
{
	public class PDHitResult : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attacker);
			writer.Write(this.skillId);
			writer.Write(this.skillLevel);
			writer.Write(this.isDodged);
			writer.Write(this.isCritical);
			writer.Write(this.isBlocked);
			writer.Write(this.damage);
			writer.Write(this.hpDamage);
			writer.Write(this.addedDamage);
			writer.Write(this.absorbedHP);
			writer.Write(this.reflectedDamage);
			writer.Write(this.abnormalStateInstanceId);
			writer.Write(this.abnormalStateId);
			writer.Write(this.removedAbnormalStateEffects);
			writer.Write(this.time);
			writer.Write(this.hitCount);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attacker = reader.ReadPDAttacker<PDAttacker>();
			this.skillId = reader.ReadInt32();
			this.skillLevel = reader.ReadInt32();
			this.isDodged = reader.ReadBoolean();
			this.isCritical = reader.ReadBoolean();
			this.isBlocked = reader.ReadBoolean();
			this.damage = reader.ReadInt32();
			this.hpDamage = reader.ReadInt32();
			this.addedDamage = reader.ReadInt32();
			this.absorbedHP = reader.ReadInt32();
			this.reflectedDamage = reader.ReadInt32();
			this.abnormalStateInstanceId = reader.ReadInt64();
			this.abnormalStateId = reader.ReadInt32();
			this.removedAbnormalStateEffects = reader.ReadLongs();
			this.time = reader.ReadDateTime();
			this.hitCount = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public PDHitResult()
		{
		}

		public PDAttacker attacker;

		public int skillId;

		public int skillLevel;

		public bool isDodged;

		public bool isCritical;

		public bool isBlocked;

		public int damage;

		public int hpDamage;

		public int addedDamage;

		public int absorbedHP;

		public int reflectedDamage;

		public long abnormalStateInstanceId;

		public int abnormalStateId;

		public long[] removedAbnormalStateEffects;

		public DateTime time;

		public int hitCount;

		public PDVector3 position;

		public float rotationY;
	}
}
