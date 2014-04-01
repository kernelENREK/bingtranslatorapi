using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace AzureTranslator
{
    public class BingTranslator
    {
        private string uriService = "http://api.microsofttranslator.com/v2/Http.svc/Translate?text={0}&from={1}&to={2}";
        public string Translate(AzureAccessToken token, string originaltext, string from, string to)
        {
            string headerValue = "Bearer " + token.access_token;

            try
            {
                string uri = string.Format(uriService,
                    System.Web.HttpUtility.UrlEncode(originaltext),
                    from,
                    to);

                WebRequest translationWebRequest = WebRequest.Create(uri);
                translationWebRequest.Proxy = null;
                translationWebRequest.Headers.Add("Authorization", headerValue);
                WebResponse response = null;
                response = translationWebRequest.GetResponse();
                Stream stream = response.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                System.IO.StreamReader translatedStream = new System.IO.StreamReader(stream, encode);
                System.Xml.XmlDocument xTranslation = new System.Xml.XmlDocument();
                xTranslation.LoadXml(translatedStream.ReadToEnd());

                return xTranslation.InnerText;
            }
            catch (WebException webex)
            {
                // Posiblemente el clientID, clientSecret, etc no sean correctos
                throw new System.Exception(webex.Message);
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return originaltext;
        }
    }
}
