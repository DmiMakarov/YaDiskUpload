namespace YaDiskUpload
{
    class AuthCodeResponce
    {
        public string token_type { get; set; }
        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
    }

    class GetUploadResponce
    {
        public string operation_id { get; set; }
        public string href { get; set; }
        public string method { get; set; }
        public bool templated { get; set; }
    }

    class GetUploadError
    {
        public string message { get; set; }
        public string description { get; set; }
        public string error { get; set; }
    }
}
