using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace BGGApp.Models
{
    public class BGGDAL
    {
        public string GetCollectionData(string username)
        {
            string url = $"https://api.geekdo.com/xmlapi2/collection?username={username}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string xml = rd.ReadToEnd();

            return xml;
        }

        public items GetCollection(string username)
        {
            string xml = GetCollectionData(username);
            items i = DeserializeToObject<items>(xml);


            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(xml);

            //string json = JsonConvert.SerializeXmlNode(doc);
            //json = json.Replace("@", "");
            //json = json.Remove(0, json.IndexOf('{'));
            //CollectionRoot i = JsonConvert.DeserializeObject<CollectionRoot>(json);
            return i;
        }

        public T DeserializeToObject<T>(string filepath) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StreamReader sr = new StreamReader(filepath))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string GetGameData(string id)
        {
            string url = $"https://api.geekdo.com/xmlapi2/thing?id={id}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string xml = rd.ReadToEnd();

            return xml;
        }

        public GameRoot GetGame(string id)
        {
            string xml = GetCollectionData(id);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);
            GameRoot i = JsonConvert.DeserializeObject<GameRoot>(json);
            return i;
        }
    }
}
