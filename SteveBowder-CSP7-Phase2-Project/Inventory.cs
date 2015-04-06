using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteveBowder_CSP7_Phase2_Project
{
    class Inventory
    {
        private string _partName, _partNumber;
        private decimal _cost, _price;
        private double _markUpPct;

        public Inventory(string partName, string partNum, decimal cost, double markUpPercent)
        {
            this.PartName = partName;
            this.PartNumber = partNum;
            this.Cost = cost;
            this.MarkUpPct = markUpPercent;
        }

        public string PartName
        {
            get
            {
                return _partName;
            }
            set
            {
                _partName = value;
            }
        }

        public string PartNumber
        {
            get
            {
                return _partNumber;
            }
            set
            {
                _partNumber = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Bad _cost value: " + value.ToString());
                    _cost = value * -1;
                }
                else
                {
                    _cost = value;
                }
            }
        }

        public double MarkUpPct
        {
            get
            {
                return _markUpPct;
            }
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Bad _markUpPct value: " + value.ToString());
                    _markUpPct = value * -1;
                }
                else
                {
                    _markUpPct = value;
                }
                
            }
        }

        public decimal Price
        {
            get
            {
                decimal markUpAmount = this.Cost * (decimal)this.MarkUpPct;

                _price = this.Cost + markUpAmount;

                return _price;
            }
        }
    }
}
