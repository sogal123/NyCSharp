using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Model;
using DataAccessLayer.ExceptionClass;
using System.ServiceModel.Syndication;

namespace DataAccessLayer
{
    public class DataManager
    {
        public void SerializePodcast(List<Podcast> podcasts)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(podcasts.GetType());
                using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, podcasts);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not serialize file");
            }
        }

        public List<Podcast> DeserializePodcast()
        {
            try
            {
                List<Podcast> listReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStreamIn = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    listReturned = (List<Podcast>)xmlSerializer.Deserialize(fileStreamIn);
                }
                return listReturned;
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not deserialize file");
            }
        }

        public void SerializeKategori(List<Kategori> items)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream fileStreamOut = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))

                {
                    xmlSerializer.Serialize(fileStreamOut, items);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not serialize file");
            }
        }

        public List<Kategori> DeserializeKategori()
        {
            try
            {
                List<Kategori> lista;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream fileStreamIn = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    lista = (List<Kategori>)xmlSerializer.Deserialize(fileStreamIn);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not deserialize file");
            }
        }

        public List<SyndicationItem> FeedLäsare(string url)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(url);

            //XmlElement root = doc.DocumentElement;
            //XmlNodeList nodes = root.SelectNodes("//channel/item");

            //foreach (XmlNode node in nodes)
            //{
            //    string titel = node["title"].InnerText;
            //    string beskrivning = node["description"].InnerText;
            //    data.Add(titel);
            //    data.Add(beskrivning);
            //}

            //XmlReaderSettings settings = new XmlReaderSettings();
            //settings.IgnoreWhitespace = true;
            //settings.IgnoreComments = true;
            List<SyndicationItem> data = new List<SyndicationItem>();
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            data.Add(feed.Title.Text);
            data.Add(feed.Description.Text);
            foreach (SyndicationItem item in feed.Items)
            {
                data.Add(item.Title.Text);
                data.Add(item.Summary.Text);
            }
        }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Hittar inte filen");
            }

            return data;
        }
    }
}