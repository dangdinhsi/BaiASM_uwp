﻿using App8.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App8.Service
{
    class ApiHandle
    {
        private static string API_URL = "https://2-dot-backup-server-002.appspot.com/_api/v2/members";
        public static string REGISTER_SONG = "https://2-dot-backup-server-002.appspot.com/_api/v2/songs";
        public async static Task<string> Sign_Up(Member member)
        {
            HttpClient httpClient = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(member), System.Text.Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync(API_URL, content);
            var contents = await response.Result.Content.ReadAsStringAsync();
            Debug.WriteLine(contents);
            return contents;
        }
      // them bai hat
    }
}
