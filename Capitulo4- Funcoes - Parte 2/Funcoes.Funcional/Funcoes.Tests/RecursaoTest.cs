// <copyright file="RecursaoTest.cs">Copyright ©  2016</copyright>
using System;
using Funcoes;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Funcoes.Tests
{
    /// <summary>This class contains parameterized unit tests for Recursao</summary>
    [PexClass(typeof(Recursao))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RecursaoTest
    {
        /// <summary>Test stub for Fatorial(Int32)</summary>
        [PexMethod]
        public int FatorialTest(int numeroParaRealizarOFatorial)
        {
            int result = Recursao.Fatorial(numeroParaRealizarOFatorial);
            return result;
            // TODO: add assertions to method RecursaoTest.FatorialTest(Int32)
        }
    }
}
