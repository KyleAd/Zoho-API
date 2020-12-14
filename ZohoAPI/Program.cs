using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZohoAPI.Initializer;
using Com.Zoho.Crm.API.Util;
using Newtonsoft.Json;
using Com.Zoho.Crm.API;
using static Com.Zoho.Crm.API.Modules.ModulesOperations;
using Newtonsoft.Json.Linq;
using Com.Zoho.API.Exception;
using Com.Zoho.API.Authenticator.Store;

namespace ZohoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenStore tokenstore = new FileStore("/Users/user_name/Documents/csharp_sdk_token.txt");

            Initialize.SDKInitialize();

        }
    }
}
