#region License, Terms and Conditions
//
// Maticsoft - JSON and JSON-RPC for Microsoft .NET Framework and Mono
//
// Copyright (c) 2006-2012 Maticsoft. All Rights Reserved.
//
// This library is free software; you can redistribute it and/or modify it under
// the terms of the GNU Lesser General Public License as published by the Free
// Software Foundation; either version 3 of the License, or (at your option)
// any later version.
//
// This library is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
// details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation, Inc.,
// 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA 
//
#endregion

namespace MyAspx.Json.Conversion.Converters
{
    #region Imports

    using System;
    using System.Diagnostics;

    #endregion

    public sealed class GuidImporter : ImporterBase
    {
        public GuidImporter() : 
            base(typeof(Guid)) { }

        protected override object ImportFromString(ImportContext context, JsonReader reader)
        {
            Debug.Assert(context != null);
            Debug.Assert(reader != null);

            try
            {
                return ReadReturning(reader, new Guid(reader.Text.Trim()));
            }
            catch (FormatException e)
            {
                throw new JsonException(e.Message, e);
            }
        }
    }
}