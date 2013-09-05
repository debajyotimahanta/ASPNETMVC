using System;
using An.MyAon.Common;
using An.MyAon.Common.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aon.MyAon.UnitTests
{
    [TestClass]
    public class CommonUtilTest
    {
        [TestMethod]
        public void ConvertStringToLanuage_test_valid_lauguage()
        {
            Assert.AreEqual(Language.English, AllPurposeConverter.ConvertStringToLanuage("English"));
        }

        [TestMethod]
        public void ConvertStringToLanguage_test_invalid_language()
        {
            Assert.IsNull(AllPurposeConverter.ConvertStringToLanuage("Test"));
        }
    }
}
