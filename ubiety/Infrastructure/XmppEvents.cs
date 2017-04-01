﻿// XmppEvents.cs
//
//Ubiety XMPP Library Copyright (C) 2015 Dieter Lunn
//
//This library is free software; you can redistribute it and/or modify it under
//the terms of the GNU Lesser General Public License as published by the Free
//Software Foundation; either version 3 of the License, or (at your option)
//any later version.
//
//This library is distributed in the hope that it will be useful, but WITHOUT
//ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
//
//You should have received a copy of the GNU Lesser General Public License along
//with this library; if not, write to the Free Software Foundation, Inc., 59
//Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using Ubiety.Common;

namespace Ubiety.Infrastructure
{
    /// <summary>
    /// </summary>
    public class TagEventArgs : EventArgs
    {
        /// <summary>
        /// </summary>
        /// <param name="tag"></param>
        public TagEventArgs(Tag tag)
        {
            Tag = tag;
        }

        /// <summary>
        /// </summary>
        public Tag Tag { get; }
    }

    /// <summary>
    /// </summary>
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="severity"></param>
        public ErrorEventArgs(string message, ErrorType type, ErrorSeverity severity)
        {
            Message = message;
            Type = type;
            Severity = severity;
        }

        /// <value>
        ///     The default error message.
        /// </value>
        public string Message { get; }

        /// <value>
        ///     The type of error that is being returned.
        /// </value>
        public ErrorType Type { get; }

        /// <summary>
        /// </summary>
        public ErrorSeverity Severity { get; }
    }

    /// <summary>
    /// </summary>
    public class XmppEvents
    {
        #region Internal Connect

        /// <summary>
        /// </summary>
        public event EventHandler<EventArgs> Connect;

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnConnect(object sender, EventArgs args = default (EventArgs))
        {
            Connect?.Invoke(sender, args);
        }

        #endregion

        #region Internal Disconnect

        /// <summary>
        /// </summary>
        public event EventHandler<EventArgs> Disconnect;

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDisconnect(object sender, EventArgs args = default (EventArgs))
        {
            Disconnect?.Invoke(sender, args);
        }

        #endregion

        #region Internal Send

        /// <summary>
        /// </summary>
        public event EventHandler<TagEventArgs> Send;

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSend(object sender, TagEventArgs args)
        {
            Send?.Invoke(sender, args);
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tag"></param>
        public void OnSend(object sender, Tag tag)
        {
            OnSend(sender, new TagEventArgs(tag));
        }

        #endregion

        #region New Tag

        /// <summary>
        /// </summary>
        public event EventHandler<TagEventArgs> NewTag;

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnNewTag(object sender, TagEventArgs args)
        {
            NewTag?.Invoke(sender, args);
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tag"></param>
        public void OnNewTag(object sender, Tag tag)
        {
            OnNewTag(sender, new TagEventArgs(tag));
        }

        #endregion

        /// <summary>
        /// </summary>
        public event EventHandler<ErrorEventArgs> Error;

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnError(object sender, ErrorEventArgs args)
        {
            Error?.Invoke(sender, args);
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="type"></param>
        /// <param name="severity"></param>
        /// <param name="message"></param>
        public void OnError(object sender, ErrorType type, ErrorSeverity severity, string message)
        {
            OnError(sender, new ErrorEventArgs(message, type, severity));
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="type"></param>
        /// <param name="severity"></param>
        /// <param name="message"></param>
        /// <param name="parameters"></param>
        public void OnError(object sender, ErrorType type, ErrorSeverity severity, String message, params object[] parameters)
        {
            OnError(sender, type, severity, String.Format(message, parameters));
        }
    }
}