﻿using System.Windows.Forms;

namespace ClinicSupport.UserControls
{
    /// <summary>
    /// Usercontrol to update lab tests
    /// </summary>
    public partial class UpdateLabTestUserControl : UserControl
    {
        /// <summary>
        /// 0-parameter constructor for UpdateLabTestUserControl
        /// </summary>
        public UpdateLabTestUserControl()
        {
            InitializeComponent();
            orderTestUserControl1.ForUpdatingTests();
        }
    }
}