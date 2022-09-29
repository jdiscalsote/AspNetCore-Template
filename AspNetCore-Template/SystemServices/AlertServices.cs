using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

using AspNetCore_Template.SystemModels;

namespace AspNetCore_Template.SystemServices
{
    public class AlertServices
    {
        //System Message
        public static string ShowAlert(Alerts obj, string message)
        {
            string alertDiv = null;
            switch (obj)
            {
                case Alerts.Success:
                    alertDiv = "<div class='alert alert-success fade show' role='alert'><strong>Success!</strong > " + message + ".</div>";
                    break;
                case Alerts.Danger:
                    alertDiv = "<div class='alert alert-danger fade show' role='alert'><strong>Error!</strong > " + message + ".</div>";
                    break;
                case Alerts.Info:
                    alertDiv = "<div class='alert alert-info fade show' role='alert'><strong>Info!</strong > " + message + ".</div>";
                    break;
                case Alerts.Warning:
                    alertDiv = "<div class='alert alert-warning fade show' role='alert'><strong>Warning!</strong> " + message + ".</div>";
                    break;
            }
            return alertDiv;
        }
    }
}
