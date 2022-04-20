using NUnit.Framework;
using DateFormat;

namespace Test;

public class ChangeFormatTests
{
    [Test]
    [TestCase("10/11/1977", "1977-11-10")]
    [TestCase("01/06/2010", "2010-06-01")]
    public void DadaUnaFechaConBarra_DevuelveLaMismaFechaConGuión(string fecha, string resultado)
    {
        var nuevaFecha = Program.ChangeFormat(fecha);
        Assert.AreEqual(nuevaFecha, resultado);
    }
}