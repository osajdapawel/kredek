using System;

namespace PawelOsajdaZadanieDomowe6.Models
{   
    /// <summary>
    /// Klasa od Microsoftu, co dziwne bo jest za darmo ;) 
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
