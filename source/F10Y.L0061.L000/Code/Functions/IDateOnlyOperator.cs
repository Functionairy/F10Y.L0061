using System;

using F10Y.T0002;


namespace F10Y.L0061.L000
{
    [FunctionsMarker]
    public partial interface IDateOnlyOperator :
        L0060.IDateOnlyOperator
    {
        /// <inheritdoc cref="L0001.L000.IDateTimeFormatTemplates.yyyyMMdd"/>
        string To_String_YYYYMMDD(DateOnly date)
            => this.Format(
                date,
                Instances.DateTimeFormatTemplates.yyyyMMdd);

        /// <inheritdoc cref="L0001.L000.IDateTimeFormatTemplates.yyyy_MM_dd_Dashed"/>
        string To_String_YYYY_MM_DD_Dashed(DateOnly date)
            => this.Format(
                date,
                Instances.DateTimeFormatTemplates.yyyy_MM_dd_Dashed);
    }
}
