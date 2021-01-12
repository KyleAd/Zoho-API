using System;
using Com.Zoho.API.Authenticator;
using Com.Zoho.API.Authenticator.Store;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Dc;
using Com.Zoho.Crm.API.Logger;
using static Com.Zoho.API.Authenticator.OAuthToken;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using SDKInitializer = Com.Zoho.Crm.API.Initializer;

namespace ZohoAPI.Initializer
{
	public class Initialize
	{
		public static void SDKInitialize()
		{
			/*
			 * Create an instance of Logger Class that takes two parameters
			 * 1 -> Level of the log messages to be logged. Can be configured by typing Levels "." and choose any level from the list displayed.
			 * 2 -> Absolute file path, where messages need to be logged.
			 */
			Logger logger = Logger.GetInstance(Logger.Levels.ALL, @"C:\Users\KyleAdamson\OneDrive - ALTIATECH LTD\Documents\Work Projects\Zoho Api\csharp_sdk_log1.log");

			//Create an UserSignature instance that takes user Email as parameter
			UserSignature user = new UserSignature("kyle@altiatech.com");

			/*
		     * Configure the environment
		     * which is of the pattern Domain.Environment
		     * Available Domains: USDataCenter, EUDataCenter, INDataCenter, CNDataCenter, AUDataCenter
		     * Available Environments: PRODUCTION, DEVELOPER, SANDBOX
		     */
			Com.Zoho.Crm.API.Dc.DataCenter.Environment environment = USDataCenter.PRODUCTION;

			/*
		     * Create a Token instance
		     * 1 -> OAuth client id.
		     * 2 -> OAuth client secret.
		     * 3 -> OAuth redirect URL.
		     * 4 -> REFRESH/GRANT token.
		     * 5 -> token type.
		     */
			//Token token = new OAuthToken("1000.xxxxx", "xxxxxx", "1000.xxxxxx.xxxxxx", TokenType.REFRESH, "https://www.zoho.com");

			//Token token = new OAuthToken("1000.xxxx", "xxxxxx", "1000.xxxxxx.xxxxxx", TokenType.GRANT, "https://www.zoho.com");

			Token token = new OAuthToken("1000.32A3H9K58K7WBSSTKWUME9KPML1G6A", "053a706cc38bce664db75293733551b70f8433057d", "1000.fb7a8eb64824a8c448d3a3b5480f7660.7ed271bd17a72be70b6933fe813433a6", TokenType.GRANT, "https://www.zoho.com");

			/*
		     * Create an instance of TokenStore.
		     * 1 -> DataBase host name. Default "jdbc:mysql://localhost"
		     * 2 -> DataBase name. Default "zohooauth"
		     * 3 -> DataBase user name. Default "root"
		     * 4 -> DataBase password. Default ""
		     * 5 -> DataBase port number. Default "3306"
		     */
			//TokenStore tokenstore = new DBStore();

			//TokenStore tokenstore = new DBStore(null, null, null, null, null);

			TokenStore tokenstore = new FileStore(@"C:\Users\KyleAdamson\OneDrive - ALTIATECH LTD\Documents\Work Projects\Zoho Api\csharp_sdk_token.txt");

			/*
            * autoRefreshFields
            * if true - all the modules' fields will be auto-refreshed in the background, every    hour.
            * if false - the fields will not be auto-refreshed in the background. The user can manually delete the file(s) or refresh the fields using methods from ModuleFieldsHandler(com.zoho.crm.api.util.ModuleFieldsHandler)
            * 
            * pickListValidation
            * if true - value for any picklist field will be validated with the available values.
            * if false - value for any picklist field will not be validated, resulting in creation of a new value.
            */
			SDKConfig config = new SDKConfig.Builder().SetAutoRefreshFields(true).SetPickListValidation(false).Build();

			string resourcePath = @"C:\Users\KyleAdamson\OneDrive - ALTIATECH LTD\Documents\Work Projects\Zoho Api";

			/**
			 * Create an instance of RequestProxy class that takes the following parameters
			 * 1 -> Host
			 * 2 -> Port Number
			 * 3 -> User Name
			 * 4 -> Password
			 * 5 -> User Domain
			 */
			//RequestProxy requestProxy = new RequestProxy("http://171.0.0.1", 3128, "", "", "");

			//RequestProxy requestProxy = new RequestProxy("http://171.0.0.1", 3128, "", null);

			/*
		     * Call static initialize method of Initializer class that takes the arguments
		     * 1 -> UserSignature instance
		     * 2 -> Environment instance
		     * 3 -> Token instance
		     * 4 -> TokenStore instance
		     * 5 -> SDKConnfig 
		     * 6 -> The path containing the absolute directory path to store user specific JSON files containing module fields information.
		     * 7 -> Logger instance
		     * 8 -> RequestProxy instance
		     */

			// The following are the available initialize methods

			//SDKInitializer.Initialize(user, environment, token, tokenstore, config, resourcePath);

			SDKInitializer.Initialize(user, environment, token, tokenstore, config, resourcePath, logger);

			//SDKInitializer.Initialize(user, environment, token, tokenstore, config, resourcePath, requestProxy);

			//SDKInitializer.Initialize(user, environment, token, tokenstore, config, resourcePath, logger, requestProxy);

			//foreach (Token token1 in ((DBStore)tokenstore).GetTokens())
			//{
			//    OAuthToken authToken = (OAuthToken)token1;

			//    Console.WriteLine(authToken.AccessToken);

			//    Console.WriteLine(authToken.RefreshToken);

			//    Console.WriteLine(authToken.ExpiresIn);

			//    Console.WriteLine(authToken.GrantToken);
			//}
		}
	}
}
