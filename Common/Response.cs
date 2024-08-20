using System;

namespace Common
{
    [Serializable]
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public object Result { get; set; }
        public string Error { get; set; }
    }
}
