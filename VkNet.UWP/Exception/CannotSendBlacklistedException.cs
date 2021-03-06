﻿using System.Runtime.Serialization;
using VkNet.Utils;

namespace VkNet.Exception
{
    /// <summary>
    /// Исключение, которое выбрасывается при попытке отправить сообщение пользователю, находясь в его черном списке.
	/// Код ошибки - 900
	/// </summary>
    [DataContract]
    public class CannotSendBlacklistedException : VkApiMethodInvokeException
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса CannotSendBlacklistedException
        /// </summary>
        public CannotSendBlacklistedException()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CannotSendBlacklistedException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        public CannotSendBlacklistedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CannotSendBlacklistedException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        /// <param name="innerException">Внутреннее исключение.</param>
        public CannotSendBlacklistedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CannotSendBlacklistedException
        /// </summary>
        /// <param name="message">Описание исключения.</param>
        /// <param name="code">Код ошибки, полученный от сервера ВКонтакте.</param>
        public CannotSendBlacklistedException(string message, int code) : base(message, code)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса VkApiException
        /// </summary>
        /// <param name="response">Ответ от сервера vk</param>
        public CannotSendBlacklistedException(VkResponse response) : base(response["error_msg"])
        {
            ErrorCode = response["error_code"];
        }
    }
}