using System;
using System.IO;
using System.Text;

namespace WebCommon
{
	public class WPacketReader : WBinReader
	{
		public WPacketReader(Stream output) : base(output)
		{
		}

		public WPacketReader(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public T ReadPDPacketData<T>() where T : WPDPacketData
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = Activator.CreateInstance<T>();
			result.Deserialize(this);
			return result;
		}

		public T[] ReadPDPacketDatas<T>() where T : WPDPacketData
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDPacketData<T>();
			}
			return array;
		}
	}
}
