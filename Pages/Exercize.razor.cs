using Microsoft.AspNetCore.Components;
using System;

namespace BlazorServer.Pages
{
    public class ExercizeModel : ComponentBase
    {
        public string Time { get; set; }

        public void GetTime()
        {
            Time = DateTime.Now.ToString("D");
        }
    }

    public enum Status
    {
        
    Disconected,
    Connected,
    Connecting
    }
}