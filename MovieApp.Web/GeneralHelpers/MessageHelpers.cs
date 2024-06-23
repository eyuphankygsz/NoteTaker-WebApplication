using MemoMate.Web.Models;
using System.Drawing;

namespace MemoMate.Web.GeneralHelpers
{
	public class MessageHelpers
	{
		public static MessageModel TryGetMessageModel()
		{
			return ErrorMessage;
		}
		public static void SetError(string message)
		{
			_postBack = true;
			_errorMessage = message;
		}
		public static void SetWarning(string message)
		{
			_postBack = true;
			_warningMessage = message;
		}
		public static void SetInfo(string message)
		{
			_postBack = true;
			_infoMessage = message;
		}



		private static string _errorMessage;
		private static string _warningMessage;
		private static string _infoMessage;
		private static MessageModel ErrorMessage
		{
			get
			{
				if (string.IsNullOrEmpty(_errorMessage)) return WarningMessage;
				string message = _errorMessage;
				_errorMessage = null;
				return GetMessageModel(message, "danger");
			}
		}


		private static MessageModel WarningMessage
		{
			get
			{
				if (string.IsNullOrEmpty(_warningMessage)) return InfoMessage;

				string message = _warningMessage;
				_warningMessage = null;
				return GetMessageModel(message, "warning");
			}
		}


		private static MessageModel InfoMessage
		{
			get
			{
				if (string.IsNullOrEmpty(_infoMessage)) return null;
				string message = _infoMessage;
				_infoMessage = null;
				return GetMessageModel(message, "info");
			}
		}

		private static bool _postBack;
		public static bool PostBack
		{
			get
			{
				bool postback = _postBack;
				_postBack = false;
				return postback;
			}
			set => _postBack = value;
		}

		private static MessageModel GetMessageModel(string message, string colorname)
		{
			MessageModel model = new MessageModel
			{
				ColorName = colorname,
				Message = message
			};
			return model;
		}
	}

}
