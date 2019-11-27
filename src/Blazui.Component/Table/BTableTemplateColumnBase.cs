﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component.Table
{
    public class BTableTemplateColumnBase<TRow> : BTableColumn<TRow>
    {
        [Parameter]
        public override RenderFragment<TRow> ChildContent { get; set; }
    }
}