using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
namespace DataModel
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : class
    {
        private IBindingList _bindingList;
        bool IListSource.ContainsListCollection { get { return false; } }
        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
