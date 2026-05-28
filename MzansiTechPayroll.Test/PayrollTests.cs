using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MzansiTechPayroll.Tests
{
    [TestClass]
    public class PayrollTests
    {
        [TestMethod]
        public void GrossPay_40Hours_Returns38000()
        {
            // Arrange
            PayrollCalculator calc = new PayrollCalculator();

            // Act
            decimal result = calc.CalculateGrossPay(40);

            // Assert
            Assert.AreEqual(38000m, result);
        }

        [TestMethod]
        public void UIF_38000Gross_Returns380()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculateUIF(38000m);
            Assert.AreEqual(380m, result);
        }

        [TestMethod]
        public void MembershipFee_38000Gross_Returns4940()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculateMembershipFee(38000m);
            Assert.AreEqual(4940m, result);
        }

        [TestMethod]
        public void PAYE_38000Gross_0Dependents_Returns9500()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculatePAYE(38000m, 0);
            Assert.AreEqual(9500m, result);
        }

        [TestMethod]
        public void PAYE_38000Gross_2Dependents_Returns8407_50()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculatePAYE(38000m, 2);
            Assert.AreEqual(8407.50m, result);
        }

        [TestMethod]
        public void TotalDeductions_ReturnsCorrectSum()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculateTotalDeductions(380m, 8407.50m, 4940m);
            Assert.AreEqual(13727.50m, result);
        }

        [TestMethod]
        public void NetPay_ReturnsCorrect()
        {
            PayrollCalculator calc = new PayrollCalculator();
            decimal result = calc.CalculateNetPay(38000m, 13727.50m);
            Assert.AreEqual(24272.50m, result);
        }
    }
}