namespace Content.Server.AU14.ThirdParty;

[RegisterComponent]
public sealed partial class ThirdPartyDropshipReturnDestinationComponent : Component
{
    [DataField(required: true)]
    public EntityUid Shuttle;
}

[RegisterComponent]
public sealed partial class ThirdPartyDropshipReturnedComponent : Component;

[RegisterComponent]
public sealed partial class ThirdPartyDropshipDeactivatedConsoleComponent : Component;
