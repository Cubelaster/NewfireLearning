using System.Collections.Generic;

namespace Core.Models.Utility
{
    /// <summary>
    /// This one is made by example of EntityGridColumnConfig
    /// Basically, we need PropertyName and modifiers
    /// The logic is the same, it's just the inheritance system doesn't work like TypeScript
    /// </summary>
    public record FieldConfig
    {
        public string PropertyName { get; set; }

        // Initially shown basically
        public bool IsHidden { get; set; } = true;
        // If it is used in grid at all
        public bool IsExposed { get; set; } = true;
        // If editing is allowed
        public bool IsEditable { get; set; } = true;
        public bool ShowOnlyWhenItemExists { get; set; } = false;
        public bool ShowOnlyWhenItemNotExists { get; set; } = false;

        public List<string> Validators { get; set; }

    }
}
