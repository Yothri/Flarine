using System;

namespace WebCommon
{
	public class WPDHeroSkill : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroSkillId);
			writer.Write(this.heroId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.range);
			writer.Write(this.castRange);
			writer.Write(this.mp);
			writer.Write(this.mpPerLevel);
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
			writer.Write(this.factorPerLevel);
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
			writer.Write(this.damaged);
			writer.Write(this.abnormalStateId);
			writer.Write(this.as_type);
			writer.Write(this.as_isCasterOverlap);
			writer.Write(this.as_isOtherOverlap);
			writer.Write(this.as_buffType);
			writer.Write(this.as_factor);
			writer.Write(this.as_factorPerLevel);
			writer.Write(this.as_duration);
			writer.Write(this.as_hitCount);
			writer.Write(this.as_effect);
			writer.Write(this.as_effectHeight);
			writer.Write(this.as_resetEnabled);
			writer.Write(this.as_sound);
			writer.Write(this.as_value1);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroSkillId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.requiredHeroLevel = reader.ReadInt32();
			this.range = reader.ReadDouble();
			this.castRange = reader.ReadDouble();
			this.mp = reader.ReadInt32();
			this.mpPerLevel = reader.ReadInt32();
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
			this.factorPerLevel = reader.ReadDouble();
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
			this.damaged = reader.ReadBoolean();
			this.abnormalStateId = reader.ReadInt32();
			this.as_type = reader.ReadInt32();
			this.as_isCasterOverlap = reader.ReadBoolean();
			this.as_isOtherOverlap = reader.ReadBoolean();
			this.as_buffType = reader.ReadInt32();
			this.as_factor = reader.ReadDouble();
			this.as_factorPerLevel = reader.ReadDouble();
			this.as_duration = reader.ReadDouble();
			this.as_hitCount = reader.ReadInt32();
			this.as_effect = reader.ReadString();
			this.as_effectHeight = reader.ReadInt32();
			this.as_resetEnabled = reader.ReadBoolean();
			this.as_sound = reader.ReadString();
			this.as_value1 = reader.ReadDouble();
		}

		public WPDHeroSkill()
		{
		}

		public int heroSkillId;

		public int heroId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int requiredHeroLevel;

		public double range;

		public double castRange;

		public int mp;

		public int mpPerLevel;

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

		public double factorPerLevel;

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

		public bool damaged;

		public int abnormalStateId;

		public int as_type;

		public bool as_isCasterOverlap;

		public bool as_isOtherOverlap;

		public int as_buffType;

		public double as_factor;

		public double as_factorPerLevel;

		public double as_duration;

		public int as_hitCount;

		public string as_effect;

		public int as_effectHeight;

		public bool as_resetEnabled;

		public string as_sound;

		public double as_value1;
	}
}
