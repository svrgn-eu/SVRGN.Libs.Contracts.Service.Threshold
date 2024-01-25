using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Threshold
{
    public interface IThreshold
    {
        #region Properties

        float Minimum { get; }
        float Maximum { get; }
        string Text { get; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
