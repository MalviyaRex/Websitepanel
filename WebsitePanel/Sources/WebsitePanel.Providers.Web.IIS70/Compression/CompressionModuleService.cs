﻿// Copyright (c) 2014, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using Microsoft.Web.Administration;
using Microsoft.Web.Management.Server;
using WebsitePanel.Providers.Web.Iis.Common;

namespace WebsitePanel.Providers.Web.Compression
{

    internal static class CompressionGlobals
    {
        public const int DynamicCompression = 1;
        public const int StaticCompression = 2;
    }


    internal sealed class CompressionModuleService : ConfigurationModuleService
    {
        public const string DynamicCompression = "doDynamicCompression";
        public const string StaticCompression = "doStaticCompression";

        public PropertyBag GetSettings(ServerManager srvman, string siteId)
        {
            var config = srvman.GetApplicationHostConfiguration();
            //
            var section = config.GetSection(Constants.CompressionSection, siteId);
            //
            PropertyBag bag = new PropertyBag();
            //
            bag[CompressionGlobals.DynamicCompression] = Convert.ToBoolean(section.GetAttributeValue(DynamicCompression));
            bag[CompressionGlobals.StaticCompression] = Convert.ToBoolean(section.GetAttributeValue(StaticCompression));
            //
            return bag;
        }

        public void SetSettings(string virtualPath, bool doDynamicCompression, bool doStaticCompression)
        {
            using (var srvman = GetServerManager())
            {
                var config = srvman.GetApplicationHostConfiguration();
                //
                var section = config.GetSection(Constants.CompressionSection, virtualPath);
                //
                section.SetAttributeValue(DynamicCompression, doDynamicCompression);
                section.SetAttributeValue(StaticCompression, doStaticCompression);

                //
                srvman.CommitChanges();
            }
        }

      
    }
}