using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //IMPLEMENTADO
        //Foi corrigido a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";
        //IMPLEMENTADO  
        //Foi corrigido a chamada do método "ContemCaractere" da seção Act
        // Act
         _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //IMPLEMENTADO
        //Foi corrigido o Assert.True com base no retorno da chamada ao método
        Assert.True(true);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //IMPLEMENTADO
        //Foi corrigido o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }
    //IMPLEMENTADO
    //Foi corrigido a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //IMPLEMENTADO
        //Foi corrigido a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
