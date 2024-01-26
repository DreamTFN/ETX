using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ETX
{
    internal class Conn_Xml_Parse
    {
        public void Parse()
        {

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(@"conn/conn.xml");
                short ProgWorkType = short.Parse(doc.DocumentElement.SelectSingleNode("/root/ProgWorkType").InnerText.ToString());
                String ServerName = doc.DocumentElement.SelectSingleNode("/root/ServerName").InnerText.ToString();
                String DbName = doc.DocumentElement.SelectSingleNode("/root/DbName").InnerText.ToString();
                String DbUser = doc.DocumentElement.SelectSingleNode("/root/DbUser").InnerText.ToString();
                String DbPass = doc.DocumentElement.SelectSingleNode("/root/DbPass").InnerText.ToString();

                Tools.ProgWorkType = ProgWorkType;
                Tools.ServerName = ServerName;
                Tools.DbName = DbName;
                Tools.DbUser = DbUser;
                Tools.DbPass = DbPass;
            }
            catch (XmlException xex) { MessageBox.Show("XmlException : " + xex, "HATA !"); }
            catch (ArgumentNullException xex) { MessageBox.Show("ArgumentNullException : " + xex, "HATA !"); }
            catch (ArgumentException xex) { MessageBox.Show("ArgumentException : " + xex, "HATA !"); }
            catch (Exception ex) { MessageBox.Show("Hata : " + ex, "HATA !"); }

        }


        public void Save(short ProgWorkType, String ServerName, String DbName, String DbUser, String DbPass)
        {

            XDocument doc = new XDocument
            (
                new XElement
                ("root",
                    new XElement("ProgWorkType", ProgWorkType),
                    new XElement("ServerName", ServerName),
                    new XElement("DbName", DbName),
                    new XElement("DbUser", DbUser),
                    new XElement("DbPass", DbPass)
                )
            );
            doc.Save(@"conn/conn.xml");

        }

    }
}
