using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Threshold
{
    public interface IThresholdService
    {
        #region Properties

        List<IThreshold> Thresholds { get; }
        string DefaultText { get; }

        #endregion Properties

        #region Methods

        void SetDefaultText(string NewText);
        string GetText(float Value);
        bool Add(IThreshold Threshold);
        void Clear();

        #endregion Methods
    }
}
