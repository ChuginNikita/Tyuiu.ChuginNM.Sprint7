using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ChuginNM.Sprint7.Project.V2
{
    public partial class formTypeSelection_CNM : Form
    {
        public TableType SelectedTableType { get; private set; }

        public formTypeSelection_CNM()
        {
            InitializeComponent();
        }

        private void radioButtonOwners_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOwners_CNM.Checked)
                SelectedTableType = TableType.Owners;
        }

        private void radioButtonStores_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStores_CNM.Checked)
                SelectedTableType = TableType.Stores;
        }

        private void radioButtonSuppliers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSuppliers_CNM.Checked)
                SelectedTableType = TableType.Suppliers;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public enum TableType
        {
            Owners,     // Тип 1
            Stores,     // Тип 2
            Suppliers   // Тип 3
        }
    }
}

