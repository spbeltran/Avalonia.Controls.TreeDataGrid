﻿using System.Collections.Generic;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    public abstract class ExpanderRowBase<TModel> : RowBase<TModel>
    {
        public abstract void Expand(IEnumerable<TModel> childModels);
        public abstract void Collapse();
    }
}
