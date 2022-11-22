namespace Core.Resources
{
    public class ValidationResources
    {
        public static string PropertyName => nameof(PropertyName);
        public static string DateRange => nameof(DateRange);
        public static string Date => nameof(Date);

        public static string IdentificatorRequired => nameof(IdentificatorRequired);

        public static string ParameterWithValue => nameof(ParameterWithValue);

        public static string PropertyGreaterThan => nameof(PropertyGreaterThan);
        public static string PropertyLength => nameof(PropertyLength);
        public static string PropertyLengthExact => nameof(PropertyLengthExact);
        public static string PropertyNotAllowedToChange => nameof(PropertyNotAllowedToChange);
        public static string PropertyRequired => nameof(PropertyRequired);

        public static string UniqueConstraintBroken => nameof(UniqueConstraintBroken);

        public static string PostalCodeUXBroken => nameof(PostalCodeUXBroken);
        public static string PostalCodeUXCodeExists => nameof(PostalCodeUXCodeExists);
        public static string TaxGroupUXBroken => nameof(TaxGroupUXBroken);
        public static string CountryUXBroken => nameof(CountryUXBroken);
        public static string DateRangeOverlap => nameof(DateRangeOverlap);

        public static string EntryAlreadyExists => nameof(EntryAlreadyExists);

        public static string AtLeastOneRequired => nameof(AtLeastOneRequired);

        public static string DecimalPlacesSettingsUXBroken => nameof(DecimalPlacesSettingsUXBroken);
        public static string ValueNotAllowed => nameof(ValueNotAllowed);

        public static string DocumentDeletionNotAllowedNotLastDocument => nameof(DocumentDeletionNotAllowedNotLastDocument);
        public static string DocumentModificationNotAllowedHasChildren => nameof(DocumentModificationNotAllowedHasChildren);

        public static string DeleteNotPossibleExistingDependencies => nameof(DeleteNotPossibleExistingDependencies);
        public static string DeleteNotPossibleExistingDependenciesWithDependenciesList => nameof(DeleteNotPossibleExistingDependenciesWithDependenciesList);
        public static string UpdateNotPossibleExistingDependenciesWithDependenciesList => nameof(UpdateNotPossibleExistingDependenciesWithDependenciesList);
    }
}
