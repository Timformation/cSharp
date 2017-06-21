using System;

namespace podAssignment
{
    public class pod
    {
        private string oCompanyName, oPartNumber;
        private int oQtyPurchased;
        private double oUnitPrice;
        private bool oDiscount;

        public string CompanyName
        {
            get
            {
                return oCompanyName;
            }

            set
            {
                oCompanyName = value;
            }
        }
        public string PartNumber
        {
            get
            {
                return oPartNumber;
            }

            set
            {
                oPartNumber = value;
            }

        }

        public int QtyPurchased
        {
            get
            {
                return oQtyPurchased;
            }

            set
            {
                oQtyPurchased = value;
            }

        }
        public double UnitPrice
        {
            get
            {
                return oUnitPrice;
            }

            set
            {
                oUnitPrice = value;
                
            }
        }
        public bool Discount
        {
            get
            {
                return oDiscount;
            }

            set
            {
                oDiscount = value;
            }
        }
    }
}

    
