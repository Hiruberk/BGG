using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BGGApp.Models
{

	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Items));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Items)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "name")]
	public class Name
	{

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "sortindex")]
		public int Sortindex { get; set; }

		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "yearpublished")]
	public class Yearpublished
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "minplayers")]
	public class Minplayers
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "maxplayers")]
	public class Maxplayers
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "results")]
	public class Results
	{

		[XmlAttribute(AttributeName = "numplayers")]
		public string Numplayers { get; set; }
	}

	[XmlRoot(ElementName = "poll")]
	public class Poll
	{

		[XmlElement(ElementName = "results")]
		public Results Results { get; set; }

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }

		[XmlAttribute(AttributeName = "totalvotes")]
		public int Totalvotes { get; set; }
	}

	[XmlRoot(ElementName = "playingtime")]
	public class Playingtime
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "minplaytime")]
	public class Minplaytime
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "maxplaytime")]
	public class Maxplaytime
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "minage")]
	public class Minage
	{

		[XmlAttribute(AttributeName = "value")]
		public int Value { get; set; }
	}

	[XmlRoot(ElementName = "link")]
	public class Link
	{

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public int Id { get; set; }

		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }

		[XmlAttribute(AttributeName = "inbound")]
		public bool Inbound { get; set; }
	}

	[XmlRoot(ElementName = "item")]
	public class Item
	{

		[XmlElement(ElementName = "thumbnail")]
		public string Thumbnail { get; set; }

		[XmlElement(ElementName = "image")]
		public string Image { get; set; }

		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "yearpublished")]
		public Yearpublished Yearpublished { get; set; }

		[XmlElement(ElementName = "minplayers")]
		public Minplayers Minplayers { get; set; }

		[XmlElement(ElementName = "maxplayers")]
		public Maxplayers Maxplayers { get; set; }

		[XmlElement(ElementName = "poll")]
		public List<Poll> Poll { get; set; }

		[XmlElement(ElementName = "playingtime")]
		public Playingtime Playingtime { get; set; }

		[XmlElement(ElementName = "minplaytime")]
		public Minplaytime Minplaytime { get; set; }

		[XmlElement(ElementName = "maxplaytime")]
		public Maxplaytime Maxplaytime { get; set; }

		[XmlElement(ElementName = "minage")]
		public Minage Minage { get; set; }

		[XmlElement(ElementName = "link")]
		public List<Link> Link { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public int Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Gameroot")]
	public class GameRoot
	{

		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }

		[XmlAttribute(AttributeName = "termsofuse")]
		public string Termsofuse { get; set; }

		[XmlText]
		public string Text { get; set; }
	}


}
