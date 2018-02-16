using System;

namespace ClientCommon
{
	public enum ChatType : byte
	{
		World = 1,
		Guild,
		Party,
		Whisper,
		Surroundings,
		Language = 7
	}
}
