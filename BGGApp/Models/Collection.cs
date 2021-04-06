using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGGApp.Models
{


    public class CollectionRoot
    {
        public Items items { get; set; }
    }

    public class Items
    {
        public _Attributes _attributes { get; set; }
        public List<Item> item { get; set; }
    }

    public class _Attributes
    {
        public string totalitems { get; set; }
        public string termsofuse { get; set; }
        public string pubdate { get; set; }
    }

    public class Item
    {
        public _Attributes1 _attributes { get; set; }
        public Name name { get; set; }
        public Yearpublished yearpublished { get; set; }
        public Image image { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Status status { get; set; }
        public Numplays numplays { get; set; }
    }

    public class _Attributes1
    {
        public string objecttype { get; set; }
        public string objectid { get; set; }
        public string subtype { get; set; }
        public string collid { get; set; }
    }

    public class Name
    {
        public _Attributes2 _attributes { get; set; }
        public string _text { get; set; }
    }

    public class _Attributes2
    {
        public string sortindex { get; set; }
    }

    public class Yearpublished
    {
        public string _text { get; set; }
    }

    public class Image
    {
        public string _text { get; set; }
    }

    public class Thumbnail
    {
        public string _text { get; set; }
    }

    public class Status
    {
        public _Attributes3 _attributes { get; set; }
    }

    public class _Attributes3
    {
        public string own { get; set; }
        public string prevowned { get; set; }
        public string fortrade { get; set; }
        public string want { get; set; }
        public string wanttoplay { get; set; }
        public string wanttobuy { get; set; }
        public string wishlist { get; set; }
        public string preordered { get; set; }
        public DateTime lastmodified { get; set; }
    }

    public class Numplays
    {
        public string _text { get; set; }
    }


}
