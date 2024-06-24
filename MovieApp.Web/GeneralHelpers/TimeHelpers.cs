using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System;

namespace MemoMate.Web.GeneralHelpers
{
	public class TimeHelpers
	{
		public static DateTime GetLocalDate()
		{
			return DateTime.Now;
		}
	}
}
