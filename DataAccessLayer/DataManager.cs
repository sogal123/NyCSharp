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
    internal class DataManager
    {

        public void SerializePodcast(List<Podcast> items)
        {

            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
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

        public List<string> RssFeeder(string url)
        {

            List<string> data = new List<string>();
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            data.Add(feed.Description.Text);
            foreach (SyndicationItem item in feed.Items)                
            {
                Console.WriteLine(item.);
                Console.WriteLine(item.descri);
            }
            return data;
        }
    }
}