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
using ZohoAPI.Data;

namespace ZohoAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize.SDKInitialize();
            Currency();

        }

        public static void Currency()
        {
            try
            {
                long currencyId = 34770617368016;

                ZohoAPI.Data.Currency.GetCurrencies();

                ZohoAPI.Data.Currency.AddCurrencies();

                ZohoAPI.Data.Currency.UpdateCurrencies();

                ZohoAPI.Data.Currency.EnableMultipleCurrencies();

                ZohoAPI.Data.Currency.UpdateBaseCurrency();

                ZohoAPI.Data.Currency.GetCurrency(currencyId);

                ZohoAPI.Data.Currency.UpdateCurrency(currencyId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }
    }
}
