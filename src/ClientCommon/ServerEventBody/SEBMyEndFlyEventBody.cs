using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMyEndFlyEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.addedAccountHeroes);
			writer.Write(this.addedMonsters);
			writer.Write(this.addedDropObjects);
			writer.Write(this.removedAccountHeroes);
			writer.Write(this.removedMonsters);
			writer.Write(this.removedDropObjects);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.addedAccountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.addedMonsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.addedDropObjects = reader.ReadPDPacketDatas<PDDropObject>();
			this.removedAccountHeroes = reader.ReadInts();
			this.removedMonsters = reader.ReadLongs();
			this.removedDropObjects = reader.ReadLongs();
		}

		public SEBMyEndFlyEventBody()
		{
		}

		public PDVector3 position;

		public float rotationY;

		public PDAccountHero[] addedAccountHeroes;

		public PDMonsterInstance[] addedMonsters;

		public PDDropObject[] addedDropObjects;

		public int[] removedAccountHeroes;

		public long[] removedMonsters;

		public long[] removedDropObjects;
	}
}
