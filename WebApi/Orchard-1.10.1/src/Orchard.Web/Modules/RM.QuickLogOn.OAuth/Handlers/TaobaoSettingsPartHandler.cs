﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Environment.Extensions;
using Orchard.Localization;
using RM.QuickLogOn.OAuth.Models;

namespace RM.QuickLogOn.OAuth.Handlers
{
    [OrchardFeature("RM.QuickLogOn.OAuth.Taobao")]
    public class TaobaoSettingsPartHandler : ContentHandler
    {
        public Localizer T { get; set; }

        public TaobaoSettingsPartHandler(IRepository<TaobaoSettingsPartRecord> repository)
        {
            Filters.Add(new ActivatingFilter<TaobaoSettingsPart>("Site"));
            Filters.Add(StorageFilter.For(repository));
            T = NullLocalizer.Instance;
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("QuickLogOn")) { Id = "QuickLogOn" });
        }
    }
}
