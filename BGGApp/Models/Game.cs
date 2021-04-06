using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGGApp.Models
{


    public class GameRoot
    {
        public Games games { get; set; }
    }

    public class Games
    {
        public Attributes attributes { get; set; }
        public Game game { get; set; }
    }

    public class Attributes
    {
        public string termsofuse { get; set; }
    }

    public class Game
    {
        public Attributes1 attributes { get; set; }
        public Thumbnail1 thumbnail1 { get; set; }
        public Image1 image { get; set; }
        public Name1 name1 { get; set; }
        public Description description { get; set; }
        public Yearpublished1 yearpublished1 { get; set; }
        public Minplayers minplayers { get; set; }
        public Maxplayers maxplayers { get; set; }
        public List<Poll> poll { get; set; }
        public Playingtime playingtime { get; set; }
        public Minplaytime minplaytime { get; set; }
        public Maxplaytime maxplaytime { get; set; }
        public Minage minage { get; set; }
        public List<Link> link { get; set; }
    }

    public class Attributes1
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class Thumbnail1
    {
        public string _text { get; set; }
    }

    public class Image1
    {
        public string _text { get; set; }
    }

    public class Name1
    {
        public Attributes2 attributes { get; set; }
    }

    public class Attributes2
    {
        public string type { get; set; }
        public string sortindex { get; set; }
        public string value { get; set; }
    }

    public class Description
    {
        public string _text { get; set; }
    }

    public class Yearpublished1
    {
        public Attributes3 attributes { get; set; }
    }

    public class Attributes3
    {
        public string value { get; set; }
    }

    public class Minplayers
    {
        public _Attributes4 _attributes { get; set; }
    }

    public class _Attributes4
    {
        public string value { get; set; }
    }

    public class Maxplayers
    {
        public _Attributes5 _attributes { get; set; }
    }

    public class _Attributes5
    {
        public string value { get; set; }
    }

    public class Playingtime
    {
        public _Attributes6 _attributes { get; set; }
    }

    public class _Attributes6
    {
        public string value { get; set; }
    }

    public class Minplaytime
    {
        public _Attributes7 _attributes { get; set; }
    }

    public class _Attributes7
    {
        public string value { get; set; }
    }

    public class Maxplaytime
    {
        public _Attributes8 _attributes { get; set; }
    }

    public class _Attributes8
    {
        public string value { get; set; }
    }

    public class Minage
    {
        public _Attributes9 _attributes { get; set; }
    }

    public class _Attributes9
    {
        public string value { get; set; }
    }

    public class Poll
    {
        public _Attributes10 _attributes { get; set; }
        public Results results { get; set; }
    }

    public class _Attributes10
    {
        public string name { get; set; }
        public string title { get; set; }
        public string totalvotes { get; set; }
    }

    public class Results
    {
        public _Attributes11 _attributes { get; set; }
    }

    public class _Attributes11
    {
        public string numplayers { get; set; }
    }

    public class Link
    {
        public _Attributes12 _attributes { get; set; }
    }

    public class _Attributes12
    {
        public string type { get; set; }
        public string id { get; set; }
        public string value { get; set; }
        public string inbound { get; set; }
    }


}
