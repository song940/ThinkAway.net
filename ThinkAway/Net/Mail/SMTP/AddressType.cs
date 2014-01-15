/******************************************************************************
    Copyright 2001-2005 Ian Stallings
    OpenSmtp.Net is free software; you can redistribute it and/or modify
    it under the terms of the Lesser GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    OpenSmtp.Net is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    Lesser GNU General Public License for more details.

    You should have received a copy of the Lesser GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
/*******************************************************************************/
namespace ThinkAway.Net.Mail.SMTP
{
    /// <summary>This enumeration stores the Address type</summary>
    /// <example>
    /// <code>
    /// msg.AddRecipient(ccAddress, AddressType.Cc);
    /// msg.AddRecipient(bccAddress, AddressType.Bcc);
    /// </code>
    /// </example>
    public enum AddressType
    {
        To = 1,
        Cc = 2,
        Bcc = 3
    }
}