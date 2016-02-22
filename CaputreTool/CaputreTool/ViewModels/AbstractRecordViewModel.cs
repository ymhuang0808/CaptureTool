using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaputreTool.Models;

namespace CaputreTool.ViewModels
{
    abstract class AbstractRecordViewModel
    {
        public abstract ObservableCollection<Record> RecordItems { get; set; }
        public abstract ObservableCollection<Record> GetRecordItems(int number);
    }
}
