using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace YaDiskUpload
{
    class Requests
    {
        static HttpClient client;

        public Requests()
        {
            var handler = new HttpClientHandler();
            // Disable certificate verification
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };
            client = new HttpClient(handler);
        }

        public async Task<String> PostAuthCodeToToken(string code)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, "http://oauth.yandex.ru/token"))
            {
                var authenticationString = $"{Constants.AppId}:{Constants.ClientSecret}";
                var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
                var data = new[]
                {
                    new KeyValuePair<string, string>("grant_type", "authorization_code"),
                    new KeyValuePair<string, string>("code", code),
                };

                request.Content = new FormUrlEncodedContent(data);
                string responce_str = "";
                AuthCodeResponce response_obj;
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    responce_str = await response.Content.ReadAsStringAsync();
                    response_obj = JsonSerializer.Deserialize<AuthCodeResponce>(responce_str);
                    responce_str = response_obj.access_token;
                }
                else
                {
                    responce_str = await response.Content.ReadAsStringAsync();
                }
                return responce_str;
            }
        }
        public async Task<string> GetFileUpload(string filePath,string folder, string token)
        {
            string filename = Path.GetFileName(filePath);
            string url;
            if (folder == "")
            {
                url = $"https://cloud-api.yandex.net/v1/disk/resources/upload?path={filename}";
            }
            else
            {
                url = $"https://cloud-api.yandex.net/v1/disk/resources/upload?path=%2F{folder}%2F{filename}";
            }
            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {

                GetUploadResponce response_obj;
                request.Headers.Authorization = new AuthenticationHeaderValue("OAuth", token);
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                string response_info = "";
                string responce_str = "";
                if (response.IsSuccessStatusCode)
                {
                    responce_str = await response.Content.ReadAsStringAsync();
                    response_obj = JsonSerializer.Deserialize<GetUploadResponce>(responce_str);
                    if (!response_obj.templated)
                    {
                        using (var content = new StreamContent(File.OpenRead(filePath)))
                        {
                            using (var req = new HttpRequestMessage(HttpMethod.Put, response_obj.href))
                            {
                                req.Content = content;
                                HttpResponseMessage resp = await client.SendAsync(req).ConfigureAwait(false);
                                {
                                    if (!resp.IsSuccessStatusCode)
                                    {
                                        response_info = await resp.Content.ReadAsStringAsync() + " when try PUT request";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        response_info = "I don't know how to operate with templated urls, here an example: " + response_obj.href;
                    }
                }
                else
                {
                    if((int)response.StatusCode == 507)
                    {
                        response_info = "507";
                    }
                    else
                    {
                        response_info = await response.Content.ReadAsStringAsync();
                        response_info += " when try GET request";
                    }    
                }
                return response_info;
            }
        }

        public async Task<string> GetTestRequest(string token)
        {
            string url = "https://cloud-api.yandex.net/v1/disk/";
            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("OAuth", token);
                //request.Headers.Add("Bearer", token);
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                string response_info = "";
                if (!response.IsSuccessStatusCode)
                {
                    response_info = await response.Content.ReadAsStringAsync();
                }
                return response_info;
            }
        }

    }

}
