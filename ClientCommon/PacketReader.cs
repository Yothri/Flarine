using System;
using System.IO;
using System.Text;
using ClientCommon.PacketData;

namespace ClientCommon
{
	public class PacketReader : BinReader
	{
		public PacketReader(Stream output) : base(output)
		{
		}

		public PacketReader(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public PDVector3 ReadPDVector3()
		{
			return new PDVector3
			{
				x = this.ReadSingle(),
				y = this.ReadSingle(),
				z = this.ReadSingle()
			};
		}

		public T ReadPDPacketData<T>() where T : PDPacketData
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = Activator.CreateInstance<T>();
			result.Deserialize(this);
			return result;
		}

		public T ReadPDMonsterInstance<T>() where T : PDMonsterInstance
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = (T)((object)PDMonsterInstance.Create(this.ReadInt32()));
			result.Deserialize(this);
			return result;
		}

		public T ReadPDReward<T>() where T : PDReward
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = (T)((object)PDReward.Create(this.ReadInt32()));
			result.Deserialize(this);
			return result;
		}

		public T ReadPDKiller<T>() where T : PDKiller
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = (T)((object)PDKiller.Create(this.ReadInt32()));
			result.Deserialize(this);
			return result;
		}

		public T ReadPDAttacker<T>() where T : PDAttacker
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = (T)((object)PDAttacker.Create(this.ReadInt32()));
			result.Deserialize(this);
			return result;
		}

		public T ReadPDHitTarget<T>() where T : PDHitTarget
		{
			if (!this.ReadBoolean())
			{
				return default(T);
			}
			T result = (T)((object)PDHitTarget.Create(this.ReadInt32()));
			result.Deserialize(this);
			return result;
		}

		public T[] ReadPDPacketDatas<T>(int nMaxLength) where T : PDPacketData
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDPacketData<T>();
			}
			return array;
		}

		public T[] ReadPDPacketDatas<T>() where T : PDPacketData
		{
			return this.ReadPDPacketDatas<T>(32767);
		}

		public T[] ReadPDMonsterInstances<T>(int nMaxLength) where T : PDMonsterInstance
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDMonsterInstance<T>();
			}
			return array;
		}

		public T[] ReadPDMonsterInstances<T>() where T : PDMonsterInstance
		{
			return this.ReadPDMonsterInstances<T>(32767);
		}

		public T[] ReadPDRewards<T>(int nMaxLength) where T : PDReward
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDReward<T>();
			}
			return array;
		}

		public T[] ReadPDRewards<T>() where T : PDReward
		{
			return this.ReadPDRewards<T>(32767);
		}

		public T[] ReadPDKillers<T>(int nMaxLength) where T : PDKiller
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDKiller<T>();
			}
			return array;
		}

		public T[] ReadPDKillers<T>() where T : PDKiller
		{
			return this.ReadPDKillers<T>(32767);
		}

		public T[] ReadPDAttackers<T>(int nMaxLength) where T : PDAttacker
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDAttacker<T>();
			}
			return array;
		}

		public T[] ReadPDAttackers<T>() where T : PDAttacker
		{
			return this.ReadPDAttackers<T>(32767);
		}

		public T[] ReadPDHitTargets<T>(int nMaxLength) where T : PDHitTarget
		{
			if (!this.ReadBoolean())
			{
				return null;
			}
			int num = this.ReadInt32();
			if (num < 0 || num > nMaxLength)
			{
				throw new Exception(string.Concat(new object[]
				{
					"배열크기가 유효하지 않습니다. nMaxLength = ",
					nMaxLength,
					", nCount = ",
					num
				}));
			}
			T[] array = new T[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.ReadPDHitTarget<T>();
			}
			return array;
		}

		public T[] ReadPDHitTargets<T>() where T : PDHitTarget
		{
			return this.ReadPDHitTargets<T>(32767);
		}
	}
}
