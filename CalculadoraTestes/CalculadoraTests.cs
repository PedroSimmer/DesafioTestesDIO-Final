using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    
    //Teste Somar
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(15, resultado);
    }
    
    //Teste Somar
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(20, resultado);
    }
    
    //Testa se é par:
    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;
        // Act
        bool resultado = _calc.Ehpar(numero);
        // Assert
        Assert.True(resultado);
    }
    
    // Testa se o array informado é par: 
    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act / Asset
        Assert.All(numeros, num => Assert.True(_calc.Ehpar(num)));
    }
    
    //Teste Subtração:
    [Theory]
    [InlineData(5, 3, 2)]
    public void DeveSubtrair3De5ERetornar2(int num1, int num2, int res)
    {
        // Act
        int resultado = _calc.Subtrair(num1, num2);
        // Assert
        Assert.Equal(res, resultado);
    }

    //Teste Divisão
    [Theory]
    [InlineData(10, 2, 5)]
    public void DeveDividir10Por2ERetornar5(int num1, int num2,int res)
    {
        // Act
        int resultado = _calc.Dividir(num1, num2);
        // Assert
        Assert.Equal(res, resultado);
    }

    //Testar Histórico
    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = new CalculadoraImp();
        calc.Somar(2, 3);
        calc.Subtrair(5, 2);
        calc.Dividir(10, 2);
        calc.Somar(2,2);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count);
        
    }
}    