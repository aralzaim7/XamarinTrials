using System.Collections.ObjectModel;

namespace App3.Model
{
    public class PhoneBook
    {
        //        private readonly IEnumerable<Grouping<string, PhoneBook>> OrderBy;

        public string email { get; set; }
        public string userId { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string officeLocation { get; set; }
        public string position { get; set; }
        public string officeTel { get; set; }
        public string title { get; set; }
        public string unit { get; set; }
        public string body { get; set; }
        public string FirstLastName { get { return name + " " + surname; } }

        public PhoneBook() { }

    }

    //   public static IList<PhoneBook> PhoneNoGroups { set; get; }

    //   public static IList<PhoneBook> PhoneWithGroups { get; set; }

    //    public static ObservableCollection<Grouping<string, PhoneBook>>
    //        BindingWithGrouping()
    //    {
    //       var result = phon;
    //
    //        var list = new ObservableCollection<Grouping<string, PhoneBook>>
    //           (result.OrderBy(c => c.FirstLastName))
    //
    //           return list;
    //        }

    public class GrouppedPhoneBookModel : ObservableCollection<PhoneBook>
    {

    }

}

