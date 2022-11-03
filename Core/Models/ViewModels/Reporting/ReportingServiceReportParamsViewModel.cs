using System.Collections.Generic;

namespace Core.Models.ViewModels.Reporting
{
    public class ReportingServiceReportParamsViewModel
    {
        public string Name { get; set; }
        public string ParameterType { get; set; }
        public string ParameterVisibility { get; set; }
        public string ParameterState { get; set; }
        public List<object> ValidValues { get; set; }
        public bool ValidValuesIsNull { get; set; }
        public bool Nullable { get; set; }
        public bool AllowBlank { get; set; }
        public bool MultiValue { get; set; }
        public string Prompt { get; set; }
        public bool PromptUser { get; set; }
        public bool QueryParameter { get; set; }
        public List<object> DefaultValues { get; set; }
        public bool DefaultValuesIsNull { get; set; }
        /// <summary>
        /// Acts as a container for the value supplied from the app
        /// </summary>
        public object ProvidedValue { get; set; }
    }
    //{
    //  "Name": "claim",
    //  "ParameterType": "String",
    //  "ParameterVisibility": "Visible",
    //  "ParameterState": "HasValidValue",
    //  "ValidValues": [],
    //  "ValidValuesIsNull": true,
    //  "Nullable": true,
    //  "AllowBlank": true,
    //  "MultiValue": false,
    //  "Prompt": "Filter po tipu",
    //  "PromptUser": true,
    //  "QueryParameter": true,
    //  "DefaultValuesQueryBased": false,
    //  "ValidValuesQueryBased": false,
    //  "Dependencies": [],
    //  "DefaultValues": [
    //    null
    //  ],
    //  "DefaultValuesIsNull": false,
    //  "ErrorMessage": null
    //}
}
