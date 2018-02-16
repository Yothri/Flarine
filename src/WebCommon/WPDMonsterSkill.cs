using System;

namespace WebCommon
{
	public class WPDMonsterSkill : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterSkillId);
			writer.Write(this.description);
			writer.Write(this.range);
			writer.Write(this.castRange);
			writer.Write(this.coolTime);
			writer.Write(this.skillType);
			writer.Write(this.anchorType);
			writer.Write(this.areaType);
			writer.Write(this.areaDistance);
			writer.Write(this.hitTarget);
			writer.Write(this.radius);
			writer.Write(this.angle);
			writer.Write(this.width);
			writer.Write(this.height);
			writer.Write(this.factor);
			writer.Write(this.duration);
			writer.Write(this.hitCount);
			writer.Write(this.hitDelay);
			writer.Write(this.projectileEffect);
			writer.Write(this.projectileRange);
			writer.Write(this.projectileSpeed);
			writer.Write(this.castEffect);
			writer.Write(this.skillEffect);
			writer.Write(this.hitEffect);
			writer.Write(this.hitEffectHeight);
			writer.Write(this.castSound);
			writer.Write(this.hitSound);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterSkillId = reader.ReadInt32();
			this.description = reader.ReadString();
			this.range = reader.ReadDouble();
			this.castRange = reader.ReadDouble();
			this.coolTime = reader.ReadDouble();
			this.skillType = reader.ReadInt32();
			this.anchorType = reader.ReadInt32();
			this.areaType = reader.ReadInt32();
			this.areaDistance = reader.ReadDouble();
			this.hitTarget = reader.ReadInt32();
			this.radius = reader.ReadDouble();
			this.angle = reader.ReadInt32();
			this.width = reader.ReadDouble();
			this.height = reader.ReadDouble();
			this.factor = reader.ReadDouble();
			this.duration = reader.ReadDouble();
			this.hitCount = reader.ReadInt32();
			this.hitDelay = reader.ReadDouble();
			this.projectileEffect = reader.ReadString();
			this.projectileRange = reader.ReadDouble();
			this.projectileSpeed = reader.ReadDouble();
			this.castEffect = reader.ReadString();
			this.skillEffect = reader.ReadString();
			this.hitEffect = reader.ReadString();
			this.hitEffectHeight = reader.ReadInt32();
			this.castSound = reader.ReadString();
			this.hitSound = reader.ReadString();
		}

		public WPDMonsterSkill()
		{
		}

		public int monsterSkillId;

		public string description;

		public double range;

		public double castRange;

		public double coolTime;

		public int skillType;

		public int anchorType;

		public int areaType;

		public double areaDistance;

		public int hitTarget;

		public double radius;

		public int angle;

		public double width;

		public double height;

		public double factor;

		public double duration;

		public int hitCount;

		public double hitDelay;

		public string projectileEffect;

		public double projectileRange;

		public double projectileSpeed;

		public string castEffect;

		public string skillEffect;

		public string hitEffect;

		public int hitEffectHeight;

		public string castSound;

		public string hitSound;
	}
}
