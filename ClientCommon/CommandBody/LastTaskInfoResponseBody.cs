using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LastTaskInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.lastDate);
			writer.Write(this.lastTaskEntries);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.lastDate = reader.ReadDateTime();
			this.lastTaskEntries = reader.ReadPDPacketDatas<PDLastTaskEntry>();
		}

		public LastTaskInfoResponseBody()
		{
		}

		public DateTime lastDate;

		public PDLastTaskEntry[] lastTaskEntries;
	}
}
