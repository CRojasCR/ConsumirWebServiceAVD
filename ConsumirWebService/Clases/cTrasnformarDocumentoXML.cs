using System.Text;
using System.Xml;

namespace ConsumirWebService.Clases
{
    public partial class cTrasnformarDocumentoXML
    {
        public string DocumentoXML(string strDocumento) 
        {
            try
            {
                // Decodificar el contenido Base64
                byte[] xmlBytes = Convert.FromBase64String(strDocumento);
                string xmlString = Encoding.UTF8.GetString(xmlBytes);

                // Cargar el contenido del campo documentoxml en un objeto XmlDocument
                XmlDocument xmlDoc = new();
                xmlDoc.LoadXml(xmlString);

                // Convertir el XmlDocument a string si es necesario
                return xmlDoc.OuterXml;
            }
            catch (Exception)
            {
                return "Error al convertir a xml.";
            }
        }
    }
}
