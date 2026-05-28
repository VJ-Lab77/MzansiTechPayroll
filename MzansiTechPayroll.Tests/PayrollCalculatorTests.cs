using Microsoft.VisualStudio.TestTools.UnitTesting;
using MzansiTechPayroll;

namespace MzansiTechPayroll.Tests
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

        // ========== GROSS PAY TESTS ==========

        [TestMethod]
        public void CalculateGrossPay_With40Hours_Returns38000()
        {
            // Arrange
            decimal hoursWorked = 40;
            decimal expectedGrossPay = 38000m;

            // Act
            decimal actualGrossPay = calculator.CalculateGrossPay(hoursWorked);

            // Assert
            Assert.AreEqual(expectedGrossPay, actualGrossPay, "Gross Pay calculation is incorrect");
        }

        [TestMethod]
        public void CalculateGrossPay_With20Hours_Returns19000()
        {
            decimal hoursWorked = 20;
            decimal expectedGrossPay = 19000m;

            decimal actualGrossPay = calculator.CalculateGrossPay(hoursWorked);

            Assert.AreEqual(expectedGrossPay, actualGrossPay);
        }

        [TestMethod]
        public void CalculateGrossPay_WithZeroHours_ReturnsZero()
        {
            decimal hoursWorked = 0;
            decimal expectedGrossPay = 0m;

            decimal actualGrossPay = calculator.CalculateGrossPay(hoursWorked);

            Assert.AreEqual(expectedGrossPay, actualGrossPay);
        }

        [TestMethod]
        public void CalculateGrossPay_With45Hours_Returns42750()
        {
            decimal hoursWorked = 45;
            decimal expectedGrossPay = 42750m;

            decimal actualGrossPay = calculator.CalculateGrossPay(hoursWorked);

            Assert.AreEqual(expectedGrossPay, actualGrossPay);
        }

        // ========== UIF TESTS ==========

        [TestMethod]
        public void CalculateUIF_WithGrossPay38000_Returns380()
        {
            decimal grossPay = 38000m;
            decimal expectedUIF = 380m;

            decimal actualUIF = calculator.CalculateUIF(grossPay);

            Assert.AreEqual(expectedUIF, actualUIF, "UIF should be 1% of Gross Pay");
        }

        [TestMethod]
        public void CalculateUIF_WithGrossPay19000_Returns190()
        {
            decimal grossPay = 19000m;
            decimal expectedUIF = 190m;

            decimal actualUIF = calculator.CalculateUIF(grossPay);

            Assert.AreEqual(expectedUIF, actualUIF);
        }

        [TestMethod]
        public void CalculateUIF_WithGrossPayZero_ReturnsZero()
        {
            decimal grossPay = 0m;
            decimal expectedUIF = 0m;

            decimal actualUIF = calculator.CalculateUIF(grossPay);

            Assert.AreEqual(expectedUIF, actualUIF);
        }

        // ========== MEMBERSHIP FEE TESTS ==========

        [TestMethod]
        public void CalculateMembershipFee_WithGrossPay38000_Returns4940()
        {
            decimal grossPay = 38000m;
            decimal expectedMembershipFee = 4940m;

            decimal actualMembershipFee = calculator.CalculateMembershipFee(grossPay);

            Assert.AreEqual(expectedMembershipFee, actualMembershipFee, "Membership Fee should be 13% of Gross Pay");
        }

        [TestMethod]
        public void CalculateMembershipFee_WithGrossPay19000_Returns2470()
        {
            decimal grossPay = 19000m;
            decimal expectedMembershipFee = 2470m;

            decimal actualMembershipFee = calculator.CalculateMembershipFee(grossPay);

            Assert.AreEqual(expectedMembershipFee, actualMembershipFee);
        }

        // ========== PAYE TESTS ==========

        [TestMethod]
        public void CalculatePAYE_WithGrossPay38000And0Dependents_Returns9500()
        {
            decimal grossPay = 38000m;
            int dependents = 0;
            decimal expectedPAYE = 9500m;

            decimal actualPAYE = calculator.CalculatePAYE(grossPay, dependents);

            Assert.AreEqual(expectedPAYE, actualPAYE, "PAYE with 0 dependents should be 25% of Gross Pay");
        }

        [TestMethod]
        public void CalculatePAYE_WithGrossPay38000And1Dependent_Returns8953_75()
        {
            decimal grossPay = 38000m;
            int dependents = 1;
            decimal expectedPAYE = 8953.75m;

            decimal actualPAYE = calculator.CalculatePAYE(grossPay, dependents);

            Assert.AreEqual(expectedPAYE, actualPAYE);
        }

        [TestMethod]
        public void CalculatePAYE_WithGrossPay38000And2Dependents_Returns8407_50()
        {
            decimal grossPay = 38000m;
            int dependents = 2;
            decimal expectedPAYE = 8407.50m;

            decimal actualPAYE = calculator.CalculatePAYE(grossPay, dependents);

            Assert.AreEqual(expectedPAYE, actualPAYE, "PAYE with 2 dependents calculation is incorrect");
        }

        [TestMethod]
        public void CalculatePAYE_WithGrossPay19000And3Dependents_Returns3930_63()
        {
            decimal grossPay = 19000m;
            int dependents = 3;
            decimal expectedPAYE = 3930.63m;

            decimal actualPAYE = calculator.CalculatePAYE(grossPay, dependents);

            // Allow small rounding difference (0.01)
            Assert.AreEqual(expectedPAYE, actualPAYE, 0.01m);
        }

        // ========== TOTAL DEDUCTIONS TESTS ==========

        [TestMethod]
        public void CalculateTotalDeductions_ReturnsCorrectSum()
        {
            decimal uif = 380m;
            decimal paye = 8407.50m;
            decimal membershipFee = 4940m;
            decimal expectedTotal = 13727.50m;

            decimal actualTotal = calculator.CalculateTotalDeductions(uif, paye, membershipFee);

            Assert.AreEqual(expectedTotal, actualTotal, "Total Deductions should sum all deductions");
        }

        [TestMethod]
        public void CalculateTotalDeductions_WithZeroValues_ReturnsZero()
        {
            decimal uif = 0m;
            decimal paye = 0m;
            decimal membershipFee = 0m;
            decimal expectedTotal = 0m;

            decimal actualTotal = calculator.CalculateTotalDeductions(uif, paye, membershipFee);

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        // ========== NET PAY TESTS ==========

        [TestMethod]
        public void CalculateNetPay_ReturnsCorrectNetPay()
        {
            decimal grossPay = 38000m;
            decimal totalDeductions = 13727.50m;
            decimal expectedNetPay = 24272.50m;

            decimal actualNetPay = calculator.CalculateNetPay(grossPay, totalDeductions);

            Assert.AreEqual(expectedNetPay, actualNetPay, "Net Pay should be Gross Pay minus Total Deductions");
        }

        [TestMethod]
        public void CalculateNetPay_WithNoDeductions_ReturnsGrossPay()
        {
            decimal grossPay = 38000m;
            decimal totalDeductions = 0m;
            decimal expectedNetPay = 38000m;

            decimal actualNetPay = calculator.CalculateNetPay(grossPay, totalDeductions);

            Assert.AreEqual(expectedNetPay, actualNetPay);
        }

        // ========== INTEGRATION TESTS ==========

        [TestMethod]
        public void FullPayrollCalculation_With40HoursAnd2Dependents_ReturnsCorrectResults()
        {
            // Arrange
            decimal hoursWorked = 40;
            int dependents = 2;

            // Act - Full workflow integration
            decimal grossPay = calculator.CalculateGrossPay(hoursWorked);
            decimal uif = calculator.CalculateUIF(grossPay);
            decimal membershipFee = calculator.CalculateMembershipFee(grossPay);
            decimal paye = calculator.CalculatePAYE(grossPay, dependents);
            decimal totalDeductions = calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            decimal netPay = calculator.CalculateNetPay(grossPay, totalDeductions);

            // Assert - Verify all calculations work together
            Assert.AreEqual(38000m, grossPay, "Gross Pay incorrect");
            Assert.AreEqual(380m, uif, "UIF incorrect");
            Assert.AreEqual(4940m, membershipFee, "Membership Fee incorrect");
            Assert.AreEqual(8407.50m, paye, "PAYE incorrect");
            Assert.AreEqual(13727.50m, totalDeductions, "Total Deductions incorrect");
            Assert.AreEqual(24272.50m, netPay, "Net Pay incorrect");
        }

        [TestMethod]
        public void FullPayrollCalculation_With20HoursAnd1Dependent_ReturnsCorrectResults()
        {
            // Arrange
            decimal hoursWorked = 20;
            int dependents = 1;

            // Act
            decimal grossPay = calculator.CalculateGrossPay(hoursWorked);
            decimal uif = calculator.CalculateUIF(grossPay);
            decimal membershipFee = calculator.CalculateMembershipFee(grossPay);
            decimal paye = calculator.CalculatePAYE(grossPay, dependents);
            decimal totalDeductions = calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            decimal netPay = calculator.CalculateNetPay(grossPay, totalDeductions);

            // Assert
            Assert.AreEqual(19000m, grossPay);
            Assert.AreEqual(190m, uif);
            Assert.AreEqual(2470m, membershipFee);
        }

        // ========== EDGE CASE TESTS ==========

        [TestMethod]
        public void CalculatePAYE_WithMaxDependents10_ReturnsValidResult()
        {
            decimal grossPay = 38000m;
            int dependents = 10;

            decimal actualPAYE = calculator.CalculatePAYE(grossPay, dependents);

            Assert.IsTrue(actualPAYE >= 0, "PAYE should not be negative even with many dependents");
        }

        [TestMethod]
        public void CalculateGrossPay_WithLargeHours_ReturnsLargeValue()
        {
            decimal hoursWorked = 1000;
            decimal expectedGrossPay = 950000m;

            decimal actualGrossPay = calculator.CalculateGrossPay(hoursWorked);

            Assert.AreEqual(expectedGrossPay, actualGrossPay);
        }
    }
}