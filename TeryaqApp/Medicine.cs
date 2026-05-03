using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teryaq
{
    enum MedicineType
    {
        None,
        Tablet,
        Syrup,
        Injection,
        Topical,
        Drops
    }

    internal class Medicine
    {
        //Feilds
        private string medName;
        private MedicineType medType;
        private int quantity;
        private string unit;
        private DateTime expiryDate;
        private bool isApproved = false;

        //Properties
        public string DonorEmail { get; set; }

        public string MedName
        {
            get { return medName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a medicine name!");
                }

                else
                {
                    value.ToLower();
                    value.Trim();
                    medName = value;
                }
            }
        }

        public MedicineType MedType
        {
            get { return medType; }

            set
            {
                if (value == MedicineType.None)
                {
                    throw new Exception("Please select a medicine type!");
                }

                medType = value;
                DetermineUnit(medType);
            }
        }

        public string Unit
        {
            get { return unit; }
        }

        public int Quantity
        {
            get { return quantity; }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Please enter a valid quantity!");
                }
                else
                { 
                    quantity = value;
                }
            }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }

            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new Exception("Please enter an expiry date!");
                }
                if (value <= DateTime.Now)
                {
                    throw new Exception("This medicine is already expired!");
                }
                else
                {
                    expiryDate = value;
                }

            }
        }

        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }

        //Metods
        public Medicine() { }
        public Medicine(string name, MedicineType type, DateTime expiry, int qty, bool approvedStatus)
        {
            MedName = name;
            Quantity = qty;
            MedType = type;
            ExpiryDate = expiry;
            IsApproved = approvedStatus;
        }

        private void DetermineUnit(MedicineType medType)
        {
            switch (medType)
            {
                case MedicineType.Tablet:
                    unit = "Tablet";
                    break;
                case MedicineType.Syrup:
                    unit = "Bottle";
                    break;
                case MedicineType.Injection:
                    unit = "Ampoule";
                    break;
                case MedicineType.Topical:
                    unit = "Tube";
                    break;
                case MedicineType.Drops:
                    unit = "Vial";
                    break;

            }
        }
    }

}
