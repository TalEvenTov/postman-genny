namespace PostmanGenny.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Method 
        | AttributeTargets.Parameter 
        | AttributeTargets.ReturnValue, 
        AllowMultiple = false, Inherited = true)]
    public sealed class PMDescriptionAttribute : Attribute
    {
        private readonly string _description;
        
        public PMDescriptionAttribute(string description)
        {
            _description = description;
        }

        public string Description => _description;
    }
}