using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDLecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLecture.Tests
{
    [TestClass()]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors kpf;// = new KataPrimeFactors(); //<-- this introduces a scenario where we may have bugs because kpf "remembers state"

        [TestInitialize]
        public void Initialize()
        {
            kpf = new KataPrimeFactors();
        }

        [TestMethod]
        public void KPF_WhenPassed2_ReturnOnly2()
        {
            int[] result = kpf.Factorize(2); //<-- [2] hopefully
            CollectionAssert.AreEqual(new int[] { 2 }, result);
        }

        [TestMethod]
        public void KPF_WhenPassed3_ReturnOnly3()
        {
            int[] result = kpf.Factorize(3); //<-- [3] hopefully
            CollectionAssert.AreEqual(new int[] { 3 }, result);
        }

        [TestMethod]
        public void KPF_WhenPassed5_ReturnOnly5()
        {
            int[] result = kpf.Factorize(5);
            CollectionAssert.AreEqual(new int[] { 5 }, result);
        }

        [TestMethod]
        public void KPF_WhenPassed4_ReturnTwo2s()
        {
            int[] result = kpf.Factorize(4);
            CollectionAssert.AreEqual(new int[] { 2, 2 }, result);
        }

        [TestMethod]
        public void KPF_WhenPassed6_Return2And3()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, kpf.Factorize(6));
        }

        [TestMethod]
        public void KPF_WhenPassed10_Return2And5()
        {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, kpf.Factorize(10));
        }

        [TestMethod]
        public void KPF_WhenPassed12_Return2And2Threes()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 3 }, kpf.Factorize(12));
        }

        [TestMethod]
        public void KPF_WhenPassed9_Return2Threes()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3 }, kpf.Factorize(9));
        }

        [TestMethod]
        public void KPF_WhenPassed27_Return3Threes()
        {
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, kpf.Factorize(27));
        }

        [TestMethod]
        public void KPF_WhenPassed18_Return1TwoAnd2Threes()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 3 }, kpf.Factorize(18));
        }

        [TestMethod]
        public void KPF_WhenPassed25_Return2Fives()
        {
            CollectionAssert.AreEqual(new int[] { 5, 5 }, kpf.Factorize(25));
        }

        [TestMethod]
        public void KPF_PrimeFactor_ReallyBigNumber()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 29, 2377 }, kpf.Factorize(275732));
        }

        [TestMethod]
        public void KPF_PrimeFactor8_Returns3Twos()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, kpf.Factorize(8));

        }


    }
}