using System;
using System.IO;
using System.Xml.Serialization;

namespace ClientCommon
{
	public static class XmlUtil
	{
		public static string XmlSerialize(Type type, object target)
		{
			StringWriter stringWriter = new StringWriter();
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			xmlSerializer.Serialize(stringWriter, target);
			return stringWriter.ToString();
		}

		public static string XmlSerialize<T>(object target)
		{
			return XmlUtil.XmlSerialize(typeof(T), target);
		}

		public static object XmlDeserialize(Type type, string sData)
		{
			StringReader textReader = new StringReader(sData);
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			return xmlSerializer.Deserialize(textReader);
		}

		public static T XmlDeserialize<T>(string sData)
		{
			return (T)((object)XmlUtil.XmlDeserialize(typeof(T), sData));
		}
	}
}
