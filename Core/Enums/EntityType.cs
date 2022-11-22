namespace Core.Enums
{
    public enum EntityType
    {
        Undefined = 0,
        AppClaim = 1,
        AppClaimGroup = 2,
        Role = 3,
        Company = 4,
        User = 5,

        Workspace = 6,

        #region Codebooks

        #endregion Codebooks

        #region EntityConnectors

        EntityContact = 300,
        EntityNote = 301,

        #endregion EntityConnectors

        #region AppCodes

        AppCode = 500,

        #endregion AppCodes

        #region Config

        EntityGridColumnConfig = 600,
        EntityReport = 601,

        #endregion Config

        #region Audit

        ApplicationActionDefinition = 800,
        ApplicationAction = 801,
        AuditLog = 802

        #endregion Audit        
    }
}