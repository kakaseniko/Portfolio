using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LogicLayer;
using ModulesAndInterfaces;

namespace MediaBazaarApp
{
    public partial class MediaBazaarForm : Form
    {
        private ProductManager pm;
        private EmployeeManager em;
        private Employee empl;
        private ShiftsManager sm;

        public MediaBazaarForm(EmployeeDepartment ed, Employee e)
        {

            InitializeComponent();

            pm = new ProductManager();
            em = new EmployeeManager();
            sm = new ShiftsManager();
            empl = e;

            sm.ReadShiftsFromDB();
            ShowFunctionalities(ed);
            FillProfileData(e);
            CheckHR();

            AppStartCheckEmployees();
            AppStartChecksProducts();

            FillComboboxesProdStat();
            UpdateComboboxDepartmentScheduleMaker();

        }

        #region EmployeeManagement
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void rbByName_CheckedChanged_1(object sender, EventArgs e)
        {
            tbxEMSearchName.Enabled = true;
            tbxEMSearchEmpNumber.Enabled = false;
            comboBoxDep.Enabled = false;
        }
        private void rbByNum_CheckedChanged(object sender, EventArgs e)
        {
            tbxEMSearchName.Enabled = false;
            tbxEMSearchEmpNumber.Enabled = true;
            comboBoxDep.Enabled = false;
        }
        private void rbByDepart_CheckedChanged(object sender, EventArgs e)
        {
            tbxEMSearchName.Enabled = false;
            tbxEMSearchEmpNumber.Enabled = false;
            comboBoxDep.Enabled = true;
        }

        private void btnEMSearch_Click(object sender, EventArgs e)
        {
            if (rbByName.Checked)
            {
                if (String.IsNullOrEmpty(tbxEMSearchName.Text))
                {
                    MessageBox.Show("Please fill in a name.");
                    return;
                }
                SearchByNameLVUpdate();
            }
            else if (rbByNum.Checked)
            {
                int num;
                if (!Int32.TryParse(tbxEMSearchEmpNumber.Text, out num))
                {
                    MessageBox.Show("Employee number must be numeric.");
                    return;
                }
                SearchByNumberLVUpdate();
            }
            else if (rbByDepart.Checked)
            {
                if (comboBoxDep.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select department.");
                    return;
                }
                SearchByDepLVUpdate();
            }
        }
        private void btnEditSelectedEmpl_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select employee.");
                return;
            }
            AddEmployee aef = new AddEmployee(em, (Employee)listViewEmployee.SelectedItems[0].Tag);
            aef.FormClosed += new FormClosedEventHandler(AddEmployee_Closed);
            aef.ShowDialog();
        }
        private void btnEMAddNewEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee aef = new AddEmployee(em);
            aef.FormClosed += new FormClosedEventHandler(AddEmployee_Closed);
            aef.ShowDialog();
        }

        //METHODS
        private void UpdateListView()
        {
            listViewEmployee.Items.Clear();
            foreach (Employee e in em.GetEmployees())
            {
                var row = new string[] { e.FirstName, e.LastName, e.EmployeeNumber.ToString(), e.employmentInfo.EmployeeDepartment.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = e;
                listViewEmployee.Items.Add(lvi);
            }
        }
        private void UpdateCBEmplDep()
        {
            comboBoxDep.DataSource = Enum.GetNames(typeof(EmployeeDepartment));
        }

        private void SearchByNameLVUpdate()
        {
            listViewEmployee.Items.Clear();
            foreach (Employee empl in em.SearchEmployeeByName(tbxEMSearchName.Text))
            {
                var row = new string[] { empl.FirstName, empl.LastName, empl.EmployeeNumber.ToString(), empl.employmentInfo.EmployeeDepartment.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = empl;
                listViewEmployee.Items.Add(lvi);
            }
        }
        private void SearchByNumberLVUpdate()
        {
            listViewEmployee.Items.Clear();
            if (em.SearchEmployeeByNumber(Convert.ToInt32(tbxEMSearchEmpNumber.Text)) == null)
            {
                listViewEmployee.Items.Add("No employee was found.");
                return;
            }
            Employee e = em.SearchEmployeeByNumber(Convert.ToInt32(tbxEMSearchEmpNumber.Text));
            var row = new string[] { e.FirstName, e.LastName, e.EmployeeNumber.ToString(), e.employmentInfo.EmployeeDepartment.ToString() };
            var lvi = new ListViewItem(row);
            lvi.Tag = e;
            listViewEmployee.Items.Add(lvi);
        }
        private void SearchByDepLVUpdate()
        {
            listViewEmployee.Items.Clear();
            foreach (Employee empl in em.SearchEmployeeByDepartment((EmployeeDepartment)comboBoxDep.SelectedIndex))
            {
                var row = new string[] { empl.FirstName, empl.LastName, empl.EmployeeNumber.ToString(), empl.employmentInfo.EmployeeDepartment.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = empl;
                listViewEmployee.Items.Add(lvi);
            }
        }
        private void AddEmployee_Closed(object sender, FormClosedEventArgs e)
        {
            UpdateListView();
        }
        private void AppStartCheckEmployees()
        {
            UpdateCBEmplDep();

            try
            {
                em.ReadEmployeesFromDB();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateListView();
            comboBoxDep.SelectedIndex = -1;
        }
        #endregion

        #region ProductManagement

        #region Buttons
        private void btnPMAddProduct_Click(object sender, EventArgs e)
        {
            ProductInformation formPI = new ProductInformation(pm, true, null);
            formPI.FormClosed += new FormClosedEventHandler(ProductInformationClosed);
            formPI.ShowDialog();
        }
        void ProductInformationClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePMLV();
            UpdateSMLV();
        }

        private void btnPMSearch_Click(object sender, EventArgs e)
        {
            if (rbtnPMName.Checked)
            {
                if (string.IsNullOrEmpty(tbxPMName.Text))
                { MessageBox.Show("Please input a name or partial name"); return; }
                PMSearchByName();
            }
            if (rbtnPMNumber.Checked)
            {
                int number;
                if (!Int32.TryParse(tbxPMNumber.Text, out number))
                { MessageBox.Show("Please input a number"); return; }
                PMSearchByNumber();
            }

            if (rbtnPMLocation.Checked)
            {
                if (cbxPMLocation.SelectedIndex == -1)
                { MessageBox.Show("Please select a department"); return; }
                PMSearchByLocation();
            }

            if (rbtnPMStock.Checked)
            {
                if (nudPMStock.Value < 0)
                { MessageBox.Show("Please input a positive number"); return; }
                PMSearchByStock();
            }
            if (rbtnPMShowAll.Checked)
            { }
        }

        private void btnPMEditSelectedLV_Click(object sender, EventArgs e)
        {
            if (lvPMProducts.SelectedItems.Count > 0)
            {
                Product selectedProduct = (Product)lvPMProducts.SelectedItems[0].Tag;
                ProductInformation formPI = new ProductInformation(pm, false, selectedProduct);
                formPI.FormClosed += new FormClosedEventHandler(ProductInformationClosed);
                formPI.ShowDialog();
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }
        private void btnRemoveFromLV_Click(object sender, EventArgs e)
        {
            if (lvPMProducts.SelectedItems.Count > 0)
            {
                Product selectedProduct = (Product)lvPMProducts.SelectedItems[0].Tag;
                foreach (Product p in pm.GetAllProducts().ToList())
                {
                    if (p.Number == selectedProduct.Number)
                    {
                        pm.RemoveProduct(p);
                    }
                }
                UpdatePMLV();
                UpdateSMLV();
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }

        private void btnPMShowInactiveProducts_Click(object sender, EventArgs e)
        {
            ProductInactive pi = new ProductInactive(pm);
            pi.FormClosed += new FormClosedEventHandler(ProductInactiveClosed);
            pi.ShowDialog();
        }

        void ProductInactiveClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePMLV();
            UpdateSMLV();
        }

        private void btnPMRequest_Click(object sender, EventArgs e)
        {
            int amount = 0;
            if (nudPMRequestAmount.Value > 0)
            { amount = Convert.ToInt32(nudPMRequestAmount.Value); }
            else
            { MessageBox.Show("Please input a positive number"); return; }
            if (lvPMProducts.SelectedItems.Count > 0)
            {
                Product selectedProduct = (Product)lvPMProducts.SelectedItems[0].Tag;
                foreach (Product p in pm.GetAllProducts().ToList())
                {
                    if (p.Number == selectedProduct.Number)
                    {
                        pm.AddProductToRequestList(p, amount);
                        UpdateSMStoreLV();
                        MessageBox.Show($"{p.AmountRequested} - {p.Name}'s have been requested!");
                    }
                }
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }

        #endregion

        #region Methods

        private void UpdatePMCBB()
        {
            cbxPMLocation.DataSource = Enum.GetNames(typeof(Location));
        }

        private void PMSearchByName()
        {
            lvPMProducts.Items.Clear();
            string partialName = tbxPMName.Text;
            if (pm.SearchProducts(partialName).Count > 0)
            { UpdateListViewPM(pm.SearchProducts(partialName)); }
            else
            { lvPMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void PMSearchByNumber()
        {
            lvPMProducts.Items.Clear();
            int number = Convert.ToInt32(tbxPMNumber.Text);
            if (pm.SearchProducts(number).Count > 0)
            { UpdateListViewPM(pm.SearchProducts(number)); }
            else
            { lvPMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void PMSearchByLocation()
        {
            lvPMProducts.Items.Clear();
            Location location = (Location)cbxPMLocation.SelectedIndex;
            if (pm.SearchProducts(location).Count > 0)
            { UpdateListViewPM(pm.SearchProducts(location)); }
            else
            { lvPMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void PMSearchByStock()
        {
            lvPMProducts.Items.Clear();
            int threshold = Convert.ToInt32(nudPMStock.Value);
            if (pm.FindLowOnStoreProducts(pm.GetAllProducts(), threshold).Count > 0)
            { UpdateListViewPM(pm.FindLowOnStockProducts(pm.GetAllProducts(), threshold)); }
        }

        private void SMSearchByName()
        {
            lvSMProducts.Items.Clear();
            string partialName = tbxSMName.Text;
            if (pm.SearchProducts(partialName).Count > 0)
            { UpdateListViewSM(pm.SearchProducts(partialName)); }
            else
            { lvSMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void SMSearchByNumber()
        {
            lvSMProducts.Items.Clear();
            int number = Convert.ToInt32(tbxSMNumber.Text);
            if (pm.SearchProducts(number).Count > 0)
            { UpdateListViewSM(pm.SearchProducts(number)); }
            else
            { lvSMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void SMSearchByLocation()
        {
            lvSMProducts.Items.Clear();
            Location location = (Location)cbxSMLocation.SelectedIndex;
            if (pm.SearchProducts(location).Count > 0)
            { UpdateListViewSM(pm.SearchProducts(location)); }
            else
            { lvSMProducts.Items.Add(new ListViewItem("Not found")); }
        }

        private void UpdatePMLV()
        {
            UpdateListViewPM(pm.GetAllProducts());
        }

        private void UpdateListViewPM(List<Product> list)
        {
            lvPMProducts.Items.Clear();
            foreach (Product p in list)
            {
                if (p.IsActive)
                {
                    var row = new string[]
                        {p.Name, p.Number.ToString(), p.Location.ToString(), p.AmountInStore.ToString()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    lvPMProducts.Items.Add(lvi);
                }
            }
        }

        private void UpdateListViewSM(List<Product> list)
        {
            lvSMProducts.Items.Clear();
            foreach (Product p in list)
            {
                if (p.IsActive)
                {
                    var row = new string[]
                        {p.Name, p.Number.ToString(), p.Location.ToString(), p.AmountInStock.ToString(), p.AmountInStore.ToString()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    lvSMProducts.Items.Add(lvi);
                }
            }
        }

        #endregion

        #region RadioButtonsEvents

        //Method for all
        private void PMWhatsEnabled()
        {
            tbxPMName.Enabled = false;
            tbxPMNumber.Enabled = false;
            cbxPMLocation.Enabled = false;
            nudPMStock.Enabled = false;

            if (rbtnPMName.Checked)
            { tbxPMName.Enabled = true; }
            if (rbtnPMNumber.Checked)
            { tbxPMNumber.Enabled = true; }
            if (rbtnPMLocation.Checked)
            { cbxPMLocation.Enabled = true; }
            if (rbtnPMStock.Checked)
            { nudPMStock.Enabled = true; }
            //if (rbtnPMShowAll.Checked)
            //{}
        }
        private void rbtnPMShowAll_CheckedChanged(object sender, EventArgs e)
        {
            PMWhatsEnabled();
            UpdatePMLV();
        }

        private void rbtnPMName_CheckedChanged(object sender, EventArgs e)
        {
            PMWhatsEnabled();
        }

        private void rbtnPMNumber_CheckedChanged(object sender, EventArgs e)
        {
            PMWhatsEnabled();
        }

        private void rbtnPMLocation_CheckedChanged(object sender, EventArgs e)
        {
            PMWhatsEnabled();
        }

        private void rbtnPMStock_CheckedChanged(object sender, EventArgs e)
        {
            PMWhatsEnabled();
        }

        #endregion

        #endregion

        #region Stock Management

        #region Buttons

        private void btnSMSearch_Click(object sender, EventArgs e)
        {
            lvSMProducts.Items.Clear();
            if (rbtnSMName.Checked)
            {
                if (string.IsNullOrEmpty(tbxSMName.Text))
                { MessageBox.Show("Please input a name or partial name"); return; }
                SMSearchByName();
            }
            if (rbtnSMNumber.Checked)
            {
                int number;
                if (!Int32.TryParse(tbxSMNumber.Text, out number))
                { MessageBox.Show("Please input a number"); return; }
                SMSearchByNumber();
            }

            if (rbtnSMLocation.Checked)
            {
                if (cbxSMLocation.SelectedIndex == -1)
                { MessageBox.Show("Please select a department"); return; }
                SMSearchByLocation();
            }

            if (rbtnPMShowAll.Checked)
            { UpdateSMLV(); }
        }

        private void btnSMSetStockAmountLV_Click(object sender, EventArgs e)
        {
            Product selectedProduct = null;
            int amount = 0;

            if (lvSMProducts.SelectedItems.Count > 0)
            {
                selectedProduct = (Product)lvSMProducts.SelectedItems[0].Tag;
                amount = Convert.ToInt32(nudSMSetAmountInStock.Value);
                selectedProduct.EditAmountStock(amount);
                pm.EditProduct(selectedProduct);
                UpdateSMLV();
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }

        private void btnSMRemoveAmountFromStoreLV_Click(object sender, EventArgs e)
        {
            Product selectedProduct = null;
            int amount = 0;

            if (lvSMProducts.SelectedItems.Count > 0)
            {
                selectedProduct = (Product)lvSMProducts.SelectedItems[0].Tag;
                amount = Convert.ToInt32(nudSMRemoveFromStore.Value);
                DateTime time = dtpRemoveAmountFromStore.Value;
                string month = time.Month.ToString();
                int year = Convert.ToInt32(time.Year);
                if (amount <= selectedProduct.AmountInStore)
                {
                    selectedProduct.RemoveAmountStore(amount, month, year);
                    pm.EditProduct(selectedProduct);
                    pm.AddSalesInfoToDB(selectedProduct);
                    UpdateSMLV();
                }
                else
                { MessageBox.Show("There is not enough amount in store to remove this number"); }
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }

        private void btnSMMoveStockToStore_Click(object sender, EventArgs e)
        {
            Product selectedProduct = null;
            int amount = 0;

            if (lvSMStoreRequests.SelectedItems.Count > 0)
            {
                selectedProduct = (Product)lvSMStoreRequests.SelectedItems[0].Tag;
                amount = selectedProduct.AmountRequested;
                if (amount <= selectedProduct.AmountInStock)
                {
                    selectedProduct.RemoveAmountStock(amount);
                    selectedProduct.AddAmountStore(amount);
                    selectedProduct.RemoveAmountRequested(amount);
                    pm.EditProduct(selectedProduct);
                    pm.GetRequestedProductsList().Remove(selectedProduct);
                    UpdateSMStoreLV();
                    UpdateSMLV();
                    UpdatePMLV();
                    //foreach (ListViewItem eachItem in lvSMStoreRequests.SelectedItems)
                    //{
                    //    lvSMStoreRequests.Items.Remove(eachItem);
                    //}
                    MessageBox.Show($"Stock has been moved to the store");
                }
                else
                { MessageBox.Show("There is not enough amount in stock for this request. Add to the stock first"); }
            }
            else
            { MessageBox.Show("Please select a product first"); }
        }


        #endregion

        #region Methods

        private void UpdateSMCBB()
        {
            cbxSMLocation.DataSource = Enum.GetNames(typeof(Location));
        }

        private void UpdateSMLV()
        {
            lvSMProducts.Items.Clear();
            UpdateListViewSM(pm.GetAllProducts());
        }

        private void UpdateSMStoreLV()
        {
            lvSMStoreRequests.Items.Clear();
            foreach (Product p in pm.GetRequestedProducts())
            {
                if (p.IsActive)
                {
                    var row = new string[]
                        {p.Name, p.AmountRequested.ToString()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    lvSMStoreRequests.Items.Add(lvi);
                }
            }
        }

        private void UpdateSMStoreLVStart()
        {
            lvSMStoreRequests.Items.Clear();
            foreach (Product p in pm.GetRequestedProducts())
            {
                if (p.IsActive)
                {
                    var row = new string[]
                        {p.Name, p.AmountRequested.ToString()};
                    var lvi = new ListViewItem(row);
                    lvi.Tag = p;
                    lvSMStoreRequests.Items.Add(lvi);
                }
            }
        }
        #endregion

        #region RadioButtonEvents

        //Method for all
        private void SMWhatsEnabled()
        {
            tbxSMName.Enabled = false;
            tbxSMNumber.Enabled = false;
            cbxSMLocation.Enabled = false;

            if (rbtnSMName.Checked)
            { tbxSMName.Enabled = true; }
            if (rbtnSMNumber.Checked)
            { tbxSMNumber.Enabled = true; }
            if (rbtnSMLocation.Checked)
            { cbxSMLocation.Enabled = true; }
            if (rbtnSMShowAll.Checked)
            { }
        }

        private void rbtnSMShowAll_CheckedChanged(object sender, EventArgs e)
        {
            SMWhatsEnabled();
            UpdateSMLV();
        }

        private void rbtnSMName_CheckedChanged(object sender, EventArgs e)
        {
            SMWhatsEnabled();
        }

        private void rbtnSMNumber_CheckedChanged(object sender, EventArgs e)
        {
            SMWhatsEnabled();
        }

        private void rbtnSMLocation_CheckedChanged(object sender, EventArgs e)
        {
            SMWhatsEnabled();
        }


        #endregion

        #endregion

        #region Profile


        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxOldPassword.Text) || String.IsNullOrEmpty(tbxNewPassword.Text))
            {
                MessageBox.Show("Fill in the required fields!");
            }
            else
            {
                string oldPass = tbxOldPassword.Text;
                string newPass = tbxNewPassword.Text;

                if (empl.personalInfo.Password == oldPass)
                {
                    if (oldPass == newPass)
                    {
                        MessageBox.Show("New password is the same as old password!");
                    }
                    else
                    {
                        em.EditEmployeePassword(empl, newPass);
                        tbxNewPassword.Clear();
                        tbxOldPassword.Clear();
                        MessageBox.Show("Password is changed!");
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect!");
                }
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void FillProfileData(Employee empl)
        {
            tbxProfileFirstName.Text = empl.FirstName;
            tbxProfileLastName.Text = empl.LastName;
            dtpProfileDateOfBirth.Value = empl.personalInfo.DateOfBirth;
            tbxProfilePhoneNumber.Text = empl.personalInfo.PhoneNumber;
            tbxProfileBSN.Text = empl.personalInfo.BSN;
            tbxProfileEmail.Text = empl.personalInfo.Email;
            tbxProfileEmergencyName.Text = empl.personalInfo.ICEName;
            tbxProfileEmergencyPhone.Text = empl.personalInfo.ICEPhone;
            tbxProfileCity.Text = empl.personalInfo.Address.City;
            tbxProfileStreetName.Text = empl.personalInfo.Address.StreetName;
            tbxProfileStreetNumber.Text = empl.personalInfo.Address.StreetNum.ToString();
            tbxProfileStreetNrAddition.Text = empl.personalInfo.Address.StreetNumAddition;
            tbxProfilePostalCode.Text = empl.personalInfo.Address.Postcode;
            if (empl.employmentInfo.GetActiveContract() != null)
            {
                EmployeeContract employeeContract = empl.employmentInfo.GetActiveContract();
                numericUpDownHoursPerWeek.Value = Convert.ToDecimal(employeeContract.FTE);
                numericUpDownSalary.Value = Convert.ToDecimal(employeeContract.Salary);
                dtpStartDate.Value = employeeContract.StartDate;
                lblHours.Text = $"Hours/week: {employeeContract.FTE * 40}";
            }
        }

        #endregion

        #region Schedule
        #region Methods

        private void UpdateComboboxDepartmentScheduleMaker()
        {
            cbxSchedDepartment.DataSource = Enum.GetNames(typeof(EmployeeDepartment));
        }

        private DateTime CalculateMondayDate() //calculates which date is monday on that week and returns monday date 
        {
            DateTime dt = dtpSchedDate.Value;

            if(dt.DayOfWeek == DayOfWeek.Monday)
            {
                
            }
            else if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                dt = dt.AddDays(-1);
            }
            else if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                dt = dt.AddDays(-2);
            }
            else if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                dt = dt.AddDays(-3);
            }
            else if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                dt = dt.AddDays(-4);
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                dt = dt.AddDays(-5);
            }
            else if (dt.DayOfWeek == DayOfWeek.Sunday )
            {
                dt = dt.AddDays(-6);
            }


            return dt;
            
        }


        private DateTime GetSelectedDateTime()
        {
            int rowindex = 0;
            int columnindex = 0;
            DateTime selectedDate = CalculateMondayDate();
            if (dgvSchedule.CurrentCell.RowIndex > -1 && dgvSchedule.CurrentCell.ColumnIndex > -1)
            {
                rowindex = dgvSchedule.CurrentCell.RowIndex;
                columnindex = dgvSchedule.CurrentCell.ColumnIndex;
                if (columnindex == 2)
                {
                    selectedDate = selectedDate.AddDays(1);
                }
                if (columnindex == 3)
                {
                    selectedDate = selectedDate.AddDays(2);
                }
                if (columnindex == 4)
                {
                    selectedDate = selectedDate.AddDays(3);
                }
                if (columnindex == 5)
                {
                    selectedDate = selectedDate.AddDays(4);
                }
                if (columnindex == 6)
                {
                    selectedDate = selectedDate.AddDays(5);
                }
                if (columnindex == 7)
                {
                    selectedDate = selectedDate.AddDays(6);
                }
            }
            else
            {
                MessageBox.Show("Please select a cell first");
            }
            return selectedDate;
        }

        

        ShiftType selectedshift;

        private ShiftType GetSelectedShiftType()
        {
            int rowindex = 0;
            int columnindex = 0;
            if (dgvSchedule.CurrentCell.RowIndex > -1 && dgvSchedule.CurrentCell.ColumnIndex > -1)
            {
                rowindex = dgvSchedule.CurrentCell.RowIndex;
                columnindex = dgvSchedule.CurrentCell.ColumnIndex;
                if (rowindex == 1)
                {
                    selectedshift = ShiftType.Morning;
                }
                if (rowindex == 2)
                {
                    selectedshift = ShiftType.Afternoon;
                }
                if (rowindex == 3)
                {
                    selectedshift = ShiftType.Evening;
                }

            }
            else
            {
                MessageBox.Show("Please select a cell first");
            }
            return selectedshift;
        }

        private List<Employee> GetEmployeesForAShift(DateTime date, ShiftType shifttype)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Shift s in sm.GetShifts())
            {
                if (s.DateTime.Date == date && s.ShiftType == shifttype)
                {
                    employees.Add(s.Employee);

                }
            }

            return employees;

        }
       

        //private void 

        #endregion


        #region Events
        private void dtpSchedDate_ValueChanged(object sender, EventArgs e) //creates the table according to the date selected on datetimepicker 
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.Rows.Clear();


            DateTime date = CalculateMondayDate();

            lblSchedWeek.Text = $"Week {date.ToString("dd-MM-yyyy")} - {(date.AddDays(6)).ToString("dd-MM-yyyy")}";

            dgvSchedule.ColumnCount = 8;
            dgvSchedule.Columns[0].Name = "Shifts/Days";
            dgvSchedule.Columns[1].Name = $"{date.DayOfWeek}  {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[2].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[3].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[4].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[5].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[6].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";
            date = date.AddDays(1);
            dgvSchedule.Columns[7].Name = $"{date.DayOfWeek} {date.ToShortDateString()}";



            date = CalculateMondayDate();


            string[] row = new string[] { "Morning", $"{GetEmployeesForAShift(date.Date, ShiftType.Morning).Count} / 10", $"{GetEmployeesForAShift(date.Date.Date.AddDays(1), ShiftType.Morning).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(2), ShiftType.Morning).Count}", $"{GetEmployeesForAShift(date.AddDays(3), ShiftType.Morning).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(4), ShiftType.Morning).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(5), ShiftType.Morning).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(6), ShiftType.Morning).Count}" };  
            dgvSchedule.Rows.Add(row);
            row = new string[] { $"Afternoon", $"{GetEmployeesForAShift(date.Date, ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(1), ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(2), ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.AddDays(3), ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(4), ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(5), ShiftType.Afternoon).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(6), ShiftType.Afternoon).Count}" };
            dgvSchedule.Rows.Add(row);
            row = new string[] { $"Evening", $"{GetEmployeesForAShift(date.Date, ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(1), ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(2), ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.AddDays(3), ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(4), ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(5), ShiftType.Evening).Count}", $"{GetEmployeesForAShift(date.Date.AddDays(6), ShiftType.Evening).Count}" };
            dgvSchedule.Rows.Add(row);



        }
        

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e) //row 1 = morning . column 1 == monday
        {
            //getting the date 
            lblTest.Text = GetSelectedDateTime().ToString("dd-MM-yyyy");

        }


        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //string employeename = dgvSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() ;

            lblSchedDay.Text = GetSelectedDateTime().ToString("dd-MM-yyyy");
            DateTime date = GetSelectedDateTime();

            lbxDayWorkers.Items.Clear(); 

            foreach(Employee s in GetEmployeesForAShift(date.Date, GetSelectedShiftType()))
            {

                lbxDayWorkers.Items.Add(s);

            }




        }

        private void btnSchedAssign_Click(object sender, EventArgs e)
        {

            //Employee Data
            //ShiftType Data getshiftype() 
            //Date Data 

            if (sm.AddShift(new Shift((EmployeeDepartment)cbxSchedDepartment.SelectedIndex, (Employee)cbxSchedEmployee.SelectedItem, GetSelectedDateTime(), GetSelectedShiftType())))
            {
                MessageBox.Show("Succesfully added shift");
            }
            else
            {
                MessageBox.Show("You can't same shift");
            }

        }


        private void dgvSchedule_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {




        }

        private void CbxSchedDepartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EmployeeDepartment ed = (EmployeeDepartment)Enum.Parse(typeof(EmployeeDepartment), cbxSchedDepartment.SelectedValue.ToString());
            List<Employee> employees = sm.GetEmployeesFromDep(ed);
            cbxSchedEmployee.Items.Clear();
            foreach (Employee em in employees)
            {
                cbxSchedEmployee.Items.Add(em);
            }
        }


        #endregion
        #endregion

        #region Ryan Methods

        private void AppStartChecksProducts()
        {
            ProductInsertStart();
            UpdatePMCBB();
            UpdateSMCBB();
            UpdatePMLV();
            UpdateSMLV();
            UpdateSMStoreLV();
            //UpdateSMStoreLVStart();
            cbxPMLocation.SelectedIndex = -1;
            cbxSMLocation.SelectedIndex = -1;
        }

        private void ProductInsertStart()
        {
            pm.ReadProductsFromDB();
            //foreach (Product p in pm.GetAllProducts())
            //{
            //    if (p.AmountRequested > 0)
            //    {
            //        pm.AddProductToRequestList(p);
            //    }
            //    pm.AddProduct(p);
            //}
        }


        #endregion

        #region ProductStatistics
        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Enabled = true;
        }
        private void rbUnselect_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Enabled = false;
        }
        private void rbTop10Products_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownThershold.Enabled = false;
        }
        private void rbAllProductStat_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownThershold.Enabled = false;
        }
        private void rbProductNumStat_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownThershold.Enabled = false;
        }
        private void rbThershold_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownThershold.Enabled = true;
        }
        private void btnShowStat_Click(object sender, EventArgs e)
        {
            List<Product> firstFiltered = new List<Product>();
            if (rbMonth.Checked)
            {
                firstFiltered = pm.FilterSalesInfoByYearOrMonth(Convert.ToInt32(comboBoxYear.SelectedItem), comboBoxMonth.SelectedItem.ToString());
            }
            else
            {
                firstFiltered = pm.FilterSalesInfoByYearOrMonth(Convert.ToInt32(comboBoxYear.SelectedItem), null);
            }
            if (rbAllProductStat.Checked)
            {
                if (checkBoxFilterDep.Checked)
                {
                    UpdateListViewStat(pm.FilterByLocation(firstFiltered, (Location)comboBoxDepStat.SelectedIndex));
                }
                else
                {
                    UpdateListViewStat(firstFiltered);
                }
            }
            else if (rbTop10Products.Checked)
            {
                if (checkBoxFilterDep.Checked)
                {
                    UpdateListViewStat(pm.FilterByLocation(pm.FindTopSellingProducts(firstFiltered), (Location)comboBoxDepStat.SelectedIndex));
                }
                else
                {
                    UpdateListViewStat(pm.FindTopSellingProducts(firstFiltered));
                }
            }
            else if (rbThershold.Checked)
            {
                if (checkBoxFilterDep.Checked)
                {
                    UpdateListViewStat(pm.FilterByLocation(pm.FindLowOnStockProducts(firstFiltered, Convert.ToInt32(numericUpDownThershold.Value)), (Location)comboBoxDepStat.SelectedIndex));
                }
                else
                {
                    UpdateListViewStat(pm.FindLowOnStockProducts(firstFiltered, Convert.ToInt32(numericUpDownThershold.Value)));
                }
            }
            lblTotalRev.Text = $"Total revenue: €{pm.GetTotalRevenue(firstFiltered)}";
            lblTotalProfit.Text = $"Total profit: €{pm.GetTotalProfit(firstFiltered)}";
            btnShowStat.Enabled = false;
        }
        private void btnProdStatFirstNext_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select year.");
                return;
            }
            if (rbMonth.Checked && comboBoxMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select month.");
                return;
            }
            //enable second panel
            rbAllProductStat.Enabled = true;
            rbTop10Products.Enabled = true;
            rbThershold.Enabled = true;
            btnProdStatSecondNext.Enabled = true;

            //disable first panel
            comboBoxYear.Enabled = false;
            comboBoxMonth.Enabled = false;
            rbMonth.Enabled = false;
            rbUnselect.Enabled = false;
            btnProdStatFirstNext.Enabled = false;

        }

        private void btnProdStatSecondNext_Click(object sender, EventArgs e)
        {

            //disable second panel
            rbAllProductStat.Enabled = false;
            rbTop10Products.Enabled = false;
            rbThershold.Enabled = false;
            btnProdStatSecondNext.Enabled = false;
            numericUpDownThershold.Enabled = false;
            //enable thrid panel plus statistics button
            checkBoxFilterDep.Enabled = true;
            comboBoxDepStat.Enabled = true;
            btnShowStat.Enabled = true;
            btnResetFilters.Enabled = true;

        }
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            //disable third panel and show stat button
            checkBoxFilterDep.Enabled = false;
            comboBoxDepStat.Enabled = false;
            btnShowStat.Enabled = false;
            //enable first panel
            comboBoxYear.Enabled = true;
            comboBoxMonth.Enabled = true;
            rbMonth.Enabled = true;
            rbUnselect.Enabled = true;
            btnProdStatFirstNext.Enabled = true;
            rbAllProductStat.Checked = true;
        }

        //METHODS
        private void FillComboboxesProdStat()
        {
            comboBoxYear.Items.Clear();
            foreach (Product p in pm.GetAllProducts())
            {
                if (p.GetProductSalesInfos() != null)
                {
                    foreach (ProductSalesInfo psi in p.GetProductSalesInfos())
                    {
                        if (!comboBoxYear.Items.Contains(psi.Year))
                        {
                            comboBoxYear.Items.Add(psi.Year);
                        }
                    }
                }
            }
        }
        private void UpdateListViewStat(List<Product> products)
        {
            listViewStatProducts.Items.Clear();
            foreach (Product p in products)
            {
                var row = new string[] { p.Number.ToString(), p.Name.ToString(), p.Model.ToString(), p.CalculateRevenue().ToString(), p.CalculateProfit().ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = p;
                listViewStatProducts.Items.Add(lvi);
            }
        }

        #endregion

        #region something 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void ShowFunctionalities(EmployeeDepartment edp)
        {
            if (edp == EmployeeDepartment.CostumerService || edp == EmployeeDepartment.Sales)
            {
                tabControl1.Controls.Remove(tbpEmployeeManagement);
                tabControl1.Controls.Remove(tbpScheduleMaker);
                tabControl1.Controls.Remove(tbpProductManagement);
                tabControl1.Controls.Remove(tbpStockManagement);
            }
            else if (edp == EmployeeDepartment.Depo)
            {

                tabControl1.Controls.Remove(tbpEmployeeManagement);
                tabControl1.Controls.Remove(tbpScheduleMaker);
            }
            else if (edp == EmployeeDepartment.HR)
            {
                tabControl1.Controls.Remove(tbpProductManagement);
                tabControl1.Controls.Remove(tbpStockManagement);
                grpbxContactHR.Visible = false;
            }
        }

        private void CheckHR()
        {
            foreach (Employee e in em.GetEmployees())
            {
                if (e.employmentInfo.EmployeeDepartment == EmployeeDepartment.HR)
                {
                    lbxHRempl.Items.Add(e.ToStringHR());
                }
            }
        }
        

        
        
        #endregion

    }
}
