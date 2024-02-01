
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Example
{
    using Example.Utils;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;



    public interface IExampleSDK
    {
        public IPets Pets { get; }
    }
    
    public class SDKConfig
    {
        public static string[] ServerList = new string[]
        {
            "http://petstore.swagger.io/v1",
        };
        /// Contains the list of servers available to the SDK
        public string serverUrl = "";
        public int serverIndex = 0;

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], new Dictionary<string, string>());
        }
    }

    public class ExampleSDK: IExampleSDK
    {
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.3.0";
        private const string _sdkGenVersion = "2.245.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.3.0 2.245.1 1.0.0 example";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IPets Pets { get; private set; }

        public ExampleSDK(int? serverIndex = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;

            SDKConfiguration = new SDKConfig()
            {
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Pets = new Pets(_defaultClient, _securityClient, _serverUrl, SDKConfiguration);
        }
    }
}
