using NUnit.Framework;
using DateFormat;

namespace Test;

public class CambiarFormatoTests
{
    [Test]
    [TestCase("12/12/2012", "D: 12 | M: 12 | A: 2012")]
    [TestCase("1/1/2012", "D: 1 | M: 1 | A: 2012")]
    [TestCase("01/05/95", "D: 01 | M: 05 | A: 95")]
    public void DadaUnaFechaCorrecta_LaDevuelveConOtroFormato(string fecha, string resultado)
    {
        var nuevaFecha = Program.CambiarFormato(fecha);
        Assert.AreEqual(nuevaFecha, resultado);
    }

    [Test]
    [TestCase("12/12/", "")]
    [TestCase("12-12-2012", "")]
    [TestCase("", "")]
    [TestCase(null, "")]
    public void DadaUnaFechaIncorrecta_DevuelveUnaCadenaVacía(string fecha, string resultado)
    {
        var nuevaFecha = Program.CambiarFormato(fecha);
        Assert.AreEqual(nuevaFecha, resultado);
    }
}