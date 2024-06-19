using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System;

namespace MemoMate.Web.GeneralHelpers
{
	public class TimeHelpers
	{
		public static DateTime GetCurrentDate()
		{
			var client = new TcpClient("time.nist.gov", 13);
			using (var streamReader = new StreamReader(client.GetStream()))
			{
				var response = streamReader.ReadToEnd();
				var utcDateTimeString = response.Substring(7, 17);
				var localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
				return localDateTime;
			}
		}
	}
}
