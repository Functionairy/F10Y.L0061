using System;


namespace F10Y.L0061.L000
{
    public class DateOnlyOperator : IDateOnlyOperator
    {
        #region Infrastructure

        public static IDateOnlyOperator Instance { get; } = new DateOnlyOperator();


        private DateOnlyOperator()
        {
        }

        #endregion
    }
}
