using System.ServiceModel;
using wsAVD;

namespace ConsumirWebService.Clases
{
    public class cClienteAVD
    {
        private readonly BasicHttpBinding binding;
        private readonly EndpointAddress endpoint;
        public cClienteAVD()
        {
            binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport)
            {
                Security = { Transport = { ClientCredentialType = HttpClientCredentialType.None } },
                MaxReceivedMessageSize = int.MaxValue,
                ReaderQuotas =
            {
                MaxDepth = int.MaxValue,
                MaxStringContentLength = int.MaxValue,
                MaxArrayLength = int.MaxValue,
                MaxBytesPerRead = int.MaxValue,
                MaxNameTableCharCount = int.MaxValue
            },
                SendTimeout = TimeSpan.FromMinutes(10),
                ReceiveTimeout = TimeSpan.FromMinutes(10),
                OpenTimeout = TimeSpan.FromMinutes(1),
                CloseTimeout = TimeSpan.FromMinutes(1)
            };

            endpoint = new EndpointAddress("https://cabecar.avdcloud.com/WS_GESSA_CR/utilityFERC.asmx");

            //Pruebas: https://qaserver02.avdcloud.com/WS_GESSA_CR/utilityFERC.asmx
        }
        public utilityFERCSoapClient crearCliente()
        {
            return new utilityFERCSoapClient(binding, endpoint);
        }
    }
}
