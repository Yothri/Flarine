using System;

namespace WebCommon
{
	public class WPDContinent : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.continentType);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.enterRequiredMainChapterId);
			writer.Write(this.locationId);
			writer.Write(this.minLevel);
			writer.Write(this.maxLevel);
			writer.Write(this.bossMonsterId);
			writer.Write(this.spawnXPosition);
			writer.Write(this.spawnYPosition);
			writer.Write(this.spawnZPosition);
			writer.Write(this.bossMoveRadius);
			writer.Write(this.recommendPower);
			writer.Write(this.bossTargetingInterval);
			writer.Write(this.pkEnabled);
			writer.Write(this.essenceExchangeResetUnOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.continentType = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.enterRequiredMainChapterId = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
			this.minLevel = reader.ReadInt32();
			this.maxLevel = reader.ReadInt32();
			this.bossMonsterId = reader.ReadInt32();
			this.spawnXPosition = reader.ReadDouble();
			this.spawnYPosition = reader.ReadDouble();
			this.spawnZPosition = reader.ReadDouble();
			this.bossMoveRadius = reader.ReadDouble();
			this.recommendPower = reader.ReadInt32();
			this.bossTargetingInterval = reader.ReadInt32();
			this.pkEnabled = reader.ReadBoolean();
			this.essenceExchangeResetUnOwnDia = reader.ReadInt32();
		}

		public WPDContinent()
		{
		}

		public int continentId;

		public int continentType;

		public string name;

		public string nameKey;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public int enterRequiredMainChapterId;

		public int locationId;

		public int minLevel;

		public int maxLevel;

		public int bossMonsterId;

		public double spawnXPosition;

		public double spawnYPosition;

		public double spawnZPosition;

		public double bossMoveRadius;

		public int recommendPower;

		public int bossTargetingInterval;

		public bool pkEnabled;

		public int essenceExchangeResetUnOwnDia;
	}
}
