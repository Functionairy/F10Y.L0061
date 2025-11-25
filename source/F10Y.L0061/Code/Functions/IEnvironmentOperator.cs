using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0061
{
    [FunctionsMarker]
    public partial interface IEnvironmentOperator :
        L0001.L000.IEnvironmentOperator,
        L0060.IEnvironmentOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0001.L000.IEnvironmentOperator _L0001_L000 => L0001.L000.EnvironmentOperator.Instance;

        [Ignore]
        L0060.IEnvironmentOperator _L0060 => L0060.EnvironmentOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
