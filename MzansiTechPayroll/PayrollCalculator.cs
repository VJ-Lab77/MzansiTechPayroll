using System;

namespace MzansiTechPayroll
{
    public class PayrollCalculator
    {
        private const decimal HourlyRate = 950.00m;
        private const decimal UIF_Rate = 0.01m;
        private const decimal MembershipRate = 0.13m;
        private const decimal PAYE_BaseRate = 0.25m;
        private const decimal PAYE_DependentDeduction = 0.0575m;

        public decimal CalculateGrossPay(decimal hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        public decimal CalculateUIF(decimal grossPay)
        {
            return grossPay * UIF_Rate;
        }

        public decimal CalculateMembershipFee(decimal grossPay)
        {
            return grossPay * MembershipRate;
        }

        public decimal CalculatePAYE(decimal grossPay, int dependents)
        {
            decimal dependentReduction = grossPay * PAYE_DependentDeduction * dependents;
            decimal taxableAmount = grossPay - dependentReduction;
            return taxableAmount * PAYE_BaseRate;
        }

        public decimal CalculateTotalDeductions(decimal uif, decimal paye, decimal membershipFee)
        {
            return uif + paye + membershipFee;
        }

        public decimal CalculateNetPay(decimal grossPay, decimal totalDeductions)
        {
            return grossPay - totalDeductions;
        }
    }
}