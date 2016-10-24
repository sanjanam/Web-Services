using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;
using System.Net;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;


namespace News_Focus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "News" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select News.svc or News.svc.cs at the Solution Explorer and start debugging.
    public class News : INews
    {
        private string MapURL;
       
        List<string> temp = new List<string>();

        string URLXML;
        

        public string[] GetURL(string keyword)
        {
            try
            {
                //api for keyword search
                MapURL = "http://lookup.dbpedia.org/api/search/KeywordSearch?QueryString=" + keyword;

                //creating a webrequest for the MapURL to get the data
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(MapURL);

                //fetch web data and store it in mapresponse
                HttpWebResponse webResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                //convert the webesponse to a stream of data
                StreamReader streamReader = new System.IO.StreamReader(webResponse.GetResponseStream());

                //store the stream in XML string
                URLXML = streamReader.ReadToEnd();

                //create an xmlreader for parsing
                XmlReader xread = XmlReader.Create(new StringReader(URLXML));


                xread.ReadToFollowing("Label");

                if ((xread.NodeType == XmlNodeType.Element) && (xread.NodeType != XmlNodeType.EndElement))
                {
                   
                    temp.Add(xread.ReadString());

                }

                xread.ReadToFollowing("URI");

                if ((xread.NodeType == XmlNodeType.Element) && (xread.NodeType != XmlNodeType.EndElement))
                {
                    temp.Add(xread.ReadString());
                }


                xread = XmlReader.Create(new StringReader(URLXML));

                //fetch the urls
                while (xread.Read())
                {
                    xread.ReadToFollowing("Class");

                    //check that the node is of type element and not end node
                    if ((xread.NodeType == XmlNodeType.Element) && (xread.NodeType != XmlNodeType.EndElement))
                    {
                        xread.ReadToFollowing("URI");
                        temp.Add(xread.ReadString());
                    }
                }

                string[] temp2 = temp.ToArray();
                return temp2;
            }
            catch (Exception e)
            {
                string[] x = new string[] { e.ToString() };
                return x;
            }
        }
    }
}
