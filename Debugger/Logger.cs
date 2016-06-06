/*
 * 사용자: philly
 * 날짜: 2016-06-06
 * 시간: 오후 8:08
 */
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace PHL.Debugger
{
	public class Logger
	{
		private Assembly _assembly;
		
		public Logger(Assembly assembly)
		{
			this._assembly = assembly;
		}
		
		public void Save(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				BinaryFormatter bf =new BinaryFormatter();
				bf.Serialize(fs, _assembly);
			}
		}
		
		public static Assembly Open(string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open))
			{
				BinaryFormatter bf = new BinaryFormatter();
				return (Assembly)bf.Deserialize(fs);
			}
		}
	}
}
