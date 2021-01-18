using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragDrop.Blazor
{
    public class DragDropService : IDraggable
    {
        private DataTransferSettings Settings = new DataTransferSettings();
        public void SetData(object data)
        {
            Settings.Data = data;
            Settings.HasCopy = false;
            Settings.DataSource = null;
            Settings.StateHasChanged = null;
            Settings.Me = true;
        }
        public void Clear()
        {
            Settings.Clear();
        }
        void IDraggable.StartDrag(DataTransferSettings settings) => Settings = settings;
        DataTransferSettings IDraggable.GetSettings() => Settings;
    }
}
