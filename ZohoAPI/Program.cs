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
            Attachment();
            BluePrint();
            BulkRead();
            BulkWrite();
            ContactRoles();
            Currency();
            CustomView();
            Field();
            File();
            Layout();
            Module();
            Note();
            Notification();
            Organization();
            Profile();
            Query();
            Record();
            RelatedList();
            RelatedRecords();
            Role();
            ShareRecords();
            Tags();
            Tax();
            Territory();
            User();
            VariableGroup();
            Variable();
            //Threading();
            //TestUpload();
        }

        public static void Attachment()
        {
            try
            {
                string moduleAPIName = "Leads";

                long recordId = 34770616920152;

                long attachmentId = 34770617606001;

                string absoluteFilePath = "/Users/Desktop/test.html";

                string destinationFolder = "/Users/Documents/java/attachment";

                string attachmentURL = "https://5.imimg.com/data5/KJ/UP/MY-8655440/zoho-crm-500x500.png";

                List<long> attachmentIds = new List<long>() { 34770617600002, 34770617607001, 34770615961010 };

                ZohoAPI.Data.Attachment.UploadAttachments(moduleAPIName, recordId, absoluteFilePath);

                ZohoAPI.Data.Attachment.GetAttachments(moduleAPIName, recordId);

                ZohoAPI.Data.Attachment.DeleteAttachments(moduleAPIName, recordId, attachmentIds);

                ZohoAPI.Data.Attachment.DownloadAttachment(moduleAPIName, recordId, attachmentId, destinationFolder);

                ZohoAPI.Data.Attachment.DeleteAttachment(moduleAPIName, recordId, attachmentId);

                ZohoAPI.Data.Attachment.UploadLinkAttachments(moduleAPIName, recordId, attachmentURL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void BluePrint()
        {
            try
            {
                string moduleAPIName = "Leads";

                long recordId = 34770614381002;

                long transitionId = 34770610173093;

                ZohoAPI.Data.BluePrint.GetBlueprint(moduleAPIName, recordId);

                ZohoAPI.Data.BluePrint.UpdateBlueprint(moduleAPIName, recordId, transitionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void BulkRead()
        {
            try
            {
                string moduleAPIName = "Events";

                long jobId = 34770617610008;

                string destinationFolder = "/Users/Documents/java/attachment";

                ZohoAPI.Data.BulkRead.CreateBulkReadJob(moduleAPIName);

                ZohoAPI.Data.BulkRead.GetBulkReadJobDetails(jobId);

                ZohoAPI.Data.BulkRead.DownloadResult(jobId, destinationFolder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void BulkWrite()
        {
            try
            {
                string absoluteFilePath = "/Users/Documents/Leads.zip";

                string orgID = "xxxxxx";

                string moduleAPIName = "Leads";

                string fileId = "34770617621001";

                long jobID = 34770617608008;

                string downloadUrl = "https://download-accl.zoho.com/v2/crm/xxxx/bulk-write/34770617608008/34770617608008.zip";

                string destinationFolder = "/Users/Documents/java/attachment";

                ZohoAPI.Data.BulkWrite.UploadFile(orgID, absoluteFilePath);

                ZohoAPI.Data.BulkWrite.CreateBulkWriteJob(moduleAPIName, fileId);

                ZohoAPI.Data.BulkWrite.GetBulkWriteJobDetails(jobID);

                ZohoAPI.Data.BulkWrite.DownloadBulkWriteResult(downloadUrl, destinationFolder);
            }
            catch (SDKException ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void ContactRoles()
        {
            try
            {
                long contactRoleId = 34770617540001;

                List<long> contactRoleIds = new List<long>() { 34770617600010, 34770617600011, 34770617600012, 34770617600013, 34770617600014 };

                ZohoAPI.Data.ContactRoles.GetContactRoles();

                ZohoAPI.Data.ContactRoles.CreateContactRoles();

                ZohoAPI.Data.ContactRoles.UpdateContactRoles();

                ZohoAPI.Data.ContactRoles.DeleteContactRoles(contactRoleIds);

                ZohoAPI.Data.ContactRoles.GetContactRole(contactRoleId);

                ZohoAPI.Data.ContactRoles.UpdateContactRole(contactRoleId);

                ZohoAPI.Data.ContactRoles.DeleteContactRole(contactRoleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
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

        public static void CustomView()
        {
            try
            {
                string moduleAPIName = "Leads";

                long customID = 34770610087501;

                //List<string> names = new List<string>() { "Products", "Tasks", "Vendors", "Calls", "Leads", "Deals", "Campaigns", "Quotes", "Invoices", "Attachments", "Price_Books", "Sales_Orders", "Contacts", "Solutions", "Events", "Purchase_Orders", "Accounts", "Cases", "Notes" };

                //foreach (string name in names)
                //{
                //    Com.Zoho.Crm.Sample.CustomView.CustomView.GetCustomViews(name);
                //}

                ZohoAPI.Data.CustomView.GetCustomViews(moduleAPIName);

                ZohoAPI.Data.CustomView.GetCustomView(moduleAPIName, customID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Field()
        {
            try
            {
                string moduleAPIName = "Leads";

                long fieldId = 34770610022011;

                //List<string> names = new List<string>() { "Products", "Tasks", "Vendors", "Calls", "Leads", "Deals", "Campaigns", "Quotes", "Invoices", "Attachments", "Price_Books", "Sales_Orders", "Contacts", "Solutions", "Events", "Purchase_Orders", "Accounts", "Cases", "Notes" };

                //foreach (string name in names)
                //{
                //    Com.Zoho.Crm.Sample.Fields.Fields.GetFields(name);
                //}

                ZohoAPI.Data.Fields.GetFields(moduleAPIName);

                ZohoAPI.Data.Fields.GetField(moduleAPIName, fieldId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void File()
        {
            try
            {
                string destinationFolder = "/Users/Desktop/field/";

                string id = "ae9c7cefa418aec61f7ae1b547fbcd42e5756301";

                ZohoAPI.Data.File.UploadFiles();

                ZohoAPI.Data.File.GetFile(id, destinationFolder);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Layout()
        {
            try
            {
                string moduleAPIName = "Leads";

                long layoutId = 34770610091055;

                //List<string> names = new List<string>() { "Products", "Tasks", "Vendors", "Calls", "Leads", "Deals", "Campaigns", "Quotes", "Invoices", "Attachments", "Price_Books", "Sales_Orders", "Contacts", "Solutions", "Events", "Purchase_Orders", "Accounts", "Cases", "Notes" };

                //foreach (string name in names)
                //{
                //    Com.Zoho.Crm.Sample.Layouts.Layout.GetLayouts(name);
                //}

                ZohoAPI.Data.Layout.GetLayouts(moduleAPIName);

                ZohoAPI.Data.Layout.GetLayout(moduleAPIName, layoutId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Module()
        {
            try
            {
                string moduleAPIName = "apiName1";

                long moduleId = 34770613905003;

                ZohoAPI.Data.Modules.GetModules();

                ZohoAPI.Data.Modules.GetModule(moduleAPIName);

                ZohoAPI.Data.Modules.UpdateModuleByAPIName(moduleAPIName);

                ZohoAPI.Data.Modules.UpdateModuleById(moduleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Note()
        {
            try
            {
                List<long> notesId = new List<long>() { 34770617613024, 34770617613023, 34770617613022 };

                long noteId = 34770617613021;

                ZohoAPI.Data.Note.GetNotes();

                ZohoAPI.Data.Note.CreateNotes();

                ZohoAPI.Data.Note.UpdateNotes();

                ZohoAPI.Data.Note.DeleteNotes(notesId);

                ZohoAPI.Data.Note.GetNote(noteId);

                ZohoAPI.Data.Note.UpdateNote(noteId);

                ZohoAPI.Data.Note.DeleteNote(noteId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Notification()
        {
            try
            {
                List<long> channelIds = new List<long>() { 1006800212 };

                ZohoAPI.Data.Notification.EnableNotifications();

                ZohoAPI.Data.Notification.GetNotificationDetails();

                ZohoAPI.Data.Notification.UpdateNotifications();

                ZohoAPI.Data.Notification.UpdateNotification();

                ZohoAPI.Data.Notification.DisableNotifications(channelIds);

                ZohoAPI.Data.Notification.DisableNotification();
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Organization()
        {
            try
            {
                string absoluteFilePath = "/Users/Desktop/download.png";

                ZohoAPI.Data.Organization.GetOrganization();

                ZohoAPI.Data.Organization.UploadOrganizationPhoto(absoluteFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Profile()
        {
            try
            {
                long profileId = 34770610026011;

                ZohoAPI.Data.Profile.GetProfiles();

                ZohoAPI.Data.Profile.GetProfile(profileId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Query()
        {
            try
            {
                ZohoAPI.Data.Query.GetRecords();
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Record()
        {
            try
            {
                string moduleAPIName = "Leads";

                long recordId = 34770617589001;

                string destinationFolder = "/Users/Desktop/field/";

                //List<string> modules = new List<string>() { "products", "Tasks", "Vendors", "Calls", "Leads", "Deals", "Campaigns", "Quotes", "Invoices", "Attachments", "Price_Books", "Sales_Orders", "Contacts", "Solutions", "Events", "Purchase_Orders", "Accounts", "Cases", "Notes" };

                //foreach (string module in modules)
                //{
                //    Com.Zoho.Crm.Sample.Record.Record.GetRecords(module);
                //}

                string absoluteFilePath = "/Users/Desktop/field/download.png";

                List<long> recordIds = new List<long>() { 34770617079170, 34770616595015, 34770615908001 };

                string jobId = "34770617633026";

                ZohoAPI.Data.Record.GetRecord(moduleAPIName, recordId, destinationFolder);

                ZohoAPI.Data.Record.UpdateRecord(moduleAPIName, recordId);

                ZohoAPI.Data.Record.DeleteRecord(moduleAPIName, recordId);

                ZohoAPI.Data.Record.GetRecords(moduleAPIName);

                ZohoAPI.Data.Record.CreateRecords(moduleAPIName);

                ZohoAPI.Data.Record.UpdateRecords(moduleAPIName);

                ZohoAPI.Data.Record.DeleteRecords(moduleAPIName, recordIds);

                ZohoAPI.Data.Record.UpsertRecords(moduleAPIName);

                ZohoAPI.Data.Record.GetDeletedRecords(moduleAPIName);

                ZohoAPI.Data.Record.SearchRecords(moduleAPIName);

                ZohoAPI.Data.Record.ConvertLead(recordId);

                ZohoAPI.Data.Record.UploadPhoto(moduleAPIName, recordId, absoluteFilePath);

                ZohoAPI.Data.Record.GetPhoto(moduleAPIName, recordId, destinationFolder);

                ZohoAPI.Data.Record.DeletePhoto(moduleAPIName, recordId);

                ZohoAPI.Data.Record.MassUpdateRecords(moduleAPIName);

                ZohoAPI.Data.Record.GetMassUpdateStatus(moduleAPIName, jobId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void RelatedList()
        {
            try
            {
                string moduleAPIName = "Leads";

                long relatedListId = 34770610003771;

                //List<string> names = new List<string>() { "Products", "Tasks", "Vendors", "Calls", "Leads", "Deals", "Campaigns", "Quotes", "Invoices", "Attachments", "Price_Books", "Sales_Orders", "Contacts", "Solutions", "Events", "Purchase_Orders", "Accounts", "Cases" };

                //foreach (string name in names)
                //{
                //    Com.Zoho.Crm.Sample.RelatedList.RelatedList.GetRelatedLists(name);
                //}

                ZohoAPI.Data.RelatedList.GetRelatedLists(moduleAPIName);

                ZohoAPI.Data.RelatedList.GetRelatedList(moduleAPIName, relatedListId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void RelatedRecords()
        {
            try
            {
                string moduleAPIName = "Products";

                long recordId = 34770617606020;

                string relatedListAPIName = "Price_Books";

                long relatedRecordId = 34770615917011;

                string destinationFolder = "/Users/Desktop/field/";

                List<long> relatedListIds = new List<long>() { 34770610307003, 34770615917011, 34770615919001 };

                ZohoAPI.Data.RelatedRecords.GetRelatedRecords(moduleAPIName, recordId, relatedListAPIName);

                ZohoAPI.Data.RelatedRecords.UpdateRelatedRecords(moduleAPIName, recordId, relatedListAPIName);

                ZohoAPI.Data.RelatedRecords.DelinkRecords(moduleAPIName, recordId, relatedListAPIName, relatedListIds);

                ZohoAPI.Data.RelatedRecords.GetRelatedRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId, destinationFolder);

                ZohoAPI.Data.RelatedRecords.UpdateRelatedRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId);

                ZohoAPI.Data.RelatedRecords.DelinkRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Role()
        {
            try
            {
                long roleId = 34770610026008;

                ZohoAPI.Data.Role.GetRoles();

                ZohoAPI.Data.Role.GetRole(roleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void ShareRecords()
        {
            try
            {
                string moduleAPIName = "Leads";

                long recordId = 34770615623115L;

                ZohoAPI.Data.ShareRecords.GetSharedRecordDetails(moduleAPIName, recordId);

                ZohoAPI.Data.ShareRecords.ShareRecord(moduleAPIName, recordId);

                ZohoAPI.Data.ShareRecords.UpdateSharePermissions(moduleAPIName, recordId);

                ZohoAPI.Data.ShareRecords.RevokeSharedRecord(moduleAPIName, recordId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Tags()
        {
            try
            {
                string moduleAPIName = "Leads";

                long tagId = 34770617286001;

                long recordId = 34770615623115;

                List<string> tagNames = new List<string>() { "addtag1,addtag12" };

                List<long> recordIds = new List<long>() { 34770617074131, 34770616920152 };

                string conflictId = "34770617029041";

                ZohoAPI.Data.Tag.GetTags(moduleAPIName);

                ZohoAPI.Data.Tag.CreateTags(moduleAPIName);

                ZohoAPI.Data.Tag.UpdateTags(moduleAPIName);

                ZohoAPI.Data.Tag.UpdateTag(moduleAPIName, tagId);

                ZohoAPI.Data.Tag.DeleteTag(tagId);

                ZohoAPI.Data.Tag.MergeTags(tagId, conflictId);

                ZohoAPI.Data.Tag.AddTagsToRecord(moduleAPIName, recordId, tagNames);

                ZohoAPI.Data.Tag.RemoveTagsFromRecord(moduleAPIName, recordId, tagNames);

                ZohoAPI.Data.Tag.AddTagsToMultipleRecords(moduleAPIName, recordIds, tagNames);

                ZohoAPI.Data.Tag.RemoveTagsFromMultipleRecords(moduleAPIName, recordIds, tagNames);

                ZohoAPI.Data.Tag.GetRecordCountForTag(moduleAPIName, tagId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Tax()
        {
            try
            {
                long taxId = 34770616449002;

                List<long> taxIds = new List<long>() { 34770617643024, 34770615682038 };

                ZohoAPI.Data.Tax.GetTaxes();

                ZohoAPI.Data.Tax.CreateTaxes();

                ZohoAPI.Data.Tax.UpdateTaxes();

                ZohoAPI.Data.Tax.DeleteTaxes(taxIds);

                ZohoAPI.Data.Tax.GetTax(taxId);

                ZohoAPI.Data.Tax.DeleteTax(taxId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Territory()
        {
            try
            {
                long territoryId = 34770613051397;

                ZohoAPI.Data.Territory.GetTerritories();

                ZohoAPI.Data.Territory.GetTerritory(territoryId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Threading()
        {
            try
            {
                ZohoAPI.Data.Threading.MultiUser.MultiThread.RunMultiThreadWithMultiUser();

                ZohoAPI.Data.Threading.MultiUser.SingleThread.RunSingleThreadWithMultiUser();

                ZohoAPI.Data.Threading.SingleUser.MultiThread.RunMultiThreadWithSingleUser();

                ZohoAPI.Data.Threading.SingleUser.SingleThread.RunSingleThreadWithSingleUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void User()
        {
            try
            {
                long userId = 34770617639002;

                ZohoAPI.Data.User.GetUsers();

                ZohoAPI.Data.User.CreateUser();

                ZohoAPI.Data.User.UpdateUsers();

                ZohoAPI.Data.User.GetUser(userId);

                ZohoAPI.Data.User.UpdateUser(userId);

                ZohoAPI.Data.User.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void VariableGroup()
        {
            try
            {
                string variableGroupName = "General";

                long variableGroupId = 34770613089001;

                ZohoAPI.Data.VariableGroup.GetVariableGroups();

                ZohoAPI.Data.VariableGroup.GetVariableGroupById(variableGroupId);

                ZohoAPI.Data.VariableGroup.GetVariableGroupByAPIName(variableGroupName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Variable()
        {
            try
            {
                List<long> variableIds = new List<long>() { 34770617636020, 34770617636022 };

                long variableId = 34770617444007;

                string variableName = "Variable552";

                ZohoAPI.Data.Variable.GetVariables();

                ZohoAPI.Data.Variable.CreateVariables();

                ZohoAPI.Data.Variable.UpdateVariables();

                ZohoAPI.Data.Variable.DeleteVariables(variableIds);

                ZohoAPI.Data.Variable.GetVariableById(variableId);

                ZohoAPI.Data.Variable.UpdateVariableById(variableId);

                ZohoAPI.Data.Variable.DeleteVariable(variableId);

                ZohoAPI.Data.Variable.GetVariableForAPIName(variableName);

                ZohoAPI.Data.Variable.UpdateVariableByAPIName(variableName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void TestUpload()
        {
            string boundary = "----FILEBOUNDARY----";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.zohoapis.com/crm/v2/files");

            request.ContentType = "multipart/form-data; boundary=" + boundary;

            request.Method = "POST";

            request.Headers["Authorization"] = "Zoho-oauthtoken 1000.xxxx.xxxxx";

            request.KeepAlive = true;

            Stream memStream = new System.IO.MemoryStream();

            var boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            var endBoundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--");

            string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" + "Content-Type: application/octet-stream\r\n\r\n";

            StreamWrapper streamWrapper = new StreamWrapper("/Users/Desktop/test.html");

            StreamWrapper streamWrapper1 = new StreamWrapper("/Users/Desktop/test.html");

            List<StreamWrapper> streamWrapperList = new List<StreamWrapper>() { streamWrapper, streamWrapper1 };

            for (int i = 0; i < streamWrapperList.Count; i++)
            {
                StreamWrapper streamWrapperInstance = streamWrapperList[i];

                memStream.Write(boundarybytes, 0, boundarybytes.Length);

                var header = string.Format(headerTemplate, "file", streamWrapperInstance.Name);

                var headerbytes = System.Text.Encoding.UTF8.GetBytes(header);

                memStream.Write(headerbytes, 0, headerbytes.Length);

                var buffer = new byte[1024];

                var bytesRead = 0;

                while ((bytesRead = streamWrapperInstance.Stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    memStream.Write(buffer, 0, bytesRead);
                }
            }

            memStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);

            request.ContentLength = memStream.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                memStream.Position = 0;

                byte[] tempBuffer = new byte[memStream.Length];

                memStream.Read(tempBuffer, 0, tempBuffer.Length);

                memStream.Close();

                requestStream.Write(tempBuffer, 0, tempBuffer.Length);
            }

            HttpWebResponse response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Response == null) { throw; }

                response = (HttpWebResponse)e.Response;
            }

            HttpWebResponse responseEntity = response;

            string responsestring = new StreamReader(responseEntity.GetResponseStream()).ReadToEnd();

            responseEntity.Close();

            Console.WriteLine(responsestring);
        }
    }
}

