using System;

namespace E4_11
{
    internal class Asset
    {
        private string assetName;
        private decimal assetValue;
        private decimal assetDepRate;

        private string Name
        {
            get { return assetName; }
            set { 
                assetName = value; 
            }
        }

        private decimal Value
        {
            get { return assetValue; }
            set { 
                if (assetValue >= 0){
                    assetValue = value;
                }
            }
        }

        private decimal Rate
        {
            get { return assetDepRate; }
            set {
                if (assetDepRate >= 0) {
                    assetDepRate = value;
                }
            }
        }

        public Asset(string assetName, decimal assetValue, decimal rate)
        {
            this.assetName = assetName;
            this.assetValue = assetValue;
            this.assetDepRate = rate;
        }

        public decimal CalculateDepreciation() {
            return assetValue * assetDepRate;
        }
        public decimal CalculateDepreciatedValue() {
            return assetValue - CalculateDepreciation();
        }
        public void IncreaseValueByPercentage(decimal percentage)
        {
            assetValue += assetValue * (percentage / 100);
        }
    }
}
