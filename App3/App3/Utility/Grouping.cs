using App3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Text;
using System.Threading.Tasks;

namespace App1.Utility
{
    public class Grouping<K, T> : ObservableCollection<T>
    {

        public K Key { get; set; }
        public Grouping(K key, IEnumerable<T> phonebooks)
        {
            Key = key;

            foreach (var phonebook in phonebooks)
            {
                this.Items.Add(phonebook);
            }
        }
    }
}
