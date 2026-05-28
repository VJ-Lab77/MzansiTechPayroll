using Microsoft.VisualStudio.TestTools.UnitTesting;
using MzansiTechPayroll;

namespace MzansiTechsPayroll.Tests
{
    [TestClass]
    public class PayrollCalculatorTests
    {
        private PayrollCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new PayrollCalculator();
        }

        [TestMethod]
        public void GrossPay_40Hours_Returns38000()
        {
            decimal result = calculator.CalculateGrossPay(40);
            Assert.AreEqual(38000m, result);
        }

        [TestMethod]
        public void GrossPay_20Hours_Returns19000()
        {
            decimal result = calculator.CalculateGrossPay(20);
            Assert.AreEqual(19000m, result);
        }

        [TestMethod]
        public void UIF_38000Gross_Returns380()
        {
            decimal result = calculator.CalculateUIF(38000m);
            Assert.AreEqual(380m, result);
        }

        [TestMethod]
        public void MembershipFee_38000Gross_Returns4940()
        {
            decimal result = calculator.CalculateMembershipFee(38000m);
            Assert.AreEqual(4940m, result);
        }

        [TestMethod]
        public void PAYE_38000Gross_0Dependents_Returns9500()
        {
            decimal result = calculator.CalculatePAYE(38000m, 0);
            Assert.AreEqual(9500m, result);
        }

        [TestMethod]
        public void PAYE_38000Gross_2Dependents_Returns8407_50()
        {
            decimal result = calculator.CalculatePAYE(38000m, 2);
            Assert.AreEqual(8407.50m, result);
        }

        [TestMethod]
        public void TotalDeductions_ReturnsCorrectSum()
        {
            decimal result = calculator.CalculateTotalDeductions(380m, 8407.50m, 4940m);
            Assert.AreEqual(13727.50m, result);
        }

        [TestMethod]
        public void NetPay_ReturnsCorrectNetPay()
        {
            decimal result = calculator.CalculateNetPay(38000m, 13727.50m);
            Assert.AreEqual(24272.50m, result);
        }

        [TestMethod]
        public void FullPayrollIntegration_With40HoursAnd2Dependents_ReturnsCorrectValues()
        {
            decimal grossPay = calculator.CalculateGrossPay(40);
            decimal uif = calculator.CalculateUIF(grossPay);
            decimal membershipFee = calculator.CalculateMembershipFee(grossPay);
            decimal paye = calculator.CalculatePAYE(grossPay, 2);
            decimal totalDeductions = calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            decimal netPay = calculator.CalculateNetPay(grossPay, totalDeductions);

            Assert.AreEqual(38000m, grossPay);
            Assert.AreEqual(380m, uif);
            Assert.AreEqual(4940m, membershipFee);
            Assert.AreEqual(8407.50m, paye);
            Assert.AreEqual(13727.50m, totalDeductions);
            Assert.AreEqual(24272.50m, netPay);
        }
    }
}