using System;

namespace Core.Enums
{
    public enum ReportingServiceParameterTypeEnum
    {
        Undefined,
        String,
        Integer,
        DateTime,
        Float
    }

    public static class ReportingServiceParameterTypeEnumExtensions
    {
        public static ReportingServiceParameterTypeEnum DetermineDataTypeForStoredProcedureParam(this string value)
        {
            if (value.Contains("int", StringComparison.OrdinalIgnoreCase))
            {
                return ReportingServiceParameterTypeEnum.Integer;
            }
            else if (value.Contains("date", StringComparison.OrdinalIgnoreCase))
            {
                return ReportingServiceParameterTypeEnum.DateTime;
            }
            else if (value.Contains("decimal", StringComparison.OrdinalIgnoreCase))
            {
                return ReportingServiceParameterTypeEnum.Float;
            }
            else if (value.Contains("string", StringComparison.OrdinalIgnoreCase)
                || value.Contains("nvarchar", StringComparison.OrdinalIgnoreCase))
            {
                return ReportingServiceParameterTypeEnum.String;
            }
            else
            {
                return ReportingServiceParameterTypeEnum.Undefined;
            }
        }
    }
}
