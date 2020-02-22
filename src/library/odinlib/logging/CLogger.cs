﻿/*
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.If not, see<http://www.gnu.org/licenses/>.
*/

using OdinSdk.OdinLib.Configuration;
using System;

namespace OdinSdk.OdinLib.Logging
{
    /// <summary>
    /// 로그처리와 관련된 Server Library Class
    /// </summary>
    public class CLogger
    {
        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///
        /// </summary>
        public CLogger()
        {
        }

        //-----------------------------------------------------------------------------------------------------------------------------
        //
        //-----------------------------------------------------------------------------------------------------------------------------
        private static readonly Lazy<CLogger> m_lzyHelper = new Lazy<CLogger>(() =>
        {
            return new CLogger();
        });

        /// <summary>
        ///
        /// </summary>
        public static CLogger SNG
        {
            get
            {
                return m_lzyHelper.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///
        /// </summary>
        /// <param name="message">메시지</param>
        public void WriteLog(string message)
        {
            WriteLog("L", message);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="exception">예외(L,X,I,etc)</param>
        public void WriteLog(Exception exception)
        {
            if (exception.InnerException == null)
            {
                WriteLog("L", exception.Message);
                WriteLog("X", exception.ToString());
            }
            else
                WriteLog(exception.InnerException);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args">Add additional attributes for each exchange</param>
        public void WriteLog(string format, params object[] args)
        {
            WriteLog("L", String.Format(format, args));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message_type">예외(L,X,I,etc)</param>
        /// <param name="message">메시지</param>
        public void WriteLog(string message_type, string message)
        {
            var _log_msg = $"{CUnixTime.UtcNow:yyyy-MM-dd-HH:mm:ss} {message_type}, {message}";
            if (message_type == "X")
                WriteError(_log_msg);
            else
                WriteOut(_log_msg);
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///
        /// </summary>
        /// <param name="message">메시지</param>
        public void WriteDebug(string message)
        {
            WriteDebug("I", message);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="exception">예외(L,X,I,etc)</param>
        public void WriteDebug(Exception exception)
        {
            WriteDebug("L", exception.ToString());
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="exception">예외(L,X,I,etc)</param>
        /// <param name="message">메시지</param>
        public void WriteDebug(Exception exception, string message)
        {
            WriteDebug("L", String.Format("'{0}', {1}", message, exception.Message));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args">Add additional attributes for each exchange</param>
        public void WriteDebug(string format, params object[] args)
        {
            WriteDebug("I", String.Format(format, args));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message_type">예외(L,X,I,etc)</param>
        /// <param name="message">메시지</param>
        private void WriteDebug(string message_type, string message)
        {
            var _log_msg = $"{CUnixTime.UtcNow:yyyy-MM-dd-HH:mm:ss} {message_type}, {message}";
            if (message_type == "X")
                WriteError(_log_msg);
            else
                WriteOut(_log_msg);
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        public void WriteTrace(string message)
        {
            WriteDebug("X", message);
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="line_feed"></param>
        public void WriteOut(string message, bool line_feed = true)
        {
            if (line_feed == true)
                Console.Out.WriteLine(message);
            else
                Console.Out.Write(message);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="line_feed"></param>
        public void WriteError(string message, bool line_feed = true)
        {
            if (line_feed == true)
                Console.Error.WriteLine(message);
            else
                Console.Error.Write(message);
        }

        //-------------------------------------------------------------------------------------------------------------------------
        //
        //-------------------------------------------------------------------------------------------------------------------------
    }
}