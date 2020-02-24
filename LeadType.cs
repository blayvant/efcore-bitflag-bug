using System;

namespace EfCoreBitflagBug
{
    [Flags]
    public enum LeadType
    {
        PremiumContent = 1,
        ActiveProjectLeads = 2,
        Product = 4,
        ContactRequest = 8,
        Shared = 16,
        Download = 32,
        InternalHelpRequest = 64,
        Article = 128
    }
}