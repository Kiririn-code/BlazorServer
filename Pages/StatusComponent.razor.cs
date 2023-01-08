using Microsoft.AspNetCore.Components;
using System;

namespace BlazorServer.Pages
{
    public class StatusComponentModel : ComponentBase
    {
        public Status Status { get; set; }
        public string CssName { get {
                return Status.ToString().ToLower();
            }
        }

        public void OnStstusChange(ChangeEventArgs args)
        {
            var value = args.Value?.ToString();
            Status = Enum.Parse<Status>(value ?? "Disconnected");
        }
    }
}