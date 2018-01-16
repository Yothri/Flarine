using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ActualTrainingEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myAccountHero);
			writer.Write(this.date);
			writer.Write(this.turn);
			writer.Write(this.remainingTime);
			writer.Write(this.dia);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
			writer.Write(this.dropObjects);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.date = reader.ReadDateTime();
			this.turn = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
			this.dia = reader.ReadInt32();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDActualTrainingMonsterInstance>();
			this.dropObjects = reader.ReadPDPacketDatas<PDDropObject>();
		}

		public ActualTrainingEnterResponseBody()
		{
		}

		public PDAccountHero myAccountHero;

		public DateTime date;

		public int turn;

		public float remainingTime;

		public int dia;

		public PDAccountHero[] accountHeroes;

		public PDActualTrainingMonsterInstance[] monsters;

		public PDDropObject[] dropObjects;
	}
}
