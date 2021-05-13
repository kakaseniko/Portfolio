using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulesAndInterfaces
{
    [Serializable]
    public class EmployeeEmploymentInformation
    {

        //Properties
        public EmployeeDepartment EmployeeDepartment { get; private set; }
        private List<EmployeeContract> contracts = new List<EmployeeContract>();

        //Constructor

        public EmployeeEmploymentInformation(EmployeeDepartment employeeDepartment, EmployeeContract contract)
        {

            this.EmployeeDepartment = employeeDepartment;
            contracts = new List<EmployeeContract>();
            this.contracts.Add(contract);
            AssignContractNum(contract);
        }
        public EmployeeEmploymentInformation(EmployeeDepartment dep)
        {
            this.EmployeeDepartment = dep;
        }
        public EmployeeEmploymentInformation(EmployeeDepartment employeeDepartment, List<EmployeeContract> contracts)
        {
            this.EmployeeDepartment = employeeDepartment;
            this.contracts = contracts;
        }
        public EmployeeContract GetActiveContract()
        {
            foreach (EmployeeContract c in contracts)
            {
                if (c.IsActive)
                {
                    return c;
                }
            }
            return null;
        }
        public void EditActiveContract(EmployeeContract newcontract)
        {
            EmployeeContract oldcontract = GetActiveContract();
            contracts.Remove(oldcontract);
            contracts.Add(newcontract);
        }
        public EmployeeContract[] GetContractHistory()
        {
            return this.contracts.ToArray();
        }
        public void AddNewContract(EmployeeContract contract)
        {
            contracts.Add(contract);
            AssignContractNum(contract);
        }
        public void InitializeContractHistory(EmployeeContract contract)
        {
            contracts.Add(contract);

        }
        private void AssignContractNum(EmployeeContract contract)
        {
            contract.ContractNum = $"{contract.EmplNum}.{contracts.Count()}";
        }

    }
}
