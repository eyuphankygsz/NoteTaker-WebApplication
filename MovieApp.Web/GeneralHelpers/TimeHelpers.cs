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
		public static string GetTimeAgo(DateTime date)
		{
			TimeSpan elapsedTime = DateTime.Now - date;

			if (elapsedTime < TimeSpan.FromHours(1))
				return elapsedTime.Minutes + "m";
			if (elapsedTime < TimeSpan.FromHours(24))
				return elapsedTime.Hours + "h";
			if (elapsedTime < TimeSpan.FromDays(7))
				return elapsedTime.Days + "d";
			if (elapsedTime < TimeSpan.FromDays(28))
				return elapsedTime.Days / 7 + "w";
			if (elapsedTime < TimeSpan.FromDays(356))
				return elapsedTime.Days / 28 + "mo";

			return elapsedTime.Days / 365 + "y";


		}
		public static string GetOnlyTime(DateTime date)
		{
			return date.ToString("HH:mm");
		}
	}
}
