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
            //Attachment();
            //BluePrint();
            //BulkRead();
            //BulkWrite();
            ContactRoles();
            Currency();
            //CustomView();
            //Field();
            //File();
            //Layout();
            Module();
            Note();
            Notification();
            Organization();
            Profile();
            Query();
            //Record();
            //RelatedList();
            //RelatedRecords();
            Role();
            //ShareRecords();
            //Tags();
            Tax();
            Territory();
            User();
            //VariableGroup(); //Access Denied
            //Variable(); //No Permission
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

                Data.Attachment.UploadAttachments(moduleAPIName, recordId, absoluteFilePath);

                Data.Attachment.GetAttachments(moduleAPIName, recordId);

                Data.Attachment.DeleteAttachments(moduleAPIName, recordId, attachmentIds);

                Data.Attachment.DownloadAttachment(moduleAPIName, recordId, attachmentId, destinationFolder);

                Data.Attachment.DeleteAttachment(moduleAPIName, recordId, attachmentId);

                Data.Attachment.UploadLinkAttachments(moduleAPIName, recordId, attachmentURL);
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

                Data.BluePrint.GetBlueprint(moduleAPIName, recordId);

                Data.BluePrint.UpdateBlueprint(moduleAPIName, recordId, transitionId);
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

                Data.BulkRead.CreateBulkReadJob(moduleAPIName);

                Data.BulkRead.GetBulkReadJobDetails(jobId);

                Data.BulkRead.DownloadResult(jobId, destinationFolder);
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

                Data.BulkWrite.UploadFile(orgID, absoluteFilePath);

                Data.BulkWrite.CreateBulkWriteJob(moduleAPIName, fileId);

                Data.BulkWrite.GetBulkWriteJobDetails(jobID);

                Data.BulkWrite.DownloadBulkWriteResult(downloadUrl, destinationFolder);
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
                //long contactRoleId = 34770617540001;

                //List<long> contactRoleIds = new List<long>() { 34770617600010, 34770617600011, 34770617600012, 34770617600013, 34770617600014 };

                Data.ContactRoles.GetContactRoles();

                /*Data.ContactRoles.CreateContactRoles();

                Data.ContactRoles.UpdateContactRoles();

                Data.ContactRoles.DeleteContactRoles(contactRoleIds);

                Data.ContactRoles.GetContactRole(contactRoleId);

                Data.ContactRoles.UpdateContactRole(contactRoleId);

                Data.ContactRoles.DeleteContactRole(contactRoleId);*/
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
                //long currencyId = 34770617368016;

                Data.Currency.GetCurrencies();

                //Data.Currency.AddCurrencies();

                //Data.Currency.UpdateCurrencies();

                //Data.Currency.EnableMultipleCurrencies();

                //Data.Currency.UpdateBaseCurrency();

                //Data.Currency.GetCurrency(currencyId);

                //Data.Currency.UpdateCurrency(currencyId);
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

                Data.CustomView.GetCustomViews(moduleAPIName);

                Data.CustomView.GetCustomView(moduleAPIName, customID);
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

                Fields.GetFields(moduleAPIName);

                Fields.GetField(moduleAPIName, fieldId);
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

                Data.File.UploadFiles();

                Data.File.GetFile(id, destinationFolder);
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

                Data.Layout.GetLayouts(moduleAPIName);

                Data.Layout.GetLayout(moduleAPIName, layoutId);
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
                //string moduleAPIName = "apiName1";

                //long moduleId = 34770613905003;

                Modules.GetModules();

                //Modules.GetModule(moduleAPIName);

                //Modules.UpdateModuleByAPIName(moduleAPIName);

                //Modules.UpdateModuleById(moduleId);
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
                //List<long> notesId = new List<long>() { 34770617613024, 34770617613023, 34770617613022 };

                //long noteId = 34770617613021;

                Data.Note.GetNotes();

                //Data.Note.CreateNotes();

                //Data.Note.UpdateNotes();

                //Data.Note.DeleteNotes(notesId);

                //Data.Note.GetNote(noteId);

                //Data.Note.UpdateNote(noteId);

                //Data.Note.DeleteNote(noteId);
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
                //List<long> channelIds = new List<long>() { 1006800212 };

                //Data.Notification.EnableNotifications();

                Data.Notification.GetNotificationDetails();

                //Data.Notification.UpdateNotifications();

                //Data.Notification.UpdateNotification();

                //Data.Notification.DisableNotifications(channelIds);

                //Data.Notification.DisableNotification();
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
                //string absoluteFilePath = "/Users/Desktop/download.png";

                Data.Organization.GetOrganization();

                //Data.Organization.UploadOrganizationPhoto(absoluteFilePath);
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
                //long profileId = 34770610026011;

                Data.Profile.GetProfiles();

                //Data.Profile.GetProfile(profileId);
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
                Data.Query.GetRecords();
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

                Data.Record.GetRecord(moduleAPIName, recordId, destinationFolder);

                Data.Record.UpdateRecord(moduleAPIName, recordId);

                Data.Record.DeleteRecord(moduleAPIName, recordId);

                Data.Record.GetRecords(moduleAPIName);

                Data.Record.CreateRecords(moduleAPIName);

                Data.Record.UpdateRecords(moduleAPIName);

                Data.Record.DeleteRecords(moduleAPIName, recordIds);

                Data.Record.UpsertRecords(moduleAPIName);

                Data.Record.GetDeletedRecords(moduleAPIName);

                Data.Record.SearchRecords(moduleAPIName);

                Data.Record.ConvertLead(recordId);

                Data.Record.UploadPhoto(moduleAPIName, recordId, absoluteFilePath);

                Data.Record.GetPhoto(moduleAPIName, recordId, destinationFolder);

                Data.Record.DeletePhoto(moduleAPIName, recordId);

                Data.Record.MassUpdateRecords(moduleAPIName);

                Data.Record.GetMassUpdateStatus(moduleAPIName, jobId);
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

                Data.RelatedList.GetRelatedLists(moduleAPIName);

                Data.RelatedList.GetRelatedList(moduleAPIName, relatedListId);
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

                Data.RelatedRecords.GetRelatedRecords(moduleAPIName, recordId, relatedListAPIName);

                Data.RelatedRecords.UpdateRelatedRecords(moduleAPIName, recordId, relatedListAPIName);

                Data.RelatedRecords.DelinkRecords(moduleAPIName, recordId, relatedListAPIName, relatedListIds);

                Data.RelatedRecords.GetRelatedRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId, destinationFolder);

                Data.RelatedRecords.UpdateRelatedRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId);

                Data.RelatedRecords.DelinkRecord(moduleAPIName, recordId, relatedListAPIName, relatedRecordId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ex));
            }
        }

        public static void Role()
        {
            try
            {
                //long roleId = 34770610026008;

                Data.Role.GetRoles();

                //Data.Role.GetRole(roleId);
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

                Data.ShareRecords.GetSharedRecordDetails(moduleAPIName, recordId);

                Data.ShareRecords.ShareRecord(moduleAPIName, recordId);

                Data.ShareRecords.UpdateSharePermissions(moduleAPIName, recordId);

                Data.ShareRecords.RevokeSharedRecord(moduleAPIName, recordId);
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

                Tag.GetTags(moduleAPIName);

                Tag.CreateTags(moduleAPIName);

                Tag.UpdateTags(moduleAPIName);

                Tag.UpdateTag(moduleAPIName, tagId);

                Tag.DeleteTag(tagId);

                Tag.MergeTags(tagId, conflictId);

                Tag.AddTagsToRecord(moduleAPIName, recordId, tagNames);

                Tag.RemoveTagsFromRecord(moduleAPIName, recordId, tagNames);

                Tag.AddTagsToMultipleRecords(moduleAPIName, recordIds, tagNames);

                Tag.RemoveTagsFromMultipleRecords(moduleAPIName, recordIds, tagNames);

                Tag.GetRecordCountForTag(moduleAPIName, tagId);
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
                //long taxId = 34770616449002;

                //List<long> taxIds = new List<long>() { 34770617643024, 34770615682038 };

                Data.Tax.GetTaxes();

                //Data.Tax.CreateTaxes();

                //Data.Tax.UpdateTaxes();

                //Data.Tax.DeleteTaxes(taxIds);

                //Data.Tax.GetTax(taxId);

                //Data.Tax.DeleteTax(taxId);
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
                //long territoryId = 34770613051397;

                Data.Territory.GetTerritories();

                //Data.Territory.GetTerritory(territoryId);
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
                Data.Threading.MultiUser.MultiThread.RunMultiThreadWithMultiUser();

                Data.Threading.MultiUser.SingleThread.RunSingleThreadWithMultiUser();

                Data.Threading.SingleUser.MultiThread.RunMultiThreadWithSingleUser();

                Data.Threading.SingleUser.SingleThread.RunSingleThreadWithSingleUser();
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
                //long userId = 34770617639002;

                Data.User.GetUsers();

                //Data.User.CreateUser();

                //Data.User.UpdateUsers();

                //Data.User.GetUser(userId);

                //Data.User.UpdateUser(userId);

                //Data.User.DeleteUser(userId);
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
                //string variableGroupName = "General";

                //long variableGroupId = 34770613089001;

                Data.VariableGroup.GetVariableGroups();

                //Data.VariableGroup.GetVariableGroupById(variableGroupId);

                //Data.VariableGroup.GetVariableGroupByAPIName(variableGroupName);
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
                //List<long> variableIds = new List<long>() { 34770617636020, 34770617636022 };

                //long variableId = 34770617444007;

                //string variableName = "Variable552";

                Data.Variable.GetVariables();

                //Data.Variable.CreateVariables();

                //Data.Variable.UpdateVariables();

                //Data.Variable.DeleteVariables(variableIds);

                //Data.Variable.GetVariableById(variableId);

                //Data.Variable.UpdateVariableById(variableId);

                //Data.Variable.DeleteVariable(variableId);

                //Data.Variable.GetVariableForAPIName(variableName);

                //Data.Variable.UpdateVariableByAPIName(variableName);
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

            Stream memStream = new MemoryStream();

            var boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            var endBoundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--");

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

                var headerbytes = Encoding.UTF8.GetBytes(header);

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

