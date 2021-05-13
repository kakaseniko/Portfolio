﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleParking
{
    public partial class StatisticsForm : Form
    {
        BicycleParking bp;
        public StatisticsForm(BicycleParking bp, string partialZipcode)
        {
            InitializeComponent();
            this.Text = $"Statistics for zipcode {partialZipcode}";
            this.bp = bp;
            lbxBicycles.Items.Clear();
            if(bp.GetAllRetrievedBicyclesByZipcode(partialZipcode) == null)
            {
                lbxBicycles.Items.Add("No data was found with this partial zipcode.");
            }
            else
            {
                foreach (Bicycle b in bp.GetAllRetrievedBicyclesByZipcode(partialZipcode))
                {
                    if (b != null)
                    {
                        lbxBicycles.Items.Add(b.GetInfo());
                    }
                    else
                    {
                        lbxBicycles.Items.Add("No data was found with this partial zipcode.");
                    }
                }
            }           
        }
       
    }
}
