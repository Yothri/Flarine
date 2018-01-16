using System;
using System.IO;

namespace WebCommon
{
	public class WPDClientTexts : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.languageId);
			writer.Write(this.clientTexts);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.languageId = reader.ReadInt32();
			this.clientTexts = reader.ReadPDPacketDatas<WPDClientText>();
		}

		public string SerializeBase64String()
		{
			byte[] inArray;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				WPacketWriter writer = new WPacketWriter(memoryStream);
				this.Serialize(writer);
				inArray = memoryStream.ToArray();
			}
			return Convert.ToBase64String(inArray);
		}

		public void DeserializeFromBase64String(string sData)
		{
			byte[] buffer = Convert.FromBase64String(sData);
			using (MemoryStream memoryStream = new MemoryStream(buffer))
			{
				WPacketReader reader = new WPacketReader(memoryStream);
				this.Deserialize(reader);
			}
		}

		public WPDClientTexts()
		{
		}

		public int languageId;

		public WPDClientText[] clientTexts;
	}
}
