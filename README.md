# ZohoAPI
Zoho API tool.

## Description
Zoho API receives data from the authorized client. The intention here is to manipulate API data from and through Zoho in this executable.

## Tasks
DONE
- Zoho self-client created.
- Project Initialized.
- Zoho Auth procedure working
- GET API calls from Zoho
- POST, PUT, DELETE API calls through Zoho. 

TO DO
- (Tasks to be updated)

## Usage
This application allows us to manipulate data through and from Zoho. It contains a Zoho API package that has API references and doesn't require us to write our own client classes. This project is already Initalized with a self client that works effectively. However, if you want to use a new client, follow the Initializer sections instructions. 

### Initializer
Since Zoho CRM APIs are authenticated with OAuth2 standards, you should register your client app with Zoho. To register your app:

- Visit this page https://api-console.zoho.com/

- Click on ADD CLIENT.

- Select self-client.

- Enter a valid Scope, Description and select a time description. Click GENERATE CODE.

- Save the generated code link

Your self-service app will be created and displayed.

Once that is done, you will now have to fill in these details for the OAuthToken method with the details generated from your client. This must be first initialized in the Initialize.cs class before any API calls are made, otherwise the Authorization won't work. 
```
Token token = new OAuthToken("Client ID", "Client Secret", "Generated Code", TokenType.GRANT, "https://www.zoho.com");
```
### Executable
