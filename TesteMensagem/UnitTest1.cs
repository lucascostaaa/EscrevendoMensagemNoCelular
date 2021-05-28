using EscrevendoNoCelular;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteMensagem
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void DigitandoMsg()
            {
                Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", new ConverteMenssagem().converterMensagem("SEMPRE ACESSO O DOJOPUZZLES"));

            }

            [TestMethod]
            public void LimiteDeCaracteresInvalido()
            {
                Assert.AreEqual("Limite inválido", new ConverteMenssagem().converterMensagem("Praesent in mauris eu tortor porttitor accumsan. Mauris suscipit, ligula sit amet pharetra semper, nibh ante cursus purus, vel sagittis velit mauris vel metus. Aenean fermentum risus id tortor. Integer imperdiet lectus quis justo. Integer tempor. Vivamus ac urna vel leo pretium faucibus. Mauris elementum mauris vitae tortor. In dapibus augue non sapien. Aliquam ante. Curabitur bibendum justo non orci. Praesent in mauris eu tortor porttitor accumsan. Mauris suscipit, ligula sit amet pharetra semper, nibh ante cursus purus, vel sagittis velit mauris vel metus. Aenean fermentum risus id tortor. Integer imperdiet lectus quis justo. Integer tempor. Vivamus ac urna vel leo pretium faucibus. Mauris elementum mauris vitae tortor. In dapibus augue non sapien. Aliquam ante. Curabitur bibendum justo non orci."));

            }
        }
    }
    

